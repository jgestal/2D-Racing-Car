using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] cars;
    [SerializeField] GameObject[] spawnPoints;
    [SerializeField] float minDelaytimer = 0.5f;
    [SerializeField] float maxDelayTimer = 2f;
    float timer;

    private void Start()
    {
        timer = Random.Range(minDelaytimer,maxDelayTimer);
    }
    
    private void SpawnCars() {

        switch (Random.Range(0,3)) {

            case 0: 
                Instantiate(RandomCar(), RandomSpawnPosition(Random.Range(0, spawnPoints.Length - 1)), transform.rotation);
            break;

            case 1:
                Instantiate(RandomCar(), RandomSpawnPosition(Random.Range(0,3)), transform.rotation);
                Instantiate(RandomCar(), RandomSpawnPosition(Random.Range(3,5)), transform.rotation);
            break;

            default:
                Instantiate(RandomCar(), RandomSpawnPosition(Random.Range(0,2)), transform.rotation);
                Instantiate(RandomCar(), RandomSpawnPosition(Random.Range(2,4)), transform.rotation);
                Instantiate(RandomCar(), RandomSpawnPosition(Random.Range(4,5)), transform.rotation);           
            break;
        }
    }   
    private void Update()
    {
        if (IsTimeToSpawn())
        {
            SpawnCars();
        }
    }
    private bool IsTimeToSpawn() {

        timer -= Time.deltaTime;

        if (timer < 0) {
            timer = Random.Range(minDelaytimer,maxDelayTimer);
            return true;
        }
        return false;
    }
    private GameObject RandomCar() {
        return cars[Random.Range(0, cars.Length - 1)];
    }
    private Vector3 RandomSpawnPosition(int position) {
        float x = spawnPoints[position].transform.position.x;
        return new Vector3(x, transform.position.y, transform.position.z);
    }
}
