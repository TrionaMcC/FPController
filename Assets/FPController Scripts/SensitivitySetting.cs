using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SensitivitySetting : MonoBehaviour
{
    public MouseLook playerCamera;
    public PlayerMovement playerMove;

    bool paused = false;

    public GameObject canvas;
    public Slider value;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("p") && !paused)
        {
            paused = true;
            playerCamera.enabled = false;
            playerMove.enabled = false;
            canvas.SetActive(true); 
            Cursor.lockState = CursorLockMode.None;
        }
        else if (Input.GetKeyDown("p") && paused)
        {
            paused = false;
            playerCamera.enabled = true;
            playerMove.enabled = true;
            canvas.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    public void ChangeSensitivty()
    {
        float newValue = value.value * 100f;
        playerCamera.mouseSensitivity = newValue;
    }

    public void Increase()
    {
        value.value++;
    }

    public void Decrease()
    {
        value.value--;
    }
}
