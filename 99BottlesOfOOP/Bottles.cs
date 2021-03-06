﻿using System.Collections;
using System.Linq;
using static System.String;

namespace _99BottlesOfOOP
{
    public class Bottles
    {
        public string Song()
        {
            return Verses(99, 0);
        }

        public string Verses(int first, int last)
        {
            var verses =
                Enumerable
                    .Range(last, first - last + 1)
                    .Reverse()
                    .Select(Verse);

            return Join($"\r\n\r\n", verses);
        }

        public string Verse(int number)
        {
            var bottleNumber = BottleNumber.For(number);

            return $"{bottleNumber} of beer on the wall, ".Capitalize() +
                   $"{bottleNumber} of beer.\r\n" +
                   $"{bottleNumber.Action()}, " +
                   $"{bottleNumber.Successor()} of beer on the wall.";
        }
    }
}