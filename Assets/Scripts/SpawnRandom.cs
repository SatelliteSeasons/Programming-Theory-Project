using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandom : MonoBehaviour
{

    [SerializeField] MainManager mainManager;
    public List<Asteroid> asteroids;

    private float maxY = 13f;
    private float startTime = 1f;
    private float repeatTime = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        mainManager = GameObject.Find("MainManager").GetComponent<MainManager>();
        InvokeRepeating("SpawnRandomAsteroid", startTime, repeatTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (!mainManager.GetIsGameOn())
        {
            Debug.Log("GameOver!");
        }
    }

    private void SpawnRandomAsteroid()
    {
        int randomIndex = Random.Range(0, 3);
        float randomX = Random.Range(-9.5f, 9.5f);
        Instantiate(asteroids[randomIndex], new Vector3(randomX, maxY, 0), asteroids[randomIndex].transform.rotation);
    }
}
