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
            return Number.ToString();
        }

        public virtual string Action()
        {
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