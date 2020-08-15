using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{  
    private Camera cam;
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Vector3 rayOrigin = cam.ViewportToWorldPoint(new Vector3(0.5f,0.5f,0));
            RaycastHit hit;
            Stats.OnShot();

            if(Physics.Raycast(rayOrigin,cam.transform.forward, out hit)){
                if(hit.collider.gameObject.tag == "Hittable"){
                    Stats.OnHit();
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}
