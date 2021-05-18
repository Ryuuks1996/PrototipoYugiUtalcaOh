using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckController : MonoBehaviour
{
    public  static List<Card> playerDeck = new List<Card>();  
    //private int sizeDeck =30;


    void Start()
    {

        /*for (int i = 0; i < sizeDeck; i++)
        {
            var auxCard = new Card();
            playerDeck.Add(auxCard);
        }*/
    }

  
    void Update()
    {
        if (playerDeck[0] != null)
          Debug.Log(playerDeck[0].nameCard);     
    }

    //cambiar luego
   public Card GetCard()
    {
        return playerDeck[0];
    }

    public void Shuffler () // para mezclar
    {

    }
}
