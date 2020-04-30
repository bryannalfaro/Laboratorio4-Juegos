using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb1;
   
    void Start()
    {
        rb1 = gameObject.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {

            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(myRay, out hitInfo))
            {
                Rigidbody rb = hitInfo.collider.GetComponent<Rigidbody>();
                if (rb)
                    rb.AddForce(-hitInfo.normal * 16, ForceMode.Impulse);
            }
        
        }
    }

    private void OnMouseOver()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

    private void OnMouseExit()
    {
        GetComponent<MeshRenderer>().material.color = Color.white;
    }
}
