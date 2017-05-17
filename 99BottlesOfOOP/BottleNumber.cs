namespace _99BottlesOfOOP
{
    public class BottleNumber
    {
        protected readonly int Number;

        public BottleNumber(int number)
        {
            Number = number;
        }

        public string Container()
        {
            if (Number == 1)
            {
                return "bottle";
            }

            return "bottles";
        }

        public string Pronoun()
        {
            if (Number == 1)
            {
                return "it";
            }
            return "one";
        }

        public virtual string Quantity()
        {
            if (Number == 0)
            {
                return "no more";
            }
            return Number.ToString();
        }

        public string Action()
        {
            if (Number == 0)
            {
                return "Go to the store and buy some more";
            }
            return $"Take {Pronoun()} down and pass it around";
        }

        public int Successor()
        {
            if (Number == 0)
            {
                return 99;
            }

            return Number - 1;
        }

        public override string ToString()
        {
            return $"{Quantity()} {Container()}";
        }
    }
}