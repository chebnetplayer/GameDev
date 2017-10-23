using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraZoom : MonoBehaviour
{
    const string ToNormal= "ToNormal";
    const string IsScrollingIn = "IsScrollingIn";
    const string IsScrollingOut = "IsScrollingOut";
    const string MouseScroll = "Mouse ScrollWheel";

    void Start() {
    }

    void Update()
    {        
        if ((Input.GetAxis(MouseScroll) > 0))
            ChangeParametersValue(IsScrollingIn, IsScrollingOut, ToNormal);
        if ((Input.GetAxis(MouseScroll) < 0))
            ChangeParametersValue(IsScrollingOut, IsScrollingIn, ToNormal);
        if ((Input.GetAxis(MouseScroll) < 0) &&
            GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("NormalIn"))
        {
            ChangeParametersValue(ToNormal, IsScrollingIn, IsScrollingOut);
        }
        if ((Input.GetAxis(MouseScroll) > 0) &&
           GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("NormalOut"))
        {
            ChangeParametersValue(ToNormal,IsScrollingIn, IsScrollingOut);
        }
    }
    void ChangeParametersValue(string trueparameter,string falseparameter1,string falseparameter2)
    {
        GetComponent<Animator>().SetBool(trueparameter, true);
        GetComponent<Animator>().SetBool(falseparameter1, false);
        GetComponent<Animator>().SetBool(falseparameter2, false);
    }
}
