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
    public GameObject star;
    public GameObject cardType, cardElement;
    public List<GameObject> cardTypes, cardElements, cardStars;
    public GameObject cardName, cardDescription, cardAttack, cardDefense;

    private string name, description;
    private int type, element, starAmount, attack, defense;
    private bool isCardFlag = false;
    private string path;

    // Start is called before the first frame update
    void Start()
    {
        name = PlayerPrefs.GetString("CardName");
        cardName.GetComponent<Text>().text = name;

        type = PlayerPrefs.GetInt("CardType");
        cardType.GetComponent<Image>().sprite = cardTypes[type].GetComponent<Image>().sprite;
        
        element = PlayerPrefs.GetInt("CardElement");
        cardElement.GetComponent<Image>().sprite = cardElements[element].GetComponent<Image>().sprite;

        starAmount = PlayerPrefs.GetInt("CardStarAmount");
        for (int i = 0; i <= starAmount; i++)
            cardStars[i].SetActive(true);

        description = PlayerPrefs.GetString("CardDescription");
        cardDescription.GetComponent<Text>().text = description;

        attack = PlayerPrefs.GetInt("CardAttack");
        cardAttack.GetComponent<Text>().text = attack.ToString();

        defense = PlayerPrefs.GetInt("CardDefense");
        cardDefense.GetComponent<Text>().text = defense.ToString();

        /*var imageBytes = File.ReadAllBytes(Application.persistentDataPath + "/Card/" + name + ".PNG");
        var texture2D = new Texture2D(256, 256);
        texture2D.LoadRawTextureData(imageBytes);
        var sprite = Sprite.Create(texture2D, new Rect(0.0f, 0.0f, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f), 100.0f);
        image.GetComponent<Image>().sprite = sprite;
        Debug.Log(texture2D.name);*/
        

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

        //starImage.sprite = starSprites[starAmount];
        //image.GetComponent<Image>().sprite = cardImage.sprite;
        
    }

    public void SaveCard()
    {
        byte[] bytesArray = cardImage.sprite.texture.EncodeToPNG();
        var dirPath = Application.persistentDataPath + "/Card/";

        if (!Directory.Exists(dirPath))
            Directory.CreateDirectory(dirPath);

        var timeStamp = DateTime.Now.ToString("yyyMMddHHmmssfff");
        File.WriteAllBytes(dirPath + name + ".PNG", bytesArray);
        PlayerPrefs.SetString("DirPath", path);

    }
}
