﻿using System;
using System.Numerics;

namespace centuriesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            short years = (short)(centuries * 100);
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            long minutes = hours * 60;
            BigInteger seconds = minutes * 60;
            BigInteger milliseconds = seconds * 1000;
            BigInteger microsecond = milliseconds * 1000;
            BigInteger nanosecond = microsecond * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes}" +
                $" minutes = {seconds} seconds = {milliseconds} milliseconds = {microsecond}" +
                $" microseconds = {nanosecond} nanoseconds");
        }
    }
}