using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PartialScreenshotController : MonoBehaviour
{
    public RectTransform rectTransform;
    private int width, height;

    public GameObject mainCamera, cardCamera;
    private Texture2D texture2D;
    //private Camera cardCamera;
    
    // Start is called before the first frame update
    void Start()
    {
        
        
        width = System.Convert.ToInt32(rectTransform.rect.width);
        height = System.Convert.ToInt32(rectTransform.rect.height);

        /*cardCamera.gameObject.SetActive(true);
        mainCamera.gameObject.SetActive(false);
        
        texture2D = new Texture2D(256, 256, TextureFormat.RGB24, false);
        cardCamera = GetComponent<Camera>();
        RenderTexture.active = cardCamera.targetTexture;
        texture2D.ReadPixels(new Rect(0, 0, cardCamera.targetTexture.width, cardCamera.targetTexture.height), 0, 0);
        texture2D.Apply();
        
        var sprite = Sprite.Create(texture2D, new Rect(0.0f, 0.0f, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f), 100.0f);
        byte[] bytesArray = sprite.texture.EncodeToPNG();
        var dirPath = Application.persistentDataPath + "/CreatedCards/";

        if (!Directory.Exists(dirPath))
            Directory.CreateDirectory(dirPath);

        var timeStamp = DateTime.Now.ToString("yyyMMddHHmmssfff");
        File.WriteAllBytes(dirPath + name + ".PNG", bytesArray);*/
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            StartCoroutine(TakeScreenShot()); // screenshot of a particular UI Element.
        }
    }

    public IEnumerator TakeScreenShot()
    {
        cardCamera.SetActive(true);
        mainCamera.SetActive(false);
              
        Vector2 temp = rectTransform.transform.position;
        var startX = temp.x - width / 2;
        var startY = temp.y - height / 2;

        var tex = new Texture2D(width, height, TextureFormat.RGB24, false);
        tex.ReadPixels(new Rect(startX, startY, width, height), 0, 0);
        tex.Apply();

        // Encode texture into PNG
        var bytes = tex.EncodeToPNG();
        Destroy(tex);
        var dirPath = Application.persistentDataPath + "/CreatedCards/";

        if (!Directory.Exists(dirPath))
            Directory.CreateDirectory(dirPath);

        var timeStamp = DateTime.Now.ToString("yyyMMddHHmmssfff");
        File.WriteAllBytes(dirPath + name + ".PNG", bytes);


        yield return new WaitForEndOfFrame();

        mainCamera.SetActive(true);
        cardCamera.SetActive(false);
        
    }


}
