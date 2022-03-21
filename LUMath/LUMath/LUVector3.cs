using System;
using System.Collections.Generic;
using System.Text;

namespace LUMath
{
    public struct LUVector3
    {
        public LUInt x;
        public LUInt y;
        public LUInt z;
        public LUVector3(LUInt x, LUInt y, LUInt z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public LUInt this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return x;
                    case 1:
                        return y;
                    case 2:
                        return z;
                    default:
                        return 0;
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        x = value;
                        break;
                    case 1:
                        y = value;
                        break;
                    case 2:
                        z = value;
                        break;
                }
            }
        }

        #region 常用向量
        public static LUVector3 zero
        {
            get
            {
                return new LUVector3(0, 0, 0);
            }
        }
        public static LUVector3 one
        {
            get
            {
                return new LUVector3(1, 1, 1);
            }
        }
        public static LUVector3 forward
        {
            get
            {
                return new LUVector3(0, 0, 1);
            }
        }
        public static LUVector3 back
        {
            get
            {
                return new LUVector3(0, 0, -1);
            }
        }
        public static LUVector3 left
        {
            get
            {
                return new LUVector3(-1, 0, 0);
            }
        }
        public static LUVector3 right
        {
            get
            {
                return new LUVector3(1, 0, 0);
            }
        }
        public static LUVector3 up
        {
            get
            {
                return new LUVector3(0, 1, 0);
            }
        }
        public static LUVector3 down
        {
            get
            {
                return new LUVector3(0, -1, 0);
            }
        }
        #endregion
    }
}
