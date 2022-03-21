using System;

namespace LUMath
{
    public struct LUInt
    {
        private long scaledValue;
        public long ScaledValue
        {
            get { return scaledValue; }
            set { scaledValue = value; }
        }
        //左移位数
        const int BIT_MOVE_COUNT = 10;
        //放大倍数
        const int MUTLIPLIER_FACTOR = 1 << BIT_MOVE_COUNT;

        #region 构造
        private LUInt(long scaledValue)
        {
            this.scaledValue = scaledValue;
        }
        public LUInt(int value)
        {
            scaledValue = value * MUTLIPLIER_FACTOR;
        }
        public LUInt(float value)
        {
            scaledValue = (long)Math.Round(value * MUTLIPLIER_FACTOR);
        }
        //显式转换
        public static explicit operator LUInt(float f)
        {
            return new LUInt(f);
        }
        //隐式转换
        public static implicit operator LUInt(int a)
        {
            return new LUInt(a);
        }
        #endregion
        #region 关系运算符
        public static LUInt operator +(LUInt a, LUInt b)
        {
            return new LUInt(a.scaledValue + b.scaledValue);
        }
        public static LUInt operator -(LUInt a, LUInt b)
        {
            return new LUInt(a.scaledValue - b.scaledValue);
        }
        public static LUInt operator *(LUInt a, LUInt b)
        {
            long val = a.scaledValue * b.scaledValue;
            if (val >= 0)
                val >>= BIT_MOVE_COUNT;
            else
                val = -(-val >> BIT_MOVE_COUNT);
            return new LUInt(val);
        }
        public static LUInt operator /(LUInt a, LUInt b)
        {
            if (b.scaledValue == 0)
                throw new Exception();
            return new LUInt((a.scaledValue << BIT_MOVE_COUNT) / b.scaledValue);
        }
        public static LUInt operator -(LUInt val)
        {
            return new LUInt(-val.scaledValue);
        }
        public static bool operator ==(LUInt a, LUInt b)
        {
            return a.scaledValue == b.scaledValue;
        }
        public static bool operator !=(LUInt a, LUInt b)
        {
            return a.scaledValue != b.scaledValue;
        }
        public static bool operator >(LUInt a, LUInt b)
        {
            return a.scaledValue > b.scaledValue;
        }
        public static bool operator <(LUInt a, LUInt b)
        {
            return a.scaledValue < b.scaledValue;
        }
        public static bool operator >=(LUInt a, LUInt b)
        {
            return a.scaledValue >= b.scaledValue;
        }
        public static bool operator <=(LUInt a, LUInt b)
        {
            return a.scaledValue <= b.scaledValue;
        }
        #endregion
        /// <summary>
        /// 不可参与逻辑运算
        /// </summary>
        public float RawFloat
        {
            get { return scaledValue * 1f / MUTLIPLIER_FACTOR; }
        }
        public int RawInt
        {
            get
            {
                if (scaledValue > 0)
                    return (int)(scaledValue >> BIT_MOVE_COUNT);
                else
                    return -(int)(-scaledValue >> BIT_MOVE_COUNT);
            }
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            LUInt val = (LUInt)obj;
            return scaledValue == val.scaledValue;
        }
        public override int GetHashCode()
        {
            return scaledValue.GetHashCode();
        }
        public override string ToString()
        {
            return RawFloat.ToString();
        }
    }
}
