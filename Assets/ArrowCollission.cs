using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowCollission : MonoBehaviour
{
    public GameObject activveaj;

    private void Update()
    {
        if (Input.GetKeyDown("n"))
        {
            activveaj.SetActive(true);
            Debug.Log("startttt");
        }
    }
}
