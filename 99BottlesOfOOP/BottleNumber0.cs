namespace _99BottlesOfOOP
{
    public class BottleNumber0 : BottleNumber
    {
        public BottleNumber0(int number) : base(number)
        {
        }

        public override string Quantity()
        {
            if (Number == 0)
            {
                return "no more";
            }
            return Number.ToString();
        }
    }
}