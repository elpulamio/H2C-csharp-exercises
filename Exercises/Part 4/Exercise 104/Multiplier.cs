namespace exercise_104
{
    public class Multiplier
    {
        public int number { set; get; }

        public Multiplier(int number)
        {
            this.number = number;
        }

        public int Multiply(int number)
        {
            return this.number = this.number * number;
        }
    }

}