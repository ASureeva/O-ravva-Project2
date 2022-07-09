using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAction2 : MonoBehaviour
{
    public Action2 action;




    private void OnTriggerStay(Collider other)
    {
        if (action.isUsedAgain1 == true)
        {
            action.infText.SetActive(false);
            //Action2.Destroy(action);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        action.actionText.SetActive(false);
    }
}
