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
            return $"{Quantity(number).Capitalize()} {Container(number)} of beer on the wall, " +
                   $"{Quantity(number)} {Container(number)} of beer.\r\n" +
                   $"{Action(number)}, " +
                   $"{Quantity(Successor(number))} {Container(Successor(number))} of beer on the wall.";
        }

        public string Container(int number)
        {
            return new BottleNumber(number).Container(number);
        }

        public string Pronoun(int number)
        {
            return new BottleNumber(number).Pronoun(number);
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

        public string Action(int number)
        {
            if (number == 0)
            {
                return "Go to the store and buy some more";
            }
            return $"Take {Pronoun(number)} down and pass it around";
        }

        public int Successor(int number)
        {
            if (number == 0)
            {
                return 99;
            }

            return number - 1;
        }
    }
}