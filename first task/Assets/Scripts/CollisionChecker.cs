using UnityEngine;
using System.Collections;

public class CollisionChecker : MonoBehaviour {

   /* IEnumerator WaitOneSecond()
    {
        yield return new WaitForSeconds(1);
        StartCoroutine(Explosion());
    }
    

    void Start()
    {
        wait = StartCoroutine(WaitOneSecond());
    }
    Coroutine wait;
	void OnCollisionEnter () {
        StopCoroutine(wait);
         StartCoroutine(Explosion());
	
	}

    void Update () {
	
	}
    IEnumerator Explosion()
    {
        GetComponent<Rigidbody>().Sleep();
        GetComponent<Rigidbody>().useGravity = false;
        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(0).gameObject.GetComponent<ParticleSystem>().Play(true);
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }*/
}
