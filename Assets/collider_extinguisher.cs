using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider_extinguisher : MonoBehaviour
{
    public static collider_extinguisher instance;
    public GameObject display_fire, hand_fire_ext, fire_detector, fire_pin;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "lefthand")
        {
            display_fire.SetActive(false);
            hand_fire_ext.SetActive(true);
            fire_detector.SetActive(true);
            fire_pin.SetActive(true);
        }
        if (collision.gameObject.tag == "righthand")
        {
            display_fire.SetActive(false);
            hand_fire_ext.SetActive(true);
            fire_detector.SetActive(true);
            fire_pin.SetActive(true);
        }
        if (collision.gameObject.tag == "Player")
        {
            //display_fire.SetActive(false);
            //hand_fire_ext.SetActive(true);
            //fire_detector.SetActive(true);
            //fire_pin.SetActive(true);
            Fire_controller.instance.fire_exting_btn_press();
        }
    }
    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Fire_controller.instance.fire_exting_btn_release();
        }
    }
    public void turn_on_exting()
    {
      //  display_fire.SetActive(false);
        hand_fire_ext.SetActive(true);
        fire_detector.SetActive(true);
        fire_pin.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
