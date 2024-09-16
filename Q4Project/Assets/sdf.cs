using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sdf : MonoBehaviour
{
    public KeyCode atac;
    public KeyCode fle;
    public TurnSystem youshould;
    void Update()
    {
        if (Input.GetKeyDown(atac))
        {
            youshould.OnAttack();
        }
        if (Input.GetKeyDown(fle))
        {
            youshould.OnFlee();
        }
    }
}
