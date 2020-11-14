﻿using System;

namespace ExtHelper
{
    /// <summary>
    /// Класс ExtMeth, включает в себя 2 метода
    /// </summary>
    public static class ExtMeth
    {
        /// <summary>
        /// Метод определения конкретного бита
        /// </summary>
        /// <param name="data"></param>
        /// <param name="position"></param>
        /// <param name="size"></param>
        /// <returns>е</returns>
        public static bool GetBits(this int data, int position, int size)
        {
            if (position < 0 || position > size)
            {
                throw new ArgumentOutOfRangeException();
            }

            int bit = (data >> position) & 1;
            return Convert.ToBoolean(bit);
        }

        public static int SetBits(this ref int data, int bit, int position, int size)
        {
            if (position < 0 || position > size)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (bit == 1)
            {
                return data = data | 1 << position;
            }
            else
            {
                return data = data & ~(1 << position);
            }

        }
    }
}
