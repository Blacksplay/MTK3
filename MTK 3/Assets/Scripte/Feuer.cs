using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feuer : MonoBehaviour
{
    [SerializeField]
    public GameObject fire;

    void Update()
    {


        if (Input.GetKeyUp("1"))
        {
            if (!fire.activeSelf)
            {
                fire.SetActive(true);
                print("feuer an");
            }

        }       
        
        if (Input.GetKeyUp("2"))
        {
            if (fire.activeSelf)
            {
                fire.SetActive(false);
                print("feuer aus");
            }

        }



    }
}
