using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blitzy : Interactable
{
    public GameObject blitz;

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

    }

    protected override void Interact()
    {
        blitz.GetComponent<Blitz>().blitzbutton();
    }
}
