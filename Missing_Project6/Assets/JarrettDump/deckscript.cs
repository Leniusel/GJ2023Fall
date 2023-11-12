using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//in tutorial this is PlayerDeck
//ultimately this will replace CardSystem and cause a lot of headache
public class deckscript : MonoBehaviour
{
    public List<CardFetch> mydeck = new List<CardFetch>();
    public List<CardFetch> container = new List<CardFetch>();
    public static List<CardFetch> staticDeck = new List<CardFetch>();

    public int x;
    public static int deckSize;

    public Text deckSizetext; //text ui
    public Text discardtext;

    public GameObject CardToHand; //for cardtohand script

    public GameObject Deck; //to define deck
    public GameObject Hand; //to define hand

    public GameObject[] Clones; //??? need to understand the clones more, I guess it copies game objects for you

    void Start()
    {
        x = 0;
        deckSize = 10;
        for(int i=0;i<deckSize; i++)
        {
            x = Random.Range(1, 6); //create deck of random cards
            mydeck[i] = CardDatabase.cardList[x];
        }

        deckSizetext.text = mydeck.Count.ToString();

        StartCoroutine(StartGame());

    }

    void Update()
    {
        staticDeck = mydeck;
    }

    IEnumerator Example()
    {
        yield return new WaitForSeconds(1);
        Clones = GameObject.FindGameObjectsWithTag("Clone");
    }
    IEnumerator StartGame()
    {
        for (int i = 0; i <= 4; i++)
        {
            yield return new WaitForSeconds(1);
            Instantiate(CardToHand, transform.position, transform.rotation);
        }
    }

    public void Shuffle() //need to assign to shuffle button to test
    {
        for(int i=0; i< deckSize; i++)
        {
            container[0] = mydeck[i];
            int randomIndex = Random.Range(i, deckSize);
            mydeck[i] = mydeck[randomIndex];
            mydeck[randomIndex] = container[0];
        }
    }
   
}
