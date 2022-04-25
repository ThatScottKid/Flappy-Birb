using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject obstaclePrefab;
    [SerializeField] private float generationRate;

    public float minHeight, maxHeight;


    private void OnEnable()
    {
        InvokeRepeating(nameof(Generate), generationRate, generationRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Generate));
    }

    private void Generate()
    {
        GameObject newObstacle = Instantiate(obstaclePrefab, new Vector2(obstaclePrefab.transform.position.x,
                obstaclePrefab.transform.position.y + Random.Range(minHeight, maxHeight)), obstaclePrefab.transform.rotation);

        Destroy(newObstacle, 6f);
    }

    public void ClearObstacles()
    {
        Obstacle[] obstacles = FindObjectsOfType<Obstacle>();
        for (int i = 0; i < obstacles.Length; i++)
        {
            Destroy(obstacles[i].gameObject);
        }
    }
}