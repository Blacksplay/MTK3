using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KaminAnAus : Interactable
{

    public GameObject fire;

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
        if (!fire.activeSelf)
        {
            fire.SetActive(true);
            print("feuer an");
        }


        else if (fire.activeSelf)
        {
            fire.SetActive(false);
            print("feuer aus");
        }
    }
}
