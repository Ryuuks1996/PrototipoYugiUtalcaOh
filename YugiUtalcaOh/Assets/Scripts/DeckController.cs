using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckController : MonoBehaviour
{
    public List<Card> card;

    void Start()
    {
        
    }

  
    void Update()
    {
        
    }


    //cambiar luego
    public Card getCard()
    {
        return card[0];
    }
}
