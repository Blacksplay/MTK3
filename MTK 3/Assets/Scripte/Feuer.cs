using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feuer : MonoBehaviour
{
    [SerializeField]
    public GameObject fire;

    void Update()
    {


        if (Input.GetKeyDown("5"))
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
}
