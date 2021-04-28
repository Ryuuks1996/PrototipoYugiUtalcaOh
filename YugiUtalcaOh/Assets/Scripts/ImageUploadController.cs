using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class ImageUploadController : MonoBehaviour 
{
    public Image cardImage;
    //private Image cardImage;
    private Sprite mySprite;
    private SpriteRenderer spriteRenderer;


    // Start is called before the first frame update
    void Start()
    {
        //cardImage = GetComponent<Image>();
        spriteRenderer = gameObject.AddComponent<SpriteRenderer>() as SpriteRenderer;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickUploadImageButton()
    {
        //NativeGallery.PermisionType permisionType = new NativeGallery.PermissionType();
        NativeGallery.Permission per = NativeGallery.RequestPermission(new NativeGallery.PermissionType());

        // probably should do some permissions checking here

        NativeGallery.Permission permission = NativeGallery.GetImageFromGallery((path) =>
        {
            if (path != null)
            {
                // Create Texture from selected image

                Texture2D texture = NativeGallery.LoadImageAtPath(path, 2073600, false);

                if (texture == null) return;

                //StartCoroutine(UploadImage(texture));
                UploadImage(texture);
            }
        }, "Select an image", "image/*");
    }

    void UploadImage(Texture2D theimage)
    {
        mySprite = Sprite.Create(theimage, new Rect(0.0f, 0.0f, theimage.width, theimage.height), new Vector2(0.5f, 0.5f), 100.0f);
        cardImage.sprite = mySprite;
        /*var form = new WWWForm();
        form.AddBinaryData("imagedata", theimage.EncodeToPNG(), "uploadedimage");

        UnityWebRequestAsyncOperation www = UnityWebRequest.Post("https://www.myrandomserver.com/uploadimage.php", form).SendWebRequest();

        yield return www;

        if (www.webRequest.isHttpError || www.webRequest.isNetworkError)
        {
            Debug.Log("Error: " + www.webRequest.error);
        }
        else
        {
            Debug.Log("Done!");
        }*/
    }

}
