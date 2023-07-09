using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teller : MonoBehaviour
{
    [SerializeField]
    public GameObject[] teller;

    public bool spawn;

    public float delay;

    void Update()
    {


        if (Input.GetKeyUp("6"))
        {
            if (!spawn)
            {
                StartCoroutine(SpawnTeller());
            }

            else if (spawn)
            {
                StartCoroutine(DespawnTeller());
            }
        }


        IEnumerator SpawnTeller()
        {

            print("Teller an");
            for (int i = 0; i < teller.Length; i++)
            {
                teller[i].SetActive(true);
                    yield return new WaitForSeconds(delay);
                    print("Teller an");

            }
            //print("Teller an");
            spawn=true;

        }

        IEnumerator DespawnTeller()
        {
            for (int i = 0; i < teller.Length; i++)
            {
                teller[i].SetActive(false);
                yield return new WaitForSeconds(delay); 
            }
            print("Teller aus");
            spawn=false;
    }

    }
}
