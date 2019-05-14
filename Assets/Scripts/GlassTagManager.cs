using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassTagManager : MonoBehaviour
{
    public string[] bottleTagList;
    public string[] glassTagList;


    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ChangeTag();
        }
    }

    private void ChangeTag()
    {
        for (int i = 0; i < bottleTagList.Length; ++i)
        {
            if (GameObject.FindGameObjectWithTag(bottleTagList[i]) != null)
            {
                this.gameObject.tag = glassTagList[i];
            }
        }
    }
}
