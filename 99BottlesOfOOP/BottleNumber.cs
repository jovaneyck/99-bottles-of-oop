namespace _99BottlesOfOOP
{
    public class BottleNumber
    {
        private readonly int _number;

        public BottleNumber(int number)
        {
            _number = number;
        }

        public string Container()
        {
            if (_number == 1)
            {
                return "bottle";
            }

            return "bottles";
        }

        public string Pronoun()
        {
            if (_number == 1)
            {
                return "it";
            }
            return "one";
        }

        public string Quantity()
        {
            if (_number == 0)
            {
                return "no more";
            }
            return _number.ToString();
        }

        public string Action()
        {
            if (_number == 0)
            {
                return "Go to the store and buy some more";
            }
            return $"Take {Pronoun()} down and pass it around";
        }

        public int Successor()
        {
            if (_number == 0)
            {
                return 99;
            }

            return _number - 1;
        }
    }
}