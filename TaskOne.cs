using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class TaskOne
    {
        //Реализуйте операторы неявного приведения из long,int,bit в Bits.
        public interface IBitGetable
        {
            bool GetBitByIndex(byte index);
            void SetBitByIndex(byte index, bool value);
        }

        public class Bits : IBitGetable
        {
            public long Value { get; private set; }
            public int Length { get; private set; }

            public Bits(byte value)
            {
                Value = value;
                Length = sizeof(long);
            }

            public Bits(int value)
            {
                Value = value;
                Length = sizeof(int);
            }

            public Bits(long value)
            {
                Value = value;
                Length = sizeof(long);
            }

            public bool GetBitByIndex(byte index)
            {
                return (Value & (1 << index)) != 0;
            }

            public void SetBitByIndex(byte index, bool value)
            {
                if (value)
                {
                    Value |= (byte)(1 << index);
                }
                else
                {
                    Value &= (byte)~(1 << index);
                }
            }
            public bool this[byte index]
            {
                get
                {
                    return GetBitByIndex(index);
                }

                set
                {
                    SetBitByIndex(index, value);
                }
            }
            public static implicit operator long(Bits bits) => bits.Value;
            public static explicit operator Bits(long value) => new Bits(value);

            public static implicit operator int(Bits bits) => (int)bits.Value;
            public static explicit operator Bits(int value) => new Bits(value);

            public static implicit operator byte(Bits bits) => (byte)bits.Value;
            public static explicit operator Bits(byte value) => new Bits(value);
        }
    }
}
