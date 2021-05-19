using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenseAnimationController : MonoBehaviour
{
    private Animation defenseAnimation;
    
    // Start is called before the first frame update
    void Start()
    {
        defenseAnimation = GetComponent<Animation>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
            defenseAnimation.playAutomatically = true;
    }
}
