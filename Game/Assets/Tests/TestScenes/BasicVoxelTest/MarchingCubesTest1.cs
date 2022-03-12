using LazyProductions.GridManager;
using UnityEngine;
using Grid = LazyProductions.GridManager.Grid;

namespace Tests.TestScenes
{
    public class MarchingCubesTest1 : MonoBehaviour
    {
        // Start is called before the first frame update
        public void Start()
        {
            MeshRenderer meshRenderer = gameObject.AddComponent<MeshRenderer>();
            Material material = new Material(Shader.Find("Standard"));
            meshRenderer.sharedMaterial = material;
            MeshFilter meshFilter = gameObject.AddComponent<MeshFilter>();
            Mesh mesh = new Mesh();

            Grid grid = new Grid(5, new Vector3(0,0,0));

            for (int x = 0; x < grid.Size; x++)
            {
                for (int y = 0; y < grid.Size; y++)
                {
                    for (int z = 0; z < grid.Size; z++)
                    {
                        grid.Point[x, y, z] = new Point(PointType.VOID, 1);
                    }
                }
            }
            
            grid.Point[1, 2, 1] = new Point(PointType.SOLID, 1);
            
            MarchingMeshData data = MarchingCubesMeshBuilder.Generate(grid);

            mesh.vertices = data.Vertices;
            mesh.triangles = data.Triangles;
            mesh.RecalculateNormals();
            meshFilter.mesh = mesh;
        }

        // Update is called once per frame
        public void Update()
        {
        
        }
    }
}
