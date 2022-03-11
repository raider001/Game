namespace LazyProductions.GridManager
{
    public class Point
    {
        /// <summary>
        /// Type of the point, which is defined by configuration
        /// </summary>
        public int Type
        {
            get;
            private set;
        }

        /// <summary>
        /// Total weight of the point, which can be modified at runtime.
        /// </summary>
        public double Weight
        {
            get;
            private set;
        }

        public Point(int type, double weight)
        {
            Type = type;
            Weight = weight;
        }

        /// <summary>
        /// Allows for adjustment of the weight, negative values allowed.
        /// </summary>
        /// <param name="weightAdjustment"></param>
        public void AdjustWeight(double weightAdjustment)
        {
            Weight += weightAdjustment;
            Weight = Weight > 1 ? 1 : Weight < 0 ? 0 : Weight;
        }
    }
}