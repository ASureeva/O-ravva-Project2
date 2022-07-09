using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationOpen_Cafe : MonoBehaviour
{
    public Animator anim;

    public bool isNear;

    private void Update()
    {
        OnTriggerStay(GetComponent<Collider>());
    }

    public void OnTriggerEnter(Collider other)
    {
        isNear = true;
    }

    public void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F) & isNear == true)
            anim.SetBool("IsOpen", true);

    }

    private void OnTriggerExit(Collider other)
    {
        isNear = false;
    }
}
