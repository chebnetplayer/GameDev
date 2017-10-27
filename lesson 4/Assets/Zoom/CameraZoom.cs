using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    private Animator _animator;
    void Start()
    {
        _animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            _animator.SetTrigger("ZoomOut");
            if (_animator.GetCurrentAnimatorStateInfo(0).IsName("NormalIn"))            
                ReturnToNormalAfterRetraction();               
            if (_animator.GetCurrentAnimatorStateInfo(0).IsName("NormalOut"))
                _animator.ResetTrigger("Zoomout");
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            _animator.SetTrigger("ZoomIn");
            if (_animator.GetCurrentAnimatorStateInfo(0).IsName("NormalOut"))          
                ReturnToNormalAfterApproach();           
            if (_animator.GetCurrentAnimatorStateInfo(0).IsName("NormalIn"))
                _animator.ResetTrigger("ZoomIn");
        }
    }

    private void ReturnToNormalAfterApproach()
    {
        _animator.SetTrigger("ToNormal");
        _animator.ResetTrigger("ZoomIn");
    }

    private void ReturnToNormalAfterRetraction()
    {
        _animator.SetTrigger("ToNormal");
        _animator.ResetTrigger("ZoomOut");
    }

}
