using UnityEngine;

public class GrenadeTrhrowing : MonoBehaviour {
    public GameObject grenade;
    bool havegranade = true;
	void Start () {
        
	}

    void Update () {
	if((Input.GetMouseButton(0) && havegranade))
        {        
            grenade.transform.parent=null;
            grenade.AddComponent<Rigidbody>();
            grenade.GetComponent<Rigidbody>().AddForce(transform.forward * 2000);
            havegranade = false;
        }
	}
}
