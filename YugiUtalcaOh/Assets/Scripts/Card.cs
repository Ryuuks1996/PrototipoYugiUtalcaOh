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
    private bool isCardFlag = false;
    private int count = 0;
    private string path;

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
        count = PlayerPrefs.GetInt("CardCount");

        if(count > 0)
        {
            var imageBytes = File.ReadAllBytes(Application.persistentDataPath + "/Card/" + name + ".PNG");
            var texture2D = new Texture2D(256, 256);
            texture2D.LoadRawTextureData(imageBytes);
            var sprite = Sprite.Create(texture2D, new Rect(0.0f, 0.0f, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f), 100.0f);
            image.GetComponent<Image>().sprite = sprite;
            Debug.Log(texture2D.name);
        }
        

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
        count++;
        PlayerPrefs.SetInt("CardCount", count);
        //SaveCard();

        starImage.sprite = starSprites[starAmount];
        image.GetComponent<Image>().sprite = cardImage.sprite;
        
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

        isCardFlag = true;

    }
}
