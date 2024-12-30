using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class environment_manager : MonoBehaviour
{
    public GameObject Space_btn, Underwater_btn, city_btn, mountains_btn;
    public static environment_manager instance;
    public Material Space, Under_water, city, mountains;
    public GameObject BG;

    int count;
    bool click_mode;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        click_mode = true;
        count = 0;

    }
    // Screenshots
    void TakeScreenshot()
    {
        // Define the path where the screenshot will be saved
        string screenshotPath = Application.persistentDataPath + "/Screenshots/";

        // Check if the directory exists, and create it if not
        if (!Directory.Exists(screenshotPath))
        {
            Directory.CreateDirectory(screenshotPath);
        }

        // Define the screenshot filename with a timestamp
        string screenshotName = "Screenshot_" + System.DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".png";

        // Capture the screenshot
        ScreenCapture.CaptureScreenshot(Path.Combine(screenshotPath, screenshotName));

        // Inform the user (optional)
        Debug.Log("Screenshot saved to: " + screenshotPath + screenshotName);
    }

    //


    public void next_btn_press()
    {
        if (click_mode == true)
        {
            count = count + 1;
            
            if (count == 1)
            {
                Space_btn.SetActive(true);
                Underwater_btn.SetActive(false);
                city_btn.SetActive(false);
                mountains_btn.SetActive(false);
                click_mode = false;
                Invoke("click_mode_status", 1.0f);
            }
            if (count == 2)
            {
                Space_btn.SetActive(false);
                Underwater_btn.SetActive(true);
                city_btn.SetActive(false);
                mountains_btn.SetActive(false);
                click_mode = false;
                Invoke("click_mode_status", 1.0f);
            }
            if (count == 3)
            {
                Space_btn.SetActive(false);
                Underwater_btn.SetActive(false);
                city_btn.SetActive(true);
                mountains_btn.SetActive(false);
                click_mode = false;
                Invoke("click_mode_status", 1.0f);
            }
            if (count == 4)
            {
                Space_btn.SetActive(false);
                Underwater_btn.SetActive(false);
                city_btn.SetActive(false);
                mountains_btn.SetActive(true);
                click_mode = false;
                Invoke("click_mode_status", 1.0f);
                count = 0;
            }
        }
    }
    public void click_mode_status()
    {
        click_mode = true;
    }
    public void change_space()
    {
        BG.GetComponent<Renderer>().material = Space;
    }
    public void change_under_water()
    {
        BG.GetComponent<Renderer>().material = Under_water;
    }
    public void change_city()
    {
        BG.GetComponent<Renderer>().material = city;
    }
    public void change_mountains()
    {
        BG.GetComponent<Renderer>().material = mountains;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
