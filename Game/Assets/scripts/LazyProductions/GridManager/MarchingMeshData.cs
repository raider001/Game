using UnityEngine;

namespace LazyProductions.GridManager
{
    public class MarchingMeshData
    {
        public Vector3[] Vertices
        {
            get;
            private set;
        }
        
        public int[] Triangles
        {
            get;
            private set;
        }

        public Vector3[] Normals
        {
            get;
            private set;
        }

        public Vector3[] Uvs
        {
            get;
            private set;
        }
        
        public MarchingMeshData(Vector3[] vertices, int[] triangles, Vector3[] normals, Vector3[] uvs)
        {
            Vertices = vertices;
            Triangles = triangles;
            Normals = normals;
            Uvs = uvs;
        }
    }
}