using Astonishia.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astonishia.Character
{
    public class AstCharactor
    {
        private AstClient client = null;
        private AstCharType type;
        private const int defaultOffset = 0x464478;
        private const int regionSize = 0x6CF;
        private readonly uint[] expTable = new uint[29];
        
        public AstCharactor(AstClient client, AstCharType type)
        {
            this.client = client;
            this.type = type;
            InitializeExpTable();
        }

        public void InitializeExpTable()
        {
            for (int i = 0; i < expTable.Length;i++)
            {
                expTable[i] = client.Memory.ReadUInt32(IntPtr.Add(StatusAddress,(int) AstStatusFlag.EXP_TABLE + (i * 4)));
            }
        }

        public int Index
        {
            get
            {
                return Array.IndexOf(Enum.GetValues(type.GetType()), type);
            }
        }

        public string Name {
            get
            {
                return Enum.GetName(type.GetType(), type);
            }
        }
        public uint Level { 
            get
            {
                uint _lvl = GetStatus(AstStatusFlag.LEVEL);
                if (_lvl < 1)
                    _lvl = 1;

                return _lvl;
                
            }
            set
            {
                SetStatusValue(AstStatusFlag.LEVEL, value);
            }
        }
        public uint MaxHP
        {
            get
            {
                return GetStatus(AstStatusFlag.MAX_HP);
            }
            set
            {
                SetStatusValue(AstStatusFlag.MAX_HP, value);
            }
        }
        public uint MaxMP
        {
            get
            {
                return GetStatus(AstStatusFlag.MAX_MP);
            }
            set
            {
                SetStatusValue(AstStatusFlag.MAX_MP, value);
            }
        }
        public uint HP
        {
            get
            {
                return GetStatus(AstStatusFlag.HP);
            }
            set
            {
                SetStatusValue(AstStatusFlag.HP, value);
            }
        }
        public uint MP
        {
            get
            {
                return GetStatus(AstStatusFlag.MP);
            }
            set
            {
                SetStatusValue(AstStatusFlag.MP, value);
            }
        }

        public uint EXP
        {
            get
            {
                uint _exp = GetStatus(AstStatusFlag.EXP);
                if (Level > 1)
                {
                    return _exp - ExpTable[Level - 2];
                } else
                {
                    return _exp;
                }
            }
            set
            {
                SetStatusValue(AstStatusFlag.EXP,ExpTable[Level- 2] + value);
            }
        }
        public uint[] ExpTable { 
            get
            {
                return expTable;
            }
        }
        public uint NextLevelExp
        {
            get
            {
                if (Level > 1)
                {
                    uint OldExp = ExpTable[Level - 2];
                    uint CurrExp = ExpTable[Level - 1];
                    return CurrExp - OldExp;
                } else
                {
                    return ExpTable[Level - 1];
                }
                
            }
        }
        public uint Attack
        {
            get
            {
                return GetStatus(AstStatusFlag.ATTACK);
            }
            set
            {
                SetStatusValue(AstStatusFlag.ATTACK, value);
            }
        }
        public uint Defense
        {
            get
            {
                return GetStatus(AstStatusFlag.DEFENSE);
            }
            set
            {
                SetStatusValue(AstStatusFlag.DEFENSE, value);
            }
        }
        public uint Move
        {
            get
            {
                return GetStatus(AstStatusFlag.MOVE);
            }
            set
            {
                SetStatusValue(AstStatusFlag.MOVE, value);
            }
        }
        public uint Dexterity
        {
            get
            {
                return GetStatus(AstStatusFlag.DEXTERITY);
            }
            set
            {
                SetStatusValue(AstStatusFlag.DEXTERITY, value);
            }
        }

        public uint Technician
        {
            get
            {
                return GetStatus(AstStatusFlag.TECHNICIAN);
            }
            set
            {
                SetStatusValue(AstStatusFlag.TECHNICIAN, value);
            }
        }

        public bool Party
        {
            get
            {
                return GetStatus(AstStatusFlag.PARTY) == 1;
            }
            set
            {
                SetStatusValue(AstStatusFlag.PARTY,Convert.ToUInt32(value));
            }
        }

        private IntPtr StatusAddress
        {
            get
            {
                IntPtr baseStatus = IntPtr.Add(client.BaseAddress, defaultOffset);
                IntPtr chrType = IntPtr.Add(baseStatus, Index * (regionSize+1));

                return chrType;
            }
        }

        private uint GetStatus(AstStatusFlag status)
        {
            return client.Memory.ReadUInt32(IntPtr.Add(StatusAddress, (int)status));
        }

        private void SetStatusValue(AstStatusFlag status, uint value)
        {
            client.Memory.WriteUInt32(IntPtr.Add(StatusAddress, (int)status),value);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("이름: {0}", Name));
            sb.AppendLine(string.Format("레벨: {0}", Level));
            sb.AppendLine(string.Format("HP: {0}/{1}", HP,MaxHP));
            sb.AppendLine(string.Format("MP: {0}/{1}", MP,MaxMP));
            sb.AppendLine(string.Format("공격력: {0}", Attack));
            sb.AppendLine(string.Format("방어력: {0}", Defense));
            sb.AppendLine(string.Format("민첩성: {0}", Dexterity));
            sb.AppendLine(string.Format("이동거리: {0}", Move));
            sb.AppendLine(string.Format("기술력: {0}", Technician));
            sb.AppendLine(string.Format("경험치: {0}/{1}", EXP,NextLevelExp));
            sb.AppendLine(string.Format("파티상태: {0}", Party));

            return sb.ToString();
        }
    }
}
