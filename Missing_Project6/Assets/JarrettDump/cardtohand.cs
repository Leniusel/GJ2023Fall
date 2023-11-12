using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardtohand : MonoBehaviour
{
    //Essentially defines the card and the hand and brings the card to the hand.
    public GameObject Hand;
    public GameObject It;

    void Update()
    {
        Hand = GameObject.Find("Hand");
        It.transform.SetParent(Hand.transform);
        It.transform.localScale = Vector3.one;
        It.transform.position = new Vector3(transform.position.x, transform.position.y, -48);
        It.transform.eulerAngles = new Vector3(25, 0, 0);
    }
}
