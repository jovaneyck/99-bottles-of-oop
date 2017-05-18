namespace _99BottlesOfOOP
{
    public class BottleNumber1 : BottleNumber
    {
        public BottleNumber1(int number) : base(number)
        {
        }

        public override string Container()
        {
            return "bottle";
        }

        public override string Pronoun()
        {
            return "it";
         }
    }
}