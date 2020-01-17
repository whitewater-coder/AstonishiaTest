using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astonishia.Client
{
    public enum AstStatusFlag
    {
        MAX_HP      = 0x0,
        MAX_MP      = 0x4,
        ATTACK      = 0x8,
        DEFENSE     = 0xC,
        DEXTERITY   = 0x10,
        MOVE        = 0x14,
        TECHNICIAN  = 0x18,
        LEVEL       = 0x50,
        EXP_TABLE   = 0x9C,
        HP          = 0x66C,
        MP          = 0x670,
        PARTY       = 0x678,
        EXP         = 0x67C
    }
}
