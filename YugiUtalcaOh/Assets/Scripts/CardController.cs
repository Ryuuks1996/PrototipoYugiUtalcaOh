using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour, IDraggeable
{
    public Transform destinaion;
    public bool isDestination;
    private Vector2 goalPosition;
    private Vector3 initialPos;

    public void Awake()
    {
        initialPos = transform.position;
        goalPosition = new Vector2(destinaion.position.x, destinaion.position.y);
    }

    public void Drag()
    {
    }

    public void Drop()
    {
        Vector2 position = gameObject.transform.position;
        
        if ((position - goalPosition).magnitude <= 0.3f)
        {
            gameObject.transform.localScale = new Vector3(0.2f, 0.2f, 0f);
            gameObject.transform.position = new Vector3(destinaion.position.x, destinaion.position.y, 0f);
            isDestination = true;
        }
        else
        {
            gameObject.transform.localScale = new Vector3(0.2f, 0.2f, 0f);
            gameObject.transform.position = initialPos;
            isDestination = false;
        }
    }

    public void Pick()
    {
        gameObject.transform.localScale = new Vector3(0.3f, 0.3f, 0f);
    }
}
