using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShowText : MonoBehaviour
{
    public GameObject textInf;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            textInf.SetActive(true);
           textInf.GetComponent<Text>().text = " ??????? F, ??? ?? ????????? ??????? ";
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            textInf.SetActive(false);
    }

    private void OnDisable()
    {
        if (textInf != null)
            textInf.SetActive(false);
        
    }
}
