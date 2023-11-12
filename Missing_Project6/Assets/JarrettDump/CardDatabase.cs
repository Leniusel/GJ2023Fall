using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<CardFetch> cardList = new List<CardFetch>();

    void Awake()
    {
        //Card index, name, cost, power, description, type, image
        cardList.Add(new CardFetch(0, "Poke", 1, 1, "stronk.", "Human", Resources.Load<Sprite>("Poke")));
        cardList.Add(new CardFetch(1, "Punch", 2, 2, "super stronk.", "Human", Resources.Load<Sprite>("Punch")));
        cardList.Add(new CardFetch(2, "Kick", 3, 3, "super duper stronk.", "Human", Resources.Load<Sprite>("Kick")));
        cardList.Add(new CardFetch(3, "Bless", 1, 1, "a holy man.", "Light", Resources.Load<Sprite>("Bless")));
        cardList.Add(new CardFetch(4, "Smite", 3, 3, "bringing godly justice.", "Light", Resources.Load<Sprite>("Smite")));
        cardList.Add(new CardFetch(5, "Red Head", 2, 2, "kinda evil now.", "Dark", Resources.Load<Sprite>("RedHead")));
        cardList.Add(new CardFetch(6, "Wok It", 3, 3, "the best at stir fry.", "Human", Resources.Load<Sprite>("WokIt")));
        cardList.Add(new CardFetch(7, "Wing It", 2, 2, "ascending.", "Light", Resources.Load<Sprite>("WingIt")));
        cardList.Add(new CardFetch(8, "Look at my Scarf", 3, 3, "amazing.", "Human", Resources.Load<Sprite>("LookMyScarf")));
        cardList.Add(new CardFetch(9, "Guitar Hero", 10, 10, "one with music.", "Human", Resources.Load<Sprite>("GuitarHero")));
        cardList.Add(new CardFetch(10, "Trick", 5, 5, "a sneaky boi.", "Dark", Resources.Load<Sprite>("Trick")));
        cardList.Add(new CardFetch(11, "Burn", 6, 6, "on fire!", "Dark", Resources.Load<Sprite>("Burn")));
    }
}