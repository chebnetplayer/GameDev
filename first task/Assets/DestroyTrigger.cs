using UnityEngine;
using System.Collections;

public class DestroyTrigger : MonoBehaviour
{
    public void OnStart() {
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag!="Player")
        Destroy(this.gameObject);
    }
}
