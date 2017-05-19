namespace _99BottlesOfOOP
{
    public class BottleNumber0 : BottleNumber
    {
        public BottleNumber0(int number) : base(number)
        {
        }

        public override string Quantity()
        {
            return "no more";
        }

        public override string Action()
        {
            return "Go to the store and buy some more";
        }

        public override BottleNumber Successor()
        {
            return For(99);
        }
    }
}