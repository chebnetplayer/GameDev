using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class random : MonoBehaviour{
    private IEnumerator coroutine;
    public GameObject player;
    void Start()
    {
        var random = (float)randomDouble(0.25, 5);
        coroutine = Animation(random);
        StartCoroutine(coroutine);
    }
    void Update()
    {
        player.transform.Rotate(10, 10, 10);
    }
    private IEnumerator Animation(float waitTime)
    {
        while (true)
        {
            player.transform.Translate(10, 10, 10);
            player.GetComponent<Animation>().CrossFade("3");
            yield return new WaitForSeconds(waitTime);
        }
    }
    public static double randomDouble(double min, double max)
    {
        return (new System.Random()).NextDouble() * (max - min) + min;
    }
}

