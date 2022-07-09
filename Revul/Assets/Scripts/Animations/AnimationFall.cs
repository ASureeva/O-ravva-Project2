using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationFall : MonoBehaviour
{
    public Animator anim;

    public GameObject img;
    public Sprite spr;

    public void Update()
    {
        OnTriggerStay(GetComponent<Collider>());
    }



    public void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) & (img.GetComponent<Image>().sprite == spr))
            anim.SetBool("IsFall", true);

    }
}
