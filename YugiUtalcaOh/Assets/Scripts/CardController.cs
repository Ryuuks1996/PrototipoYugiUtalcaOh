using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour, IDraggeable
{
    public Transform destination, destination2, destination3;
    public bool isDestination;
    private Vector2 goalPosition, goalPosition2, goalPosition3;
    private Vector3 initialPos;

    public void Awake()
    {
        initialPos = transform.position;
        goalPosition = new Vector2(destination.position.x, destination.position.y);
        goalPosition2 = new Vector2(destination2.position.x, destination2.position.y);
        goalPosition3 = new Vector2(destination3.position.x, destination3.position.y);
    }

    public void Drag()
    {
    }

    public void Drop()
    {
        Vector2 position = gameObject.transform.position;
        Vector2 position2 = destination2.position;
        Vector2 position3 = destination3.position;

        //Primer Lugar disponible
        if ((position - goalPosition).magnitude <= 0.3f)
        {
            gameObject.transform.localScale = new Vector3(0.2f, 0.2f, 0f);
            gameObject.transform.position = new Vector3(destination.position.x, destination.position.y, 0f);
            isDestination = true;
        }
        else
        {
            gameObject.transform.localScale = new Vector3(0.2f, 0.2f, 0f);
            gameObject.transform.position = initialPos;
            isDestination = false;
        }

        //Segundo Lugar disponible
        if ((position2 - goalPosition2).magnitude <= 0.3f)
        {
            gameObject.transform.localScale = new Vector3(0.2f, 0.2f, 0f);
            gameObject.transform.position = new Vector3(destination2.position.x, destination2.position.y, 0f);
            isDestination = true;

        }
        else
        {
            gameObject.transform.localScale = new Vector3(0.2f, 0.2f, 0f);
            gameObject.transform.position = initialPos;
            isDestination = false;
        }

        //Tercer Lugar disponible
        if((position3 - goalPosition3).magnitude <= 0.3f)
        {
            gameObject.transform.localScale = new Vector3(0.2f, 0.2f, 0f);
            gameObject.transform.position = new Vector3(destination3.position.x, destination3.position.y, 0f);
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
