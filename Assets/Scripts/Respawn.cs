using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    private Vector2 initialPosition;

    void Start()
    {
        initialPosition = this.transform.position;
    }

    void Update()
    {
        if (this.transform.position.y < -2.4f)
        {
            this.gameObject.transform.position = new Vector2 (initialPosition.x, initialPosition.y);
            this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
