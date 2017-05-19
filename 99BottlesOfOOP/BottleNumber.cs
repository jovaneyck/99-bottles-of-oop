namespace _99BottlesOfOOP
{
    public class BottleNumber
    {
        protected readonly int Number;

        public BottleNumber(int number)
        {
            Number = number;
        }

        public static BottleNumber For(int number)
        {
            switch (number)
            {
                case 0:
                    return new BottleNumber0(number);
                case 1:
                    return new BottleNumber1(number);
                default:
                    return new BottleNumber(number);
            }
        }


        public virtual string Container()
        {
            return "bottles";
        }

        public virtual string Pronoun()
        {
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

        public virtual BottleNumber Successor()
        {
            return For(Number - 1);
        }

        public override string ToString()
        {
            return $"{Quantity()} {Container()}";
        }
    }
}