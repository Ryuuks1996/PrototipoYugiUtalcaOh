using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownController : MonoBehaviour
{
    private Dropdown dropdown;

    // Start is called before the first frame update
    void Start()
    {
        dropdown.GetComponent<Dropdown>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(dropdown.value);
    }
}
