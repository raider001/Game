namespace LazyProductions.GridManager
{
    public class Point
    {
        /// <summary>
        /// Type of the point, which is defined by configuration
        /// </summary>
        public PointType Type
        {
            get;
            private set;
        }

        /// <summary>
        /// Total weight of the point, which can be modified at runtime.
        /// </summary>
        public float Weight
        {
            get;
            private set;
        }

        public Point(PointType type, float weight)
        {
            Type = type;
            Weight = weight;
        }

        /// <summary>
        /// Allows for adjustment of the weight, negative values allowed.
        /// </summary>
        /// <param name="weightAdjustment"></param>
        public void AdjustWeight(float weightAdjustment)
        {
            Weight += weightAdjustment;
            Weight = Weight > 1 ? 1 : Weight < 0 ? 0 : Weight;
        }
    }
}