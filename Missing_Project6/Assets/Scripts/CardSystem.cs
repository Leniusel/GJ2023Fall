    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class CardSystem : MonoBehaviour
{   
    public List<CardInfo> mydeck = new List<CardInfo>(); //deck is one list
    public List<CardInfo> discardPile = new List<CardInfo>(); //discard pile is another
    //public List<CardInfo> playzone = new List<CardInfo>(); //not being used, currently getting the list from dropzone.cs

    //I can't use this as the lists do not convert types...
    public dropzone droplist; 

    public Transform[] cardSlots; //we transform stuff to cardslots aka hand
    public bool[] availableCardSlots; //is card slot free, yes or no, need a cap of say 5 cards

    public Text deckSizetext; //text ui
    public Text discardtext;

    public player damage;
    public int handIndex;

    private void Start() //initialise values
    { 
        deckSizetext.text = mydeck.Count.ToString();
        discardtext.text = discardPile.Count.ToString();
        //gm = FindObjectOfType<CardSystem>();
    }

    public void DrawCard()
    {
        if(mydeck.Count >= 1)
        {
            //CardFetch randCard = mydeck[Random.Range(0, mydeck.Count)]; //randomise
            CardInfo randCard = mydeck[Random.Range(0, mydeck.Count)]; //randomise


            for (int i = 0; i < availableCardSlots.Length; i++) //place card from deck to hand slot
            {
                if (availableCardSlots[i] == true)
                {
                    randCard.gameObject.SetActive(true);
                    randCard.handIndex = i;
                    randCard.transform.position = cardSlots[i].position;
                    //randCard.hasBeenPlayed = false;
                    availableCardSlots[i] = false;
                    mydeck.Remove(randCard);
                    deckSizetext.text = mydeck.Count.ToString();
                    return;
                }
            }
        }
    }

    public void Shuffle() //adds cards back to deck
    {
        if (discardPile.Count >= 1)
        {
            foreach(CardInfo CardInfo in discardPile)
                //foreach (CardInfo CardInfo in discardPile)

                {
                    mydeck.Add(CardInfo);
                deckSizetext.text = mydeck.Count.ToString();
            }
            discardPile.Clear();
            discardtext.text = discardPile.Count.ToString();
        }
    }


    public void EndTurn() //for each card in the drop list specified in dropzone.cs, do damage then clear the list
        //instead, we would like the drop list to be converted to the discard pile...
        //OR, we create the list in this script by checking children of drop zone parent...
        //then all the game objects in drop zone are hidden again, to be later shuffled and readded...
        {
        foreach(dropzone dropzone in droplist.droparea)        
        {
            //take the child object, find cardinfo component, refer to power????
            damage.TakeDamage(1); //or card power)
            //need to somehow add to discard pile and to scale damage based on the card itself, as well as remove the card from the dropzone
        }
        droplist.droparea.Clear();
        }
}
