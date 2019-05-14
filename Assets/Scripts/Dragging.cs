using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragging : MonoBehaviour
{
    private bool selected;
    private bool rotated;


    private Rigidbody2D rb;
    private BoxCollider2D col;
    private GameObject obj;

    public float ajustPosition = 0f;
    public float rotationValue;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        if (selected == true)
        {
            col.enabled = false;
            rb.Sleep();
            Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(cursorPos.x + ajustPosition, cursorPos.y + ajustPosition);
            if (Input.GetMouseButtonDown(0))
            {
                gameObject.transform.Rotate(0, 0, rotationValue);
            }
            if (Input.GetMouseButtonUp(0))
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }
        
        if (Input.GetMouseButtonUp(1))
        {
            selected = false;
            rb.WakeUp();
            col.enabled = true;
        }
    }

    private void OnMouseOver() //Works with the update function frequency.
    {
        if (Input.GetMouseButtonDown(1))
            selected = true; 
    }
}