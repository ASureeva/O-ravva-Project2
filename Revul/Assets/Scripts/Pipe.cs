using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Serialization;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public bool isRotated;

    public GameObject _person;
    public GameObject _camera;

    public GameObject prompt;
    public PipePuzzle pipePuzzle;
    public GameObject pause;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (isRotated && Input.GetKeyDown(KeyCode.F))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            _camera.SetActive(true);
            _person.SetActive(false);
            prompt.SetActive(false);
            pause.SetActive(false);

        }

        if (isRotated && Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            _camera.SetActive(false);
            _person.SetActive(true);
            pause.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        isRotated = true;
        prompt.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        isRotated = false;
        prompt.SetActive(false);
    }
}
