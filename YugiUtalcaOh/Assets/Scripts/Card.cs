using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public Text inputFieldNameText, inputFieldDescriptionText, inputFieldAttackText, inputFieldDefenseText;
    public GameObject UI_Card;

    private string name, description;
    private int type, element, starAmount, attack, defense;



    // Start is called before the first frame update
    void Start()
    {
        name = PlayerPrefs.GetString("CardName");
        type = PlayerPrefs.GetInt("CardType");
        element = PlayerPrefs.GetInt("CardElement");
        starAmount = PlayerPrefs.GetInt("CardStarAmount");
        description = PlayerPrefs.GetString("CardDescription");
        attack = PlayerPrefs.GetInt("CardAttack");
        defense = PlayerPrefs.GetInt("CardDefense");
        Debug.Log(attack);
    }

    // Update is called once per frame
    void Update()
    {
        //name = inputFieldNameText.text;
    }

    public void SaveInfo()
    {
        name = inputFieldNameText.text;
        type = UI_Card.GetComponent<Dropdown_UI_card>().cardTypeCount;
        element = UI_Card.GetComponent<Dropdown_UI_card>().cardElementCount;
        starAmount = UI_Card.GetComponent<Dropdown_UI_card>().cardStarCount;
        description = inputFieldDescriptionText.text;
        attack = int.Parse(inputFieldAttackText.text);
        defense = int.Parse(inputFieldDefenseText.text);
        PlayerPrefs.SetString("CardName", name);
        PlayerPrefs.SetInt("CardType", type);
        PlayerPrefs.SetInt("CardElement", element);
        PlayerPrefs.SetInt("CardStarAmount", starAmount);
        PlayerPrefs.SetString("CardDescription", description);
        PlayerPrefs.SetInt("CardAttack", attack);
        PlayerPrefs.SetInt("CardDefense", defense);
    }


}
