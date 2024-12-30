using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class right_hand_controller : MonoBehaviour
{
    public GameObject display_fire, hand_fire_ext;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "fireext")
        {
            display_fire.SetActive(false);
            hand_fire_ext.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
