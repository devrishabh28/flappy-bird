using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{

    [SerializeField] private GameObject pipe;
    [SerializeField] private float spawnRateRange = 4;
    private float spawnRate;
    private float timer = 0;
    [SerializeField] private float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
        spawnRate = Random.Range(2, spawnRateRange);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
            spawnRate = Random.Range(2, spawnRateRange);
        }
    }

    private void spawnPipe()
    {

        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
