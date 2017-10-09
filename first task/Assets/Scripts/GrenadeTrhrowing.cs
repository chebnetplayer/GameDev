using UnityEngine;
using System.Collections;

public class GrenadeTrhrowing : MonoBehaviour {
    public GameObject grenadePrefab;
    bool isReadyForthrow=true;
    public GameObject throwingPosition;
	void Start () {
        
	}

    void Update () {
	if(Input.GetMouseButton(0)&&isReadyForthrow)
        {
            GameObject obj=(GameObject)Instantiate(grenadePrefab,
                throwingPosition.transform.position,
                throwingPosition.transform.rotation);
            obj.GetComponent<Rigidbody>().AddForce(transform.forward * 2000);
            StartCoroutine(ThrowingCalldown());
        }
	}
    IEnumerator ThrowingCalldown()
    {
        isReadyForthrow = false;
        yield return new WaitForSeconds(1);
        isReadyForthrow = true;
    }
    

}
