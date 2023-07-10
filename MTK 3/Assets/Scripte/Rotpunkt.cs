using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotpunkt : MonoBehaviour
{
    public GameObject rotpunkt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
            rotpunkt.SetActive(false);

        else if (Input.GetKeyUp(KeyCode.LeftShift))
            rotpunkt.SetActive(true);
    }
}
