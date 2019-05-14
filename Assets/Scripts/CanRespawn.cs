using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanRespawn : MonoBehaviour
{
    public GameObject[] prefabs;
    public string[] tagList;

    public float[] spawnPositionX;
    public float[] spawnPositionY;

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < tagList.Length; ++i) // Check all the can tags.
        {
            if (GameObject.FindGameObjectWithTag(tagList[i]) == null)
            {
                Instantiate(prefabs[i], new Vector2(spawnPositionX[i], spawnPositionY[i]), Quaternion.identity); // Instantiate prefab at the prgirinal position.
            }
        }
    }
}
