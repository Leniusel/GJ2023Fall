using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

//in tutorial this is thisCard

public class CardInfo : MonoBehaviour
{
    //all the variables of a card
    public List<CardFetch> thisCard = new List<CardFetch>();
    public int thisId;

    //card parameters
    public int id;
    public string cardName;
    public int power;
    public int cost;
    public string cardDescription;
    public string cardType;

    //card UI
    public Text nameText;
    public Text costText;
    public Text descriptionText;
    public Text typeText;
    public Sprite thisSprite;
    public Image thatImage;

    //cardtohand
    public GameObject Hand;

    public int numberOfCardsInDeck;

    private void Start()
    {
        thisCard[0] = CardDatabase.cardList[thisId];
        numberOfCardsInDeck = deckscript.deckSize;
    }

    private void Update() //initialise card ui and deck
    {
        Hand = GameObject.Find("Hand");

      
        id = thisCard[0].id;
        cardName = thisCard[0].cardName;
        power = thisCard[0].power;
        cost = thisCard[0].cost;
        cardDescription = thisCard[0].cardDescription;
        cardType = thisCard[0].cardType;

        nameText.text = "" + cardName;
        costText.text = "Cost: " + cost;
        descriptionText.text = "Does " + power + " damage. I am " + cardDescription;
        typeText.text = "" + cardType;
        thisSprite = thisCard[0].thisImage;
        thatImage.sprite = thisSprite;

    }

    public int handIndex;
}
