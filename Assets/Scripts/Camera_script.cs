using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_script : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void Start_IDLE()
    {
        anim.SetInteger("navigation", 1);
    }
    public void Menu_START()
    {
        anim.SetInteger("navigation", 0);
    }
    public void shaking()
    {
        anim.Play("shaking", 1);
    }

}
