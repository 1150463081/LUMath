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

        const int BIT_MOVE_COUNT = 10;
        const int MUTLIPLIER_FACTOR = 1 << 10;

        public LUInt(int value)
        {
            scaledValue = value * MUTLIPLIER_FACTOR;
        }
        public LUInt(float value)
        {
            scaledValue = (long)Math.Round(value * MUTLIPLIER_FACTOR);
        }
    }
}
