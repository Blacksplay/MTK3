using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraSwitch : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject cam4;


    void Update()
    {
        if (Input.GetKeyUp("1"))
        {
            if (!cam1.activeSelf)
            {
                cam1.SetActive(true);
                cam2.SetActive(false);
                cam3.SetActive(false);
                cam4.SetActive(false);
                print("Swap Cam 1");
            }

        }

        if (Input.GetKeyUp("2"))
        {
            if (!cam2.activeSelf)
            {
                cam1.SetActive(false);
                cam2.SetActive(true);
                cam3.SetActive(false);
                cam4.SetActive(false);
                print("Swap Cam 2");
            }

        }

        if (Input.GetKeyUp("3"))
        {
            if (!cam3.activeSelf)
            {
                cam1.SetActive(false);
                cam2.SetActive(false);
                cam3.SetActive(true);
                cam4.SetActive(false);
                print("Swap Cam 1");
            }

        }

        if (Input.GetKeyUp("4"))
        {
            if (!cam4.activeSelf)
            {
                cam1.SetActive(false);
                cam2.SetActive(false);
                cam3.SetActive(false);
                cam4.SetActive(true);
                print("Swap Cam 1");
            }

        }
    }

}
