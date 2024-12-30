using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mountain_environ : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "hand")
        {
            environment_manager.instance.change_mountains();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
