using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class helecopter_controller : MonoBehaviour
{
    public static helecopter_controller instance;    
    public GameObject player, Player_controller_player;
    public GameObject plane, fly_plane;
    public bool plane_state;
    public float smoothness;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        plane_state = false;
       // Invoke("active_plane", 5.0f);
    }

    public void active_plane()
    {
        plane_state = true;
    }
    public void Deactive_plane()
    {
        plane_state = false;
    }
    //-----------------------------
    //------------
    // Update is called once per frame
    void Update()
    {
        if (plane_state == true)
        {
            Vector3 newPosition = Vector3.Lerp(player.transform.position, this.transform.position, smoothness * Time.deltaTime);      //* Time.deltaTime
            player.transform.position = newPosition;
            Player_controller_player.transform.position = player.transform.position;
          //  player.transform.position = this.transform.position;
            player.transform.rotation = this.transform.rotation;
            plane.GetComponent<Animator>().SetBool("fly", true);
            fly_plane.GetComponent<Animator>().SetBool("plane", true);
            player.GetComponentInChildren<CharacterController>().enabled = false;
        }
    }
}
