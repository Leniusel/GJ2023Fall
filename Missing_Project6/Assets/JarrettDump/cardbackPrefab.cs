using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardbackPrefab : MonoBehaviour
{
   //I don't know what this is actually for. I think we can ignore as we are not doing cardback yet.
    public GameObject Deck;
    public GameObject It;

  
    void Update()
    {
        Deck = GameObject.Find("Deck");
        It.transform.SetParent(Deck.transform);
        It.transform.localScale = Vector3.one;
        It.transform.position = new Vector3(transform.position.x, transform.position.y, -48);
        It.transform.eulerAngles = new Vector3(25, 0, 0);
    }
}
