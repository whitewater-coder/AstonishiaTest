using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astonishia.Client.Character
{
    public class AstStorage
    {
        private AstClient client;
        private IntPtr moneyOffset;
        public AstStorage(AstClient client)
        {
            this.client = client;
            moneyOffset = IntPtr.Add(client.BaseAddress, 0x464448);
        }

        public uint Money
        {
            get
            {
                var mem = client.Memory;
                return mem.ReadUInt32(moneyOffset);
            }
            set
            {
                var mem = client.Memory;
                mem.WriteUInt32(moneyOffset, value);
            }
        }
    }
}
