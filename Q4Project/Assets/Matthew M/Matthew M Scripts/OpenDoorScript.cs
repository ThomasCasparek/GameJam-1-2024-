using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorScript : MonoBehaviour
{
    private bool isOpen = false;
    public void OpenDoor()
    {
        StartCoroutine(Opening());
    }

    public IEnumerator Opening()
    {
        Animator animator = GetComponent<Animator>();
        animator.SetInteger("Interact", 1);
        yield return new WaitForSeconds(1f);
        isOpen = !isOpen;
        animator.SetBool("DoorOpen", isOpen);
        animator.SetInteger("Interact", 0);
    }
}
