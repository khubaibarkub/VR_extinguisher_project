using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class adddcontroller : MonoBehaviour
{

    public Texture[] ad;
    public GameObject addbanner1, addbanner2, addbanner3, addbanner4, addbanner5, ajj;
    public bool activeajj;
    // Start is called before the first frame update


    void Start()
    {
        InvokeRepeating("RunAd", 0.5f, 1f);
    }
    public void Update()
    {
        if (activeajj)
        {
            activeaj();
        }
    }
    public void activeaj()
    {
        ajj.SetActive(true);
        activeajj = false;
    }
    void RunAd()
    {
        addbanner1.GetComponent<Renderer>().material.mainTexture = ad[Random.RandomRange(0, ad.Length)];
        addbanner2.GetComponent<Renderer>().material.mainTexture = ad[Random.RandomRange(0, ad.Length)];
        addbanner3.GetComponent<Renderer>().material.mainTexture = ad[Random.RandomRange(0, ad.Length)];
        addbanner4.GetComponent<Renderer>().material.mainTexture = ad[Random.RandomRange(0, ad.Length)];
        addbanner5.GetComponent<Renderer>().material.mainTexture = ad[Random.RandomRange(0, ad.Length)];
    }
}
