using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserNames : MonoBehaviour
{
    public Text player1, player2;
    public string name1, name2;

    // Start is called before the first frame update
    void Start()
    {
        name1 = PlayerPrefs.GetString("UserName1");
        name2 = PlayerPrefs.GetString("UserName2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SavedUserNames()
    {
        PlayerPrefs.SetString("UserName1",player1.text.ToString());
        PlayerPrefs.SetString("UserName2", player2.text.ToString());
    }
}
