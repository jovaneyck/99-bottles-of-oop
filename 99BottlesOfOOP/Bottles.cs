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
            return $"{bottleNumber}".Capitalize() + " of beer on the wall, " +
                   $"{bottleNumber} of beer.\r\n" +
                   $"{bottleNumber.Action()}, " +
                   $"{nextBottleNumber} of beer on the wall.";
        }
    }
}