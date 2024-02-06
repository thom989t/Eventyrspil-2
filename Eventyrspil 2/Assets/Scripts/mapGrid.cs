using UnityEngine;

public class mapGrid : MonoBehaviour
{
    [SerializeField] private Camera cam;

    [SerializeField] private int gridWidth;
    [SerializeField] private int gridHeight;
    [SerializeField] private float gridCellSize;
    [SerializeField] private float cellOffset;
    [SerializeField] private float leftOffset;

    [SerializeField] private GameObject cellPrefab;

    private void Start()
    {
        float orthSize = cam.orthographicSize;

        float left = (orthSize / (Screen.height / 2)) * (Screen.width / 2);

        for(int i = 0; i < gridWidth; i++)
        {
            for (int j = 0; j < gridHeight; j++)
            {
                Vector3 pos = new Vector3(i * gridCellSize, j * gridCellSize, 0);
                pos.x -= left - cellOffset - leftOffset;
                pos.y -= orthSize - cellOffset;
                Instantiate(cellPrefab, pos, Quaternion.identity);
            }
        }
    }
}
