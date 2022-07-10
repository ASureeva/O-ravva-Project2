using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
    // Start is called before the first frame update
    //public PipePuzzle pipePuzzle;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //Cursor.visible = digitLock.cursorIsVisible || digitLock_2.cursorIsVisible || pipe.cursorIsVisible;
    }
}
