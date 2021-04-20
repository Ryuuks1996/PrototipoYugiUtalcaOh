using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragController : MonoBehaviour
{
    private bool moveAllowed;
    private IDraggeable target;
    private GameObject targetGameObject;
    private Vector3 lastPos;
    private Vector3 lastTouchPos;
    private Vector3 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            //Save touch position (World)
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase)
            {
                //if he player was touched the screen
                case TouchPhase.Began:
                    Ray ray = Camera.main.ScreenPointToRay(touch.position);
                    RaycastHit2D hit = Physics2D.Raycast(touchPos, Camera.main.transform.forward);

                    if (hit.collider != null)
                    {
                        var temp = hit.collider.gameObject.GetComponent<IDraggeable>();
                        if (temp != null)
                        {
                            //if the touch begin into the object collider, then we permit the movement
                            moveAllowed = true;
                            target = temp;
                            targetGameObject = hit.collider.gameObject;
                            target.Pick();
                        }
                    }
                    break;

                //if we are moving ours fingers in the screen
                case TouchPhase.Moved:
                    if (moveAllowed && target != null)
                    {
                        //target.gameObject.transform.Translate(touch.deltaPosition);
                        targetGameObject.transform.Translate((new Vector3(touchPos.x, touchPos.y, 0)) -
                        new Vector3(lastTouchPos.x, lastTouchPos.y, 0));

                        target.Drag();
                    }

                    break;

                case TouchPhase.Ended:
                    if (target != null)
                        DropTarget();
                    break;
            }
            lastTouchPos = touchPos;
        }
        else
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                RaycastHit2D hit = Physics2D.Raycast(mousePos, Camera.main.transform.forward);

                if (hit.collider != null)
                {
                    var temp = hit.collider.gameObject.GetComponent<IDraggeable>();
                    if (temp != null)
                    {
                        //if the touch begin into the object collider, then we permit the movement
                        moveAllowed = true;
                        target = temp;
                        targetGameObject = hit.collider.gameObject;
                        target.Pick();
                    }
                }
            }
            if (Input.GetMouseButton(0) && target != null)
            {
                if (moveAllowed)
                {
                    target.Drag();
                    targetGameObject.transform.Translate((new Vector3(mousePos.x, mousePos.y, 0)) - new Vector3(lastPos.x, lastPos.y, 0));
                }
            }
            if (Input.GetMouseButtonUp(0) && target != null)
                DropTarget();
        }
        lastPos = mousePos;
    }

    //This function is dropping the target
    public void DropTarget()
    {
        moveAllowed = false;

        targetGameObject = null;
        if (target != null)
        {
            target.Drop();
        }
        target = null;
    }
}
