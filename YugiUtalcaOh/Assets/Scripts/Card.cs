using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public Text inputFieldNameText;

    private string name;
    private string type, description;
    private int attack, defense, star;


    // Start is called before the first frame update
    void Start()
    {
        if (name != null)
            name = PlayerPrefs.GetString("CardName");

    }

    // Update is called once per frame
    void Update()
    {
         
    }

    public void SaveInfo()
    {
        name = inputFieldNameText.text.ToString();
        PlayerPrefs.SetString("CardName", name);
    }

    
}
