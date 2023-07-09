using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Licht : MonoBehaviour
{
    [SerializeField]
    public GameObject licht;





    void Update()
    {


        if (Input.GetKeyUp("7"))
        {
            if (!licht.activeSelf)
            {
                licht.SetActive(true);
                print("Licht an");
            }

            else if (licht.activeSelf)
            {
                licht.SetActive(false);
                print("Licht aus");
            }

        }

    }




    void lichtanaus()
    {
        if (!licht.activeSelf)
        {
            licht.SetActive(true);
            print("Licht an");
        }

        else if (licht.activeSelf)
        {
            licht.SetActive(false);
            print("Licht aus");
        }
    }
}