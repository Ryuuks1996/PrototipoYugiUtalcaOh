using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelUIFunction : MonoBehaviour
{
    public GameObject panel;
    public bool isPress;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPress)
            {
                NotPressKey();
            }
            else
            {
                PressKey();
            }
        }
        
    }

    public void PressKey()
    {
        panel.SetActive(true);
        Time.timeScale = 0f;
        isPress = true;
    }

    public void NotPressKey()
    {
        panel.SetActive(false);
        Time.timeScale = 0f;
        isPress = false;
    }
}
