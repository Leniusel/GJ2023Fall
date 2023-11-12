using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
[System.Serializable]

//in tutorial this is Card
public class CardFetch
{
    public int id;
    public string cardName;
    public int cost;
    public int power;
    public string cardDescription;
    public string cardType;
    public Sprite thisImage;

    //public int handIndex; ????

    public CardFetch()
    {

    }

    public CardFetch(int Id, string CardName, int Cost, int Power, string CardDescription, string CardType, Sprite ThisImage)
    {
        id = Id;
        cardName = CardName;
        cost = Cost;
        power = Power;
        cardDescription = CardDescription;
        cardType = CardType;
        thisImage = ThisImage;
    }

}
