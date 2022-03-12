using LazyProductions.GridManager;
using UnityEngine;
using Grid = LazyProductions.GridManager.Grid;
using Random = System.Random;

namespace Tests.TestScenes.BasicVoxelTest
{
    public class MarchingCubesTestRandom : MonoBehaviour
    {
        // Start is called before the first frame update
        public void Start()
        {
            MeshRenderer meshRenderer = gameObject.AddComponent<MeshRenderer>();
            Material material = new Material(Shader.Find("Standard"));
            meshRenderer.sharedMaterial = material;
            MeshFilter meshFilter = gameObject.AddComponent<MeshFilter>();
            Mesh mesh = new Mesh();

            Grid grid = new Grid(10, new Vector3(0,0,0));
            
            // pre-set
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
            
            
            Random random = new Random();
            for (int x = 1; x < grid.Size -1; x++)
            {
                for (int y = 1; y < grid.Size - 1; y++)
                {
                    for (int z = 1; z < grid.Size - 1; z++)
                    {
                        int num = random.Next(2);
                            Debug.Log(num);
                        grid.Point[x, y, z] = new Point(num == 0 ? PointType.SOLID : PointType.VOID, 1);
                    }
                }
            }

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
