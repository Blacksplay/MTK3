using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSzene1 : Interactable
{

    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject cam4;


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
        cam1.SetActive(true);
        cam2.SetActive(false);
        cam3.SetActive(false);
        cam4.SetActive(false);
        print("Swap Cam 1");

    }


}
