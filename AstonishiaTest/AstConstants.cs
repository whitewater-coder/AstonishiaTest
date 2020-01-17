using Astonishia.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astonishia
{
    public class AstConstants
    {
        /// <summary>
        /// PPSSPP 에뮬레이터 프로세스 이름입니다.
        /// </summary>
        public static readonly string PROCESS_NAME = "PPSSPPWindows";
        /// <summary>
        /// 포인터를 찾을 바이트 배열 패턴입니다.
        /// </summary>
        public static readonly byte[] SCAN_PATTERN = new byte[] { 
            0xA0, 0xA3, 
            0x21, 0x00, 
            0xA0, 0xA3, 
            0xFF, 0x00 
        };
        /// <summary>
        /// 게임 캐릭터 초상화 목록입니다.
        /// </summary>
        public static readonly Bitmap[] PORTRAITS = new Bitmap[] {
            Resources.portrait_1,
            Resources.portrait_2,
            Resources.portrait_3,
            Resources.portrait_4,
            Resources.portrait_5,
            Resources.portrait_6,
            Resources.portrait_7,
            Resources.portrait_8,
            Resources.portrait_9,
            Resources.portrait_10,
            Resources.portrait_11,
            Resources.portrait_12
        };
    }
}
