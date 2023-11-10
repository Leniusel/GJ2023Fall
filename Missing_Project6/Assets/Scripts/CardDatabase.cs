using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<CardFetch> cardList = new List<CardFetch>();

    void Awake()
    {
        //Card index, name, cost, power, description, type
        cardList.Add(new CardFetch(0, "Poke", 0, 3, "stronk.", "Human"));
        cardList.Add(new CardFetch(1, "Punch", 1, 1, "super stronk.", "Human"));
        cardList.Add(new CardFetch(2, "Kick", 2, 2, "super duper stronk.", "Human"));
        cardList.Add(new CardFetch(3, "Bless", 3, 1, "a holy man.", "Light"));
        cardList.Add(new CardFetch(4, "Smite", 4, 3, "bringing godly justice.", "Light"));
        cardList.Add(new CardFetch(5, "Red Head", 5, 1, "kinda evil now.", "Dark"));
        cardList.Add(new CardFetch(6, "Holy Hat", 6, 2, "the Creator.", "Light"));

    }
}