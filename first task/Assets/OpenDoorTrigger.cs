using UnityEngine;
using System.Collections;

public class OpenDoorTrigger : MonoBehaviour
{
    public GameObject door;
    public Light light;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            door.transform.Rotate(0, -90, 0);
            light.intensity = 5;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            door.transform.Rotate(0, 90, 0);
            light.intensity = 0;
        }
    }
}
