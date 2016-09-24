namespace _99BottlesOfOOP
{
    public class Bottles
    {
        public string Verse(int number)
        {
            if (number == 1)
                return @"1 bottle of beer on the wall, 1 bottle of beer.
Take it down and pass it around, no more bottles of beer on the wall.";

            if (number == 2)
                return @"2 bottles of beer on the wall, 2 bottles of beer.
Take one down and pass it around, 1 bottle of beer on the wall.";

            return $@"{number} bottles of beer on the wall, {number} bottles of beer.
Take one down and pass it around, {number - 1} bottles of beer on the wall.";
        }

        public string Verses(int first, int last)
        {
            throw new System.NotImplementedException();
        }

        public string Song()
        {
            throw new System.NotImplementedException();
        }
    }
}