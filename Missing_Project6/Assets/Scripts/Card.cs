using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Card : MonoBehaviour
{

    public GameObject thisCard;

    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Clicked");
            Destroy(gameObject);
           
            // Play functions to be added later
        }
    }
}
