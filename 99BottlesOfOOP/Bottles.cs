using System.Linq;
using static System.String;

namespace _99BottlesOfOOP
{
    public class Bottles
    {
        public string Song()
        {
            return Verses(99,  0);
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
            switch (number)
            {
                case 0:
                    return "No more bottles of beer on the wall, no more bottles of beer.\r\nGo to the store and buy some more, 99 bottles of beer on the wall.";
                default:
                    return $"{number} {Container(number)} of beer on the wall, {number} {Container(number)} of beer.\r\nTake {Pronoun(number)} down and pass it around, {Quantity(number - 1)} {Container(number - 1)} of beer on the wall.";
            }
        }

        public string Container(int number)
        {
            if (number == 1)
            {
                return "bottle";
            }

            return "bottles";
        }

        public string Pronoun(int number)
        {
            if (number == 1)
            {
                return "it";
            }
            return "one";
        }

        public string Quantity(int number)
        {
            if (number == 0)
            {
                return "no more";
            }
            return number.ToString();
        }
    }
}