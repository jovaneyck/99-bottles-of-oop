namespace _99BottlesOfOOP
{
    public class BottleNumber
    {
        private readonly int number;

        public BottleNumber(int number)
        {
            this.number = number;
        }

        public string Container(int delete_me = -1)
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