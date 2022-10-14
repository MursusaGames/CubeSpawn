using UnityEngine;

public class SpawnSystem : MonoBehaviour
{
    [SerializeField] private Cube cubePrefab;
    [SerializeField] private Transform spawnPoint;    

    public void SpawnCube(int speed, int distance)
    {
        var cube = Instantiate(cubePrefab, spawnPoint.position, Quaternion.identity);
        cube.transform.position = spawnPoint.position;  
        cube.speed = speed; 
        cube.distance = distance;
        cube.Move();
    }
}
