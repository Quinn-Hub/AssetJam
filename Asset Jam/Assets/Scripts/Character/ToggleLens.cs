using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLens : MonoBehaviour
{
    bool isEnabled = false;
    GameObject spriteMask;
    // Start is called before the first frame update
    void Start()
    {
        spriteMask = GameObject.Find("SpriteMask");
        spriteMask.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            isEnabled = !isEnabled;
            spriteMask.SetActive(isEnabled);
        }

    }
}
