using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCameraTrigger : MonoBehaviour
{
    public bool near;

    public GameObject digitLock;
    public GameObject laptopLock;

    public GameObject cam;
    public bool cameraIsActive;
    public bool playerIsActive = true; 
    public Lock lockPuzzle;
    public GameObject prompt;
    public GameObject player;
    public int frame = 0;
    public GameObject pause;

    void Start()
    {
        prompt.SetActive(false);
        cam.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (lockPuzzle.wasSolved)
        {
            frame += 1;
            if (frame == 1)
            {
                prompt.SetActive(false);
                cam.SetActive(false);
                player.SetActive(true);
                GetComponent<BoxCollider>().enabled = false;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                pause.SetActive(true);
                digitLock.SetActive(false);
            }
        }
        
        else if (near && Input.GetKeyDown(KeyCode.F))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            cam.SetActive(true);
            player.SetActive(false);
            prompt.SetActive(false);
            pause.SetActive(false);

        }

        else if (near && Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            cam.SetActive(false);
            player.SetActive(true);
            pause.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        near = true;
        prompt.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        near = false;
        prompt.SetActive(false);
    }
}