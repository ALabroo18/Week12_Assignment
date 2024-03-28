using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using Random = UnityEngine.Random;

public class Task3 : MonoBehaviour
{
    // Stack that stores the cards that are in the deck.
    private Stack<string> deck = new Stack<string>();

    // Stack that stores the cards that are in the players hands.
    private Stack<string> hand = new Stack<string>();

    void Start()
    {
        CreateDeck();
    }

    void CreateDeck()
    {
        // Add King of each suit.
        deck.Push("K♠");
        deck.Push("K♣");
        deck.Push("K♥");
        deck.Push("K♦");
        
        // Add Queen of each suit.
        deck.Push("Q♠");
        deck.Push("Q♣");
        deck.Push("Q♥");
        deck.Push("Q♦");

        // Add Jack of each suit.
        deck.Push("J♠");
        deck.Push("J♣");
        deck.Push("J♥");
        deck.Push("J♦");

        // Add Ace of each suit.
        deck.Push("A♠");
        deck.Push("A♣");
        deck.Push("A♥");
        deck.Push("A♦");

        
        // Planning to randomize when creating the deck rather than after it's created.
        // Randomize/shuffle the deck.
        deck.OrderBy(x => Random.value);

        foreach (string card in deck)
        {
            Debug.Log(card);
        }
    }

    // Function that checks if the player has three cards from the same suit. If they do, they win.
    void VictoryCheck()
    {

    }
}
