using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class Pipe : MonoBehaviour
{
    public bool isRotated;
    public bool WrenchUsed;

    // For first use.
    public GameObject InfText;
    public GameObject wrench;
    public Sprite item3;

    
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
        OnTriggerStay(GetComponent<Collider>());

       if (isRotated & Input.GetKeyDown(KeyCode.F) & WrenchUsed == true)
        {            
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            _camera.SetActive(true);
            _person.SetActive(false);
            prompt.SetActive(false);
            pause.SetActive(false);

        }

        if (isRotated & Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            _camera.SetActive(false);
            _person.SetActive(true);
            pause.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (WrenchUsed == false & Input.GetKeyDown(KeyCode.Alpha3) & wrench.GetComponent<Image>().sprite == item3)
        {
            WrenchUsed = true;
            InfText.SetActive(false);
            prompt.SetActive(true);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        isRotated = true;
        if (WrenchUsed == false)
        {
            InfText.GetComponent<Text>().text = "It's me Mario!";
            InfText.SetActive(true);            
        }
        else prompt.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        isRotated = false;
        prompt.SetActive(false);
        InfText.SetActive(false);
    }
}
