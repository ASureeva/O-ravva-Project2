using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePause : MonoBehaviour
{
    
    public GameObject _person;
    //public GameObject _camera;

    public GameObject _inventory;
    public GameObject _menu;
    public bool cursorIsVisible;
    public Button restartButton;
    public AudioSource clickSound;
    // Start is called before the first frame update
    void Start()
    {
        restartButton.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!cursorIsVisible) 
            { 
                cursorIsVisible = true;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                _person.SetActive(false);
                _inventory.SetActive(false); 
                _menu.SetActive(true); 
            } 
            else
            {
                cursorIsVisible = false;
                Cursor.lockState = CursorLockMode.Locked;
                _person.SetActive(true);
                _inventory.SetActive(true);
                _menu.SetActive(false);
            }
        }
    }
    void TaskOnClick()
    {
        clickSound.Play();
        cursorIsVisible = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        _person.SetActive(true);
        _inventory.SetActive(true);
        _menu.SetActive(false);
    }
}
