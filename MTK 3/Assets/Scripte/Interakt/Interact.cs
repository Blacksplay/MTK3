using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interact : MonoBehaviour
{

    public Camera Cam;
    private float distance = 3f;
    [SerializeField]
    private LayerMask mask;
    private PlayerUI playerUI;
    //private InputManager inputManager;

    void Start()
    {
        playerUI = GetComponent<PlayerUI>();
        //inputManager = GetComponent<InputManager>();
    }

    void Update()
    {

        playerUI.UpdateText(string.Empty);

        Ray ray = new Ray(Cam.transform.position, Cam.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * distance);
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo, distance, mask))
        {
            if (hitInfo.collider.GetComponent<Interactable>()!= null)
            {
                Interactable interactable = hitInfo.collider.GetComponent<Interactable>();
                playerUI.UpdateText(interactable.PromptMessange);
                if(Input.GetKeyUp("e"))
                {
                    interactable.BaseInteract();
                }
            }
        }

    }
}