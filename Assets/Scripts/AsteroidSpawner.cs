
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    [SerializeField] private SimplePool asteroidPool;
    [SerializeField] private float spawnInterval = 1.5f;
    [SerializeField] private float spawnY = 4.2f;
    [SerializeField] private float spawnRangeX = 7f;

    private float timer;

    private void Update()
    {
        if (GameManager.Instance.IsGameOver)
            return;

        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            timer = 0f;
            SpawnAsteroid();
        }
    }

    private void SpawnAsteroid()
    {
        float randomX =
            Random.Range(-spawnRangeX, spawnRangeX);

        Vector3 spawnPosition =
            new Vector3(randomX, spawnY, 0f);

        asteroidPool.GetFromPool(spawnPosition);
    }
}
