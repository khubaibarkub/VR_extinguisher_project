using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class next_btn_click : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "hand")
        {
            environment_manager.instance.next_btn_press();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
