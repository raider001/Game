using UnityEngine;

namespace LazyProductions.GridManager
{
    public class Grid
    {
        public int Size
        {
            get;
            private set;
        }

        public Point[,,] Point
        {
            get;
            private set;
        }

        public Vector3 GridLocation
        {
            get;
            private set;
        }

        public Grid(int size, Vector3 gridLocation)
        {
            Size = size;
            Point = new Point[size,size,size];
            GridLocation = gridLocation;
        }
    }
}