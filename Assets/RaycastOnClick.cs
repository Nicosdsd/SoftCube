using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastOnClick : MonoBehaviour
{
    public Camera camera;
    public float forceAmount = 500f;

    private void Update()
    {
        // Check if the left mouse button is down
        if (Input.GetMouseButtonDown(0))
        {
            // Do a raycast from the mouse position on screen into the world space
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                // Check if the object has the tag "Box"
                if (hit.transform.CompareTag("Box"))
                {
                    // Get the rigidbody component of the object and apply an upward force
                    Rigidbody rb = hit.transform.GetComponent<Rigidbody>();
                    if (rb)
                    {
                        rb.AddForce(Vector3.up * forceAmount);
                    }
                }
            }
        }
    }
}