using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetShoot : MonoBehaviour
{
    public AudioSource audio;
    [SerializeField] Camera cam;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f));
            if(Physics.Raycast(ray, out RaycastHit hit))
            {
                Target target = hit.collider.gameObject.GetComponent<Target>();

                if(target != null)
                {
                    audio.Play();
                    target.Hit();
                    FindObjectOfType<Score>().UpdateScore(50);
                }
            }
        }
    }
}
