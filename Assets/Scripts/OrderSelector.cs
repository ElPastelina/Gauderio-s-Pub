using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderSelector : MonoBehaviour
{
    public Sprite[] OrderSprites;
    public string[] tagList;

    private int randomIndex;

    
    // Start is called before the first frame update
    void Start()
    {
        randomIndex = Random.Range(0, 11);
        SpriteRenderer sp = GetComponent<SpriteRenderer>();
        sp.sprite = OrderSprites[randomIndex];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (randomIndex <= 4)
        {
            if (other.CompareTag(tagList[randomIndex]))
            {
                Debug.Log("Order complete");
                other.tag = "glass_empty";
                Destroy(this.gameObject);
            }
            else
            {
                Debug.Log("Wrong object");
            }
        }
        else
        {
            if (other.CompareTag(tagList[randomIndex]))
            {
                Debug.Log("Order complete");
                Destroy(other.gameObject);
                Destroy(this.gameObject);
                
            }
        }
    }
}
