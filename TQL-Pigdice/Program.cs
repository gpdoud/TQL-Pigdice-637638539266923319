﻿using System;

namespace TQL_Pigdice {
    class Program {
        static void Main(string[] args) {

            var pigdice = new PigDice();
            int[] results = pigdice.Play(500);
            Console.WriteLine($"High score is {results[0]} for {results[1]} games played");
        }
    }
}
