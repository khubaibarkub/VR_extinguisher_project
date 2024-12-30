using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_controller : MonoBehaviour
{
    public static Fire_controller instance;
    public GameObject Fire1, Fire2, Fire3, extinguisher, extinguisher_water, tablet, start_point, fire_point, instruction_scrn_main, fire_plane_screen;
    public GameObject escape_plane_done, Alaram_screen_done, escape_plane_scrn, Alaram_screen_Scrn, start_point_scrn, fire_point_scrn, instruction_scrn;
    public GameObject player, player_controller;
    public GameObject step1_position, step2_position, step3_position, step4_position, step5_position;
    public bool step1, step2, step3, step4, step5;
    public Material pic;
    public Texture txture_highlight, normal_texture;

    // Start is called before the first frame update

    void Start()
    {
        instance = this;
       // Invoke("player_start_point", 3.0f);
    }

    public void player_start_point()
    {
        player.transform.position = start_point.transform.position;
        player_controller.transform.position = start_point.transform.position;
        player_controller.GetComponent<CharacterController>().enabled = false;
    }
    public void Player_fire_room_point()
    {
        player.transform.position = fire_point.transform.position;
        player_controller.transform.position = fire_point.transform.position;
        player_controller.GetComponent<CharacterController>().enabled = true;
        start_point_scrn.SetActive(false);
        fire_point_scrn.SetActive(true);
        instruction_scrn_main.SetActive(false);
        fire_plane_screen.SetActive(false);
        instruction_scrn.SetActive(false);
        tablet.SetActive(true);
    }
    public void extinguisher_btn_selected()
    {
        start_point_scrn.SetActive(false);
        fire_point_scrn.SetActive(true);
        instruction_scrn_main.SetActive(true);
        fire_plane_screen.SetActive(true);
        instruction_scrn.SetActive(true);
        tablet.SetActive(false);
        //pic.SetTexture("_MainTex", txture_highlight);
      //  pic.SetTexture("_MainTex", normal_texture);
    }
    public void floor_plan_gets_bigger()
    {
        fire_plane_screen.GetComponent<Animator>().SetBool("anim", true);
        Invoke("close_floor_plan", 10.0f);
    }
    public void close_floor_plan()
    {
        fire_plane_screen.GetComponent<Animator>().SetBool("anim", false);
    }
    public void fire_exting_btn_press()
    {
        pic.SetTexture("_MainTex", txture_highlight);
    }
    public void fire_exting_btn_release()
    {
        pic.SetTexture("_MainTex", normal_texture);
    }

    public void open_tablet()
    {
        tablet.SetActive(true);
    }
    public void close_tablet()
    {
        tablet.SetActive(false);
    }
    public void player_move_step1()
    {
        player.transform.position = step1_position.transform.position;
        player_controller.transform.position = step1_position.transform.position;
    }
    public void player_move_step2()
    {
        player.transform.position = step2_position.transform.position;
        player_controller.transform.position = step2_position.transform.position;
    }

    public void player_move_step3()
    {
        player.transform.position = step3_position.transform.position;
        player_controller.transform.position = step3_position.transform.position;
    }
    
    public void player_move_step4()
    {
        player.transform.position = step4_position.transform.position;
        player_controller.transform.position = step4_position.transform.position;
    }
    public void player_move_step5()
    {
        player.transform.position = step5_position.transform.position;
        player_controller.transform.position = step5_position.transform.position;
    }

    public void escape_plane_btn_clicked()
    {
        escape_plane_done.SetActive(true);
        Invoke("close_escp", 2.0f);
    }
    public void close_escp()
    {
        escape_plane_scrn.SetActive(false);
        Alaram_screen_Scrn.SetActive(true);
    }
    public void escape_plane_btn_NO_clicked()
    {
        escape_plane_done.SetActive(false);
    }

    public void alaram_scrn_btn_clicked()
    {
        Alaram_screen_done.SetActive(true);
        Invoke("close_alarm", 2.0f);
    }
    public void close_alarm()
    {
        escape_plane_scrn.SetActive(false);
        Alaram_screen_Scrn.SetActive(false);
    }
    public void alaram_scrn_btn_No_clicked()
    {
        Alaram_screen_done.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
