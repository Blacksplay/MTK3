using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemovePult : MonoBehaviour
{

    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject cam4;


    public GameObject pult1;
    public GameObject pult2;
    public GameObject pult3;
    public GameObject pult4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("0"))
        {
            if (cam1.activeSelf)
            {
                if (!pult1.activeSelf)
                {
                    pult1.SetActive(true);
                    print("pult an");
                }


                else if (pult1.activeSelf)
                {
                    pult1.SetActive(false);
                    print("pult aus");
                }
            }

            if (cam2.activeSelf)
            {
                if (!pult2.activeSelf)
                {
                    pult2.SetActive(true);
                    print("pult an");
                }


                else if (pult2.activeSelf)
                {
                    pult2.SetActive(false);
                    print("pult aus");
                }
            }

            if (cam3.activeSelf)
            {
                if (!pult3.activeSelf)
                {
                    pult3.SetActive(true);
                    print("pult an");
                }


                else if (pult3.activeSelf)
                {
                    pult3.SetActive(false);
                    print("pult aus");
                }
            }

            if (cam4.activeSelf)
            {
                if (!pult4.activeSelf)
                {
                    pult4.SetActive(true);
                    print("pult an");
                }


                else if (pult4.activeSelf)
                {
                    pult4.SetActive(false);
                    print("pult aus");
                }
            }
        }
    }
}
