using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FridgeDoorOperator : MonoBehaviour
{
    public GameObject fridgeDoorOpenned;
    public GameObject FridgeDoorClosed;
    private bool isOpen;

    private void Awake()
    {
        isOpen = false;
        fridgeDoorOpenned.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isOpen == true)
            {
                fridgeDoorOpenned.SetActive(false);
                FridgeDoorClosed.SetActive(true);
                isOpen = false;
            }
            else
            {
                fridgeDoorOpenned.SetActive(true);
                FridgeDoorClosed.SetActive(false);
                isOpen = true;
            }
        }
    }
}
