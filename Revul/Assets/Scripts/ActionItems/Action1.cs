using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Action1 : MonoBehaviour
{
    public GameObject infText;
    public GameObject actionText;
    public GameObject img;


    public Sprite spr;

    
    public Text infText1;
    public Text actiontxt;

    public bool isUsed;
    public bool isUsedAgain;





    // For optimization
    private void Update()
    {
        OnTriggerStay(GetComponent<Collider>());
    }

    private void OnTriggerEnter(Collider other)
    {
        
        infText1.text = "Эта дверь не выглядит прочной";
        actiontxt.text = "При союзе было лучше";

        if (other.tag == "Player" & isUsedAgain == false)
        {
            infText.SetActive(true);
            isUsed = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {

        if ((Input.GetKeyDown(KeyCode.Alpha1) & isUsed == true) & img.GetComponent<Image>().sprite == spr & isUsedAgain == false )
        {
            actionText.SetActive(true);
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
