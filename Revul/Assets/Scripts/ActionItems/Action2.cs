using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Action2 : MonoBehaviour
{
    public GameObject infText;
    public GameObject actionText;
    public GameObject roll;
    public GameObject telegraph;
    public GameObject telegraphR;
    public GameObject gear;
    public GameObject book;


    public Sprite sprI2;
    public Sprite sprI5;
    public Sprite sprI6;

    public bool isUsed;
    public bool isUsedAgain;
    public bool isUsedSecond;
    public bool isUsedThird;
    

    private void Update()
    {
        OnTriggerStay(GetComponent<Collider>());
    }

    private void OnTriggerEnter(Collider other)
    {
        infText.GetComponent<Text>().text = "Чего-то в нем не хватает";
        actionText.GetComponent<Text>().text = "Нужна шестерня!";
        isUsed = true;
        if (other.tag == "Player" & isUsedAgain == false)
            infText.SetActive(true);
        else if (other.tag == "Player" & isUsedSecond == false)
        {
            infText.GetComponent<Text>().text = "Нужна шестерня!";
            actionText.GetComponent<Text>().text = "Осталось записать книгу";
            infText.SetActive(true);
        }
        else if(other.tag == "Player" & isUsedThird == false)
        {
            actionText.GetComponent<Text>().text = "Осталось записать книгу";
            actionText.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if ((Input.GetKeyDown(KeyCode.Alpha2) & isUsed == true) & roll.GetComponent<Image>().sprite == sprI2 & isUsedAgain == false )
        {
            actionText.SetActive(true);
            telegraph.SetActive(false);
            telegraphR.SetActive(true);
            isUsedAgain = true;            
        }
        else if(Input.GetKeyDown(KeyCode.Alpha5) & isUsedSecond == false & gear.GetComponent<Image>().sprite == sprI5)
        {
            actionText.SetActive(true);
            isUsedSecond = true;
        }
        else if(Input.GetKeyDown(KeyCode.Alpha6) & isUsedThird == false & book.GetComponent<Image>().sprite == sprI6)
        {
            isUsedThird = true;
            SceneManager.LoadScene(3);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        infText.SetActive(false);
        actionText.SetActive(false);
        isUsed = false;
        
    }




}
