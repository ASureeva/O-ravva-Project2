using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Action2 : MonoBehaviour
{
    public GameObject infText;
    public GameObject actionText;
    public GameObject img;
    public GameObject telegraph;
    public GameObject telegraphR;

    public Sprite spr;

    
    public Text infText1;
    public Text actionTxt;

    public bool isUsed;
    public bool isUsedAgain;

    private void Update()
    {
        OnTriggerStay(GetComponent<Collider>());
    }

    private void OnTriggerEnter(Collider other)
    {
        infText1.text = "Чего-то в нем не хватает";
        actionTxt.text = "Прям как Тесла!";
        isUsed = true;
        if (other.tag == "Player" & isUsedAgain == false)
            infText.SetActive(true);        
    }

    private void OnTriggerStay(Collider other)
    {
        if ((Input.GetKeyDown(KeyCode.Alpha2) & isUsed == true) & img.GetComponent<Image>().sprite == spr & isUsedAgain == false )
        {
            actionText.SetActive(true);
            telegraph.SetActive(false);
            telegraphR.SetActive(true);
            isUsedAgain = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        infText.SetActive(false);
        actionText.SetActive(false);
        isUsed = false;
        
    }




}
