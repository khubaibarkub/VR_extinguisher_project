using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire1_coll : MonoBehaviour
{
    public GameObject fire1, complete;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    //
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "water")
        {
            Invoke("close_fire", 3.0f);
        }
    }
    public void close_fire()
    {
        fire1.SetActive(false);
        complete.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
