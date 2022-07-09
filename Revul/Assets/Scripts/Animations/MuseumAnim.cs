using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuseumAnim : MonoBehaviour
{
    public Animator animR;
    public Animator animL;

    public GameObject item;
    public GameObject txt;
    public Sprite spr;
    

    public bool KeyBor;
    public bool isNear;

    private void Update()
    {
        OnTriggerStay(GetComponent<Collider>());
    }

    private void OnTriggerEnter(Collider other)
    {
        txt.GetComponent<Text>().text = "Он для чего-то же нужен! #@#@#@#";
        isNear = true;
        if (other.tag == "Player" & KeyBor == false)
            txt.SetActive(true);
        
        
    }
    private void OnTriggerStay(Collider other)
    {
        if ((isNear == true) & (item.GetComponent<Image>().sprite == spr & Input.GetKeyDown(KeyCode.Alpha4)))
        {
            animL.SetBool("KeyBor", true);
            animR.SetBool("KeyBor", true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        isNear = false;
        if (other.tag == "Player" & KeyBor == false)
            txt.SetActive(false);
    }
}
