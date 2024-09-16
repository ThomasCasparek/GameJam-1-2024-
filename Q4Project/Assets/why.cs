using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class why : MonoBehaviour
{
    public KeyCode E;
    public flick UnityButtons;
    void Update()
    {
        if (Input.GetKeyDown(E))
        {
            UnityButtons.UniqueExit();
        }
    }
}
