using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public Text inputFieldNameText;
    public DropdownUI dropdownStar;
    private string name;
    private string type, description;
    private int attack, defense, star;


    // Start is called before the first frame update
    void Start()
    {
        name = PlayerPrefs.GetString("CardName");
        Debug.Log(name);
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
        PlayerPrefs.SetString("CardName", name);
    }


}
