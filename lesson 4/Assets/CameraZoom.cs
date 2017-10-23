using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraZoom : MonoBehaviour
{

    void Start() {
    }

    void Update()
    {
        GetComponent<Animator>().enabled = true;
        if ((Input.GetAxis("Mouse ScrollWheel") < 0))
        {
            GetComponent<Animator>().enabled = true;
        }
        if ((Input.GetAxis("Mouse ScrollWheel") > 0))
        {
            GetComponent<Animator>().enabled = true;
        }
        if ((Input.GetAxis("Mouse ScrollWheel") > 0))
            ZoomIn();
        if ((Input.GetAxis("Mouse ScrollWheel") < 0))
            ZoomOut();
        if ((Input.GetAxis("Mouse ScrollWheel") < 0) &&
            GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("NormalIn"))
        {
            GetComponent<Animator>().SetBool("ToNormal", true);
            GetComponent<Animator>().SetBool("IsScrollingIn", false);
            GetComponent<Animator>().SetBool("IsScrollingOut", false);
        }
        if ((Input.GetAxis("Mouse ScrollWheel") > 0) &&
           GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("NormalOut"))
        {
            GetComponent<Animator>().SetBool("ToNormal", true);
            GetComponent<Animator>().SetBool("IsScrollingOut", false);
            GetComponent<Animator>().SetBool("IsScrollingIn", false);
        }
    }
    void ZoomIn()
    {
        GetComponent<Animator>().SetBool("IsScrollingIn",true);
        GetComponent<Animator>().SetBool("ToNormal", false);
        GetComponent<Animator>().SetBool("IsScrollingOut", false);
    }
    void ZoomOut()
    {
        GetComponent<Animator>().SetBool("IsScrollingOut", true);
        GetComponent<Animator>().SetBool("ToNormal", false);
        GetComponent<Animator>().SetBool("IsScrollingIn", false);
    }
    void StopAnimator()
    {
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Normal"))
        {
            GetComponent<Animator>().enabled = false;
        }
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Normal"))
        {
            GetComponent<Animator>().enabled = false;
        }
    }
}
