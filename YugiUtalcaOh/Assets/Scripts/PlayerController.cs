using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public string playerName;
    public int lifepoint;
    DeckController deck;

    List<Card> playerHand;
    int playerHand_cant;


    // Start is called before the first frame update
    void Start()
    {
        StartHand();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartHand()
    {
        playerHand = new List<Card>();

        for (int i=0 ; i < playerHand_cant; i++)
        {
            playerHand.Add(deck.GetCard());
        }

    }

    public void DrawCard()
    {
        playerHand.Add(deck.GetCard());
    }
}

