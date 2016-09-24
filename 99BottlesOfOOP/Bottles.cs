namespace _99BottlesOfOOP
{
    public class Bottles
    {
        public string Verse(int number)
        {   
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