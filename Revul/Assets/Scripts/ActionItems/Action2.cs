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
    public Text tip;

    public bool isUsed;
    public bool isUsedAgain1;





    private void Update()
    {
        OnTriggerStay(GetComponent<Collider>());
    }

    private void OnTriggerEnter(Collider other)
    {
        
        infText1.text = "� ���� ��������� ������� ";
        if (other.tag == "Player")
            infText.SetActive(true);
        isUsed = true;

        
    }

    private void OnTriggerStay(Collider other)
    {

        if ((Input.GetKeyDown(KeyCode.Alpha2) & isUsed == true) & img.GetComponent<Image>().sprite == spr )
        {
            actionText.SetActive(true);
            telegraph.SetActive(false);
            telegraphR.SetActive(true);
            isUsedAgain1 = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        infText.SetActive(false);
        actionText.SetActive(false);
        isUsed = false;
        
    }




}