using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidManager : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public float speedSpawn;

    private void Start()
    {
        StartCoroutine(SpawnAsteroid());
    }
    // Update is called once per frame


    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    IEnumerator SpawnAsteroid()
    {
        while (true)
        {
            GameObject ast = Instantiate(asteroidPrefab);
            ast.transform.position = new Vector2(Random.Range(-10, 10), 6);
            


            yield return new WaitForSeconds(speedSpawn);
        }
        
    }
}
