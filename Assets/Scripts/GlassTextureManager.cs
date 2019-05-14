using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassTextureManager : MonoBehaviour
{
    private GameObject[] obj;
    public string[] tags;
    public Sprite[] sprites;


    void Update() // every frame
    {
        for (int i = 0; i < tags.Length; ++i)
        {
            obj = GameObject.FindGameObjectsWithTag(tags[i]);
            if (obj != null)
            {
                for (int x = 0; x < obj.Length; ++x)
                {
                    SpriteRenderer targetSpriteRd = obj[x].GetComponent<SpriteRenderer>();
                    targetSpriteRd.sprite = sprites[i];
                }
            }
        }
    }
}