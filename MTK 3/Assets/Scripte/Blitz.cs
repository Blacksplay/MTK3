using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blitz : MonoBehaviour
{

    public GameObject blitz;

    void Update()
    {
        if (Input.GetKeyUp("8"))
        {
                StartCoroutine(Bltz());
        }
    }


    IEnumerator Bltz()
    {
        yield return new WaitForSeconds(2);

        blitz.SetActive(true);

        yield return new WaitForSeconds(0.05f);

        blitz.SetActive(false);
    }
}
