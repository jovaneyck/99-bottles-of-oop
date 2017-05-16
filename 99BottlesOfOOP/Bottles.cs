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
            var bottleNumber = new BottleNumber(number);
            var nextBottleNumber = new BottleNumber(bottleNumber.Successor());
            return $"{bottleNumber.Quantity().Capitalize()} {bottleNumber.Container()} of beer on the wall, " +
                   $"{bottleNumber.Quantity()} {bottleNumber.Container()} of beer.\r\n" +
                   $"{bottleNumber.Action()}, " +
                   $"{nextBottleNumber.Quantity()} {nextBottleNumber.Container()} of beer on the wall.";
        }

        public string Container(int number)
        {
            return new BottleNumber(number).Container();
        }

        public string Pronoun(int number)
        {
            return new BottleNumber(number).Pronoun();
        }

        public string Quantity(int number)
        {
            return new BottleNumber(number).Quantity();
        }

        public string Action(int number)
        {
            return new BottleNumber(number).Action();
        }

        public int Successor(int number)
        {
            return new BottleNumber(number).Successor();
        }
    }
}