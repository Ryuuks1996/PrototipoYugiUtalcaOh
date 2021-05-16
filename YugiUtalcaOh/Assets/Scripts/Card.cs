using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public Text inputFieldNameText;
    public GameObject UI_Card;

    private string name;
    private int type;
    private int attack, defense, star;


    // Start is called before the first frame update
    void Start()
    {
        name = PlayerPrefs.GetString("CardName");
        type = PlayerPrefs.GetInt("CardType");
        Debug.Log(name);
        Debug.Log(type);
        //Debug.Log(name);

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
        PlayerPrefs.SetString("CardName", name);
        PlayerPrefs.SetInt("CardType", type);
    }


}
