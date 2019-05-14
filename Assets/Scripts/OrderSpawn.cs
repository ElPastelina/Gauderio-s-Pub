using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderSpawn : MonoBehaviour
{
    public Vector2 orderSpawnPosition;
    public GameObject orderPrefab;
    public string positionTag;
    public float spawnTimeRangeMin;
    public float spawnTimeRangeMax;

    private float elapsedTime = 0;
    public float spawnTime;

    public void Update()
    {

        spawnTime = Random.Range(spawnTimeRangeMin, spawnTimeRangeMax);
        orderPrefab.gameObject.tag = positionTag;
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= spawnTime && GameObject.FindGameObjectWithTag(positionTag) == null)
        {
            Instantiate(orderPrefab, new Vector2(orderSpawnPosition.x, orderSpawnPosition.y), Quaternion.Euler(0, 0, 0));
        }
        if (GameObject.FindGameObjectWithTag(positionTag) != null)
        {
            elapsedTime = 0;
        }
        Debug.Log(elapsedTime);
    }
}
