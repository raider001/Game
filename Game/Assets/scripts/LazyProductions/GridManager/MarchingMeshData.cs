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
        
        public MarchingMeshData(Vector3[] vertices, Vector3[] normals, Vector3[] uvs)
        {
            Vertices = vertices;
            Normals = normals;
            Uvs = uvs;
        }
    }
}