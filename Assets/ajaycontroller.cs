using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ajaycontroller : MonoBehaviour
{
    public Animator anim;
    public AudioSource aud;
    public GameObject mixamo;
    public GameObject player;
    bool isDead = false;
    public Transform respawn;
    public adddcontroller con;
  


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullett")
        {
            Debug.Log("Hit");
            anim.SetBool("died", true);
            aud.Play();
            Destroy(collision.rigidbody.gameObject);
            StartCoroutine(restart());
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            anim.SetBool("died", false);
            Debug.Log("pressed.............");
            isDead = false; 
        }
        if (mixamo.transform.childCount > 3)
        {
            if (!isDead)
            {
                Debug.Log("Hit");
                anim.SetBool("died", true);
                aud.Play();
                isDead = true;
                StartCoroutine(restart());
            }
        }
        if (mixamo.transform.childCount < 4)
        {
            isDead = false;
        }
            if (Input.GetKeyDown("m"))
        {
            player.SetActive(false);
        }
        
    }

    IEnumerator restart()
    {
        
        yield return new WaitForSeconds(5f);
        player.SetActive(false);
        con.activeajj = true;
        player.transform.position = respawn.position;
        anim.SetBool("died", false);
        Debug.Log("pressed.............");
        yield break;
    }
}
