using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class  anim3script: MonoBehaviour
{
    private IEnumerator coroutine;
    public AnimationClip ac;
    void Start()
    {
        var random = (float)randomDouble(0.25, 5);
      //  coroutine = Animation3(random);
      //  StartCoroutine(coroutine);
      //  GetComponent<Animation>().AddClip(ac, "ac");
    }
    void Update()
    {
    }
    private IEnumerator Animation3(float waitTime)
    {
        while (true)
        {
            GetComponent<Animation>().CrossFade(ac.name);
            yield return new WaitForSeconds(waitTime);
        }
    }
    public static double randomDouble(double min, double max)
    {
        return (new System.Random()).NextDouble() * (max - min) + min;
    }
}



