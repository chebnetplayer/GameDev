using UnityEngine;

public class PersonScript : MonoBehaviour
{
    public float PersonSpeed = 5;
    public float PersonRotation = 200;
    public GameObject Camera;
    public Quaternion Rotation;

    // Use this for  initialization
    void Start()
    {
        Rotation = Camera.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * PersonRotation * Time.deltaTime, 0);
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), (0-9.8f), Input.GetAxis("Vertical"));
        Camera.GetComponent<Animator>().SetFloat("Blend", movement.magnitude * PersonSpeed);
        movement *= Time.deltaTime*PersonSpeed;
        movement = Vector3.ClampMagnitude(movement, PersonSpeed);
        movement = transform.TransformDirection(movement);
        GetComponent<CharacterController>().Move(movement);
        /*if ((Camera.transform.rotation.eulerAngles.x > 310) || (Camera.transform.rotation.eulerAngles.x < 50))
        {
            Camera.transform.Rotate(-Input.GetAxis("Mouse Y") * Time.deltaTime * PersonRotation, 0, 0);
        }
        transform.Rotate(0, Input.GetAxis("Mouse X") * PersonRotation * Time.deltaTime, 0);
        transform.Translate(Input.GetAxis("Horizontal") * PersonSpeed * Time.deltaTime, 0, Input.GetAxis("Vertical") * PersonSpeed * Time.deltaTime);
        if (!((Camera.transform.rotation.eulerAngles.x > 310) || (Camera.transform.rotation.eulerAngles.x < 50)))
        {
            Camera.transform.rotation = Rotation;
        }
        Rotation = Camera.transform.rotation;*/
    }
}
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            





















































































































































            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
 