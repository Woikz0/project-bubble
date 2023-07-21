using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloonSpawner : MonoBehaviour
{
    public float min, max;
    public GameObject[] Balloons;
    public float maxTime;
    float currentTime = 0;
    public int balloonCount;
    public static balloonSpawner instance;
    public int speed;


    public GameObject star;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        balloonCount = 0;
    }

    private void Star()
    {
    
        switch (balloonCount)
        {
            case 3:
                randomSpawn(star);
                break;
        }
    }
    void randomSpawn(GameObject spawnObject)
    {
        currentTime = 0;
        GameObject newballon = Instantiate(spawnObject,
            new Vector3(Random.Range(min, max), this.transform.position.y, 0), Quaternion.identity);
        Destroy(newballon, 8f);
    }



    void Update()
    {

      

        currentTime += Time.deltaTime;
        if (currentTime >= maxTime)
        {
            currentTime = 0;
            randomSpawn(Balloons[Random.Range(0, Balloons.Length)]);
        }
    
    }

    public void BallonArttir()
    {
        
       balloonCount++;
        Star();
    }
    
    
    }



