using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Museumanimation_Outside : MonoBehaviour
{
    public Animator animR;
    public Animator animL;

    

    public bool KeyBor;
    public bool isNear;

    private void Update()
    {
        OnTriggerStay(GetComponent<Collider>());
    }

    private void OnTriggerEnter(Collider other)
    {
        isNear = true;
    }
    private void OnTriggerStay(Collider other)
    {
        if (isNear == true)
        {
            animL.SetBool("KeyBor", true);
            animR.SetBool("KeyBor", true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        isNear = false;
    }
}
