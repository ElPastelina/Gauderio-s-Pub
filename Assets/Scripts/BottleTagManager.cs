using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleTagManager : MonoBehaviour
{
    private bool isSelected = false;
    private string bottleIndex;

    private void Start()
    {
        bottleIndex = this.gameObject.name;
    }
    private void Update()
    {
        if (isSelected == true)
        {
            this.gameObject.tag = bottleIndex; // Atribui a tag do objecto de acordo com seu nome.
        }
        else
        {
            this.gameObject.tag = "Untagged"; // Remove a tag se o objecto nao estiver selecionado.
        }
        if (Input.GetMouseButtonUp(1)) // Desseleciona o objeto ao soltar o botao do mouse.
        {
            isSelected = false;
        }
    }
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            isSelected = true;
        }
    }
}
