using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_extinguisher_water_on_controller : MonoBehaviour
{
    public GameObject fire_water, pin_scrn, fire1;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "righthand")
        {
            fire_water.SetActive(true);
            pin_scrn.SetActive(false);
            fire1.SetActive(true);
        }
        if (collision.gameObject.tag == "lefthand")
        {
            fire_water.SetActive(true);
            pin_scrn.SetActive(false);
            fire1.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
