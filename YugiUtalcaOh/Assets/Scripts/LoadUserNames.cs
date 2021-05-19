using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadUserNames : MonoBehaviour
{
    public Text playerName1, playerName2;
    // Start is called before the first frame update
    void Start()
    {
        playerName1.text = UserNames.name1;
        playerName2.text = UserNames.name2;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
