using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject obstaclePrefab;
    [SerializeField] private FloatVariable generationRate;

    public float minHeight, maxHeight;


    private void OnEnable()
    {
        InvokeRepeating(nameof(Generate), generationRate.value, generationRate.value);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Generate));
    }

    private void Generate()     //Instantiate a new 'Pipe' prefab and give it a random height
    {
        GameObject newObstacle = Instantiate(obstaclePrefab, new Vector2(obstaclePrefab.transform.position.x,
                obstaclePrefab.transform.position.y + Random.Range(minHeight, maxHeight)), obstaclePrefab.transform.rotation);

        Destroy(newObstacle, 5f);
    }

    public void ClearObstacles()        //Destroys all 'Pipes' currently in game
    {
        Obstacle[] obstacles = FindObjectsOfType<Obstacle>();
        for (int i = 0; i < obstacles.Length; i++)
        {
            Destroy(obstacles[i].gameObject);
        }
    }
}