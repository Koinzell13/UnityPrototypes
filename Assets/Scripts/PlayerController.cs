using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Transform cameraSpot;
    [SerializeField] float mouseSensitivity = 1;
    float verticalLookRotation;
    // Update is called once per frame
   
    
    
    void Update()
    {
        transform.Rotate(Vector3.up * Input.GetAxisRaw("Mouse X") * mouseSensitivity);

        verticalLookRotation -= Input.GetAxisRaw("Mouse Y") * mouseSensitivity;
        verticalLookRotation = Mathf.Clamp(verticalLookRotation, -70, 70);
        cameraSpot.localEulerAngles = new Vector3(verticalLookRotation, 0, 0);
    }
}
