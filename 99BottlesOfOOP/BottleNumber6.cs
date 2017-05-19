namespace _99BottlesOfOOP
{
    public class BottleNumber6 : BottleNumber
    {
        public BottleNumber6(int number) : base(number)
        {
        }

        public override string Quantity()
        {
            return "1";
        }

        public override string Container()
        {
            return "six-pack";
        }
    }
}