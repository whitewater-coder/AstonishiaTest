using Astonishia.Character;
using Astonishia.Client.Character;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Astonishia.Client
{
    public class AstClient
    {
        private IntPtr baseAddress = IntPtr.Zero;
        private AstCharactor[] charactors = new AstCharactor[12];
        private AstStorage storage = null;
        private VAMemory vaMemory;
        private Process process = null;

        public AstClient(Process process)
        {
            this.process = process;
            Initialize();
            InitializeScanMemory();
            InitializeCharacters();
            InitializeStorages();
        }

        private void Initialize()
        {
            vaMemory = new VAMemory(AstConstants.PROCESS_NAME);
        }

        private void InitializeScanMemory()
        {
            var sysInfo = new SYSTEM_INFO();
            GetSystemInfo(out sysInfo);
            var mbi = new MEMORY_BASIC_INFORMATION();
            IntPtr procHandle = OpenProcess(0x10 | 0x20 | 0x400, false, process.Id);

            uint mbiSize = (uint)Marshal.SizeOf(mbi);

            uint minAddr = 0;
            uint maxAddr = (uint)sysInfo.MaxAddress;

            bool isDone = false;
            long findAddress = 0;

            do
            {
                VirtualQueryEx(procHandle, sysInfo.MinAddress, out mbi, mbiSize);
                byte[] buffer = new byte[(int)mbi.RegionSize];
                int readBytes = 0;
                if (mbi.RegionSize.ToInt32() > 0)
                {
                    ReadProcessMemory(procHandle, (IntPtr)minAddr, buffer, buffer.Length, out readBytes);
                    if (readBytes > 0)
                    {
                        var searchEngine = new BoyerMoore(AstConstants.SCAN_PATTERN);
                        int resultOffset = searchEngine.Search(buffer);
                        if (resultOffset > 0)
                        {
                            findAddress = minAddr + resultOffset;
                            isDone = true;
                        }
                    }
                }

                minAddr += (uint)mbi.RegionSize;
            } while (minAddr < maxAddr && !isDone);

            baseAddress = IntPtr.Add((IntPtr)findAddress, -0x4006);
            Memory.WriteInt32(baseAddress, 142857);
        }

        private void InitializeCharacters()
        {
            foreach (AstCharType type in Enum.GetValues(typeof(AstCharType)))
            {
                int i = Array.IndexOf(Enum.GetValues(type.GetType()), type);
                charactors[i] = new AstCharactor(this, type);
            }
        }

        private void InitializeStorages()
        {
            storage = new AstStorage(this);
        }

        public bool VerifyTest
        {
            get
            {
                return Memory.ReadInt32(BaseAddress) == 142857;
            }
        }

        public VAMemory Memory
        {
            get
            {
                return vaMemory;
            }
        }

        public IntPtr BaseAddress
        {
            get
            {
                return baseAddress;
            }
        }
        public AstCharactor GetCharacter(AstCharType type)
        {
            int i = Array.IndexOf(Enum.GetValues(type.GetType()), type);

            return charactors[i];
        }

        public AstCharactor[] Characters
        {
            get
            {
                return charactors;
            }
        }

        public AstStorage Storage
        {
            get
            {
                return storage;
            }
        }


        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr OpenProcess(
            int dwDesiredAccess,
            bool bInheritHandle,
            int dwProcessId
        );

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(
            IntPtr hProcess,
            IntPtr lpBaseAddress,
            [Out] byte[] lpBuffer,
            int dwSize,
            out int lpNumberOfBytesRead
        );
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int VirtualQueryEx(
            IntPtr hProcess,
            IntPtr lpAddress,
            out MEMORY_BASIC_INFORMATION lpBuffer,
            uint dwLength
        );
        [DllImport("kernel32.dll")]
        static extern void GetSystemInfo(out SYSTEM_INFO systemInfo);

        [StructLayout(LayoutKind.Sequential)]
        public struct MEMORY_BASIC_INFORMATION
        {
            public IntPtr BaseAddress;
            public IntPtr AllocationBase;
            public uint AllocationProtect;
            public IntPtr RegionSize;
            public uint State;
            public uint Protect;
            public uint Type;
        }

        public struct SYSTEM_INFO
        {
            public ushort processorArchitecture;
            ushort reserved;
            public uint pageSize;
            public IntPtr MinAddress;  // minimum address
            public IntPtr MaxAddress;  // maximum address
            public IntPtr activeProcessorMask;
            public uint numberOfProcessors;
            public uint processorType;
            public uint allocationGranularity;
            public ushort Level;
            public ushort Revision;
        }
    }
}
