using UnityEngine;

public class SpawnTrees : MonoBehaviour
{
    public GameObject treePrefab; // Trường này dùng để kéo Prefab cây vào từ Inspector
    public int numberOfTrees = 50; // Số lượng cây bạn muốn tạo

    void Start()
    {
        for (int i = 0; i < numberOfTrees; i++)
        {
            // Tạo ra một bản sao của cây Prefab và đặt vị trí của nó
            Vector3 spawnPosition = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)); // Đặt vị trí theo ý muốn
            Instantiate(treePrefab, spawnPosition, Quaternion.identity);
        }
    }
}
