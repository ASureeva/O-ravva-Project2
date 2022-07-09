using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuseumAnim : MonoBehaviour
{
    public Animator animR;
    public Animator animL;

    public GameObject item;
    public Sprite spr;

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
        if ((isNear == true) & item.GetComponent<Image>().sprite == spr)
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
