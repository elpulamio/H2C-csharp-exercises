namespace exercise_120
{
    public class Cube
    {
        public int edgeLength { get; set; }

        public Cube(int edgeLength)
        {
            this.edgeLength = edgeLength;
        }

        public int Volume()
        {
            return edgeLength * edgeLength * edgeLength;
        }

        public override string ToString()
        {
            return "The length of the edge is " + edgeLength + " and the volume " + Volume();
        }
    }
}