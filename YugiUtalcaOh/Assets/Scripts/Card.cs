using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public Text inputFieldNameText, inputFieldDescriptionText, inputFieldAttackText, inputFieldDefenseText;
    public GameObject UI_Card;
    public Image cardImage, starImage;
    public GameObject star, image;
    public Sprite[] starSprites;

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
        SaveCard();

        starImage.sprite = starSprites[starAmount];
        image.GetComponent<Image>().sprite = cardImage.sprite;
        
    }

    public void SaveCard()
    {
        byte[] bytesArray = cardImage.sprite.texture.EncodeToPNG();
        var dirPath = Application.persistentDataPath + "/Cards/";

        if (!Directory.Exists(dirPath))
            Directory.CreateDirectory(dirPath);

        var timeStamp = DateTime.Now.ToString("yyyMMddHHmmssfff");
        File.WriteAllBytes(dirPath + name + ".PNG", bytesArray);
    }
}
