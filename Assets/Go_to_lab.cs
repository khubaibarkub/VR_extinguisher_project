using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Go_to_lab : MonoBehaviour
{
    public GameObject player, lab_point;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.transform.position = lab_point.transform.position;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
