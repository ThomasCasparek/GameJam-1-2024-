using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerCtrl : MonoBehaviour
{
    public float movSpeed;
    float speedX, speedY;
    Rigidbody2D rb;
    private Animator animator;
    private Vector2 moveInput;
    public KeyCode Interact;
    public float interactRange = 30f;
    private List<Transform> npclist;
    public LayerMask Interactable;
    public GameObject SavePosition;
    public KeyCode YourLifeIsNothing;
    public GameObject YouServeZeroPurpose;

    // Start is called before the first frame update
    private void Awake()
    {
        transform.position = SavePosition.GetComponent<Transform>().position;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
        animator.SetBool("Is moving", moveInput != Vector2.zero);

        if (moveInput != Vector2.zero)
        {
            animator.SetFloat("XInput", moveInput.x);
            animator.SetFloat("YInput", moveInput.y);
        }
    }

    // Update is called once per frame
    void Update()
    {
        speedX = moveInput.x * movSpeed;
        speedY = moveInput.y * movSpeed;

        if (Mathf.Abs(speedX) > Mathf.Abs(speedY))
        {
            speedY = 0;
        }
        else
        {
            speedX = 0;
        }

        rb.velocity = new Vector2(speedX, speedY);

        if (Input.GetKeyDown(Interact))
        {
            Collider2D[] collideObject = Physics2D.OverlapCircleAll(transform.position, interactRange, Interactable);
            foreach (Collider2D interactObject in collideObject)
            {
                if (interactObject.gameObject.TryGetComponent(out DialogueTriggerScript dialogueScript))
                {
                    dialogueScript.TriggerDialogue();
                }
            }
        }

        if (Input.GetKeyDown(YourLifeIsNothing))
        {
            YouServeZeroPurpose.GetComponent<DialogueManagerScript>().DisplayNextSentence();
        }
    }
}
