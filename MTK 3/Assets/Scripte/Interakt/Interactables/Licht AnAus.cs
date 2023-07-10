using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LichtAus : Interactable
{

    public GameObject licht;

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
        if (!licht.activeSelf)
        {
            licht.SetActive(true);
            print("licht an");
        }


        else if (licht.activeSelf)
        {
            licht.SetActive(false);
            print("licht aus");
        }
    }
}
