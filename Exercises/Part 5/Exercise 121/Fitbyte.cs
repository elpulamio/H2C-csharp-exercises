namespace exercise_121
{
    public class Fitbyte
    {
        public int age { get; set; }
        public int restingHeartRate { get; set; }

        public Fitbyte(int age, int restingHeartRate)
        {
            this.age = age;
            this.restingHeartRate = restingHeartRate;
        }

        public double TargetHeartRate(double percentageOfMaximum)
        {
            double maxHeartRate = 206.3 - (0.711 * this.age);
            double calculation = (maxHeartRate - this.restingHeartRate) * percentageOfMaximum + this.restingHeartRate;
            return calculation;
        }
    }
}