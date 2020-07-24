using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float sens = 100f;

    float xRotation = 0f;
    public GameObject g;
    private bool cursorState;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        cursorState = true;
    }

    private void ToggleCursor(){
        if(cursorState){
            Cursor.lockState = CursorLockMode.None;
        }else{
            Cursor.lockState = CursorLockMode.Locked;
        }
        cursorState = !cursorState;
    }
    void Update() {  
        if(cursorState){
            float mouseX = Input.GetAxis("Mouse X") * sens * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * sens * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation,-90f,90f);


            transform.localRotation = Quaternion.Euler(xRotation,0f,0f);
            g.transform.Rotate(Vector3.up*mouseX);
        }
        if(Input.GetKeyDown(KeyCode.Escape)){
            ToggleCursor();
        }
    }

    public void OnSensChange(string val){
        sens = float.Parse(val);
        PlayerPrefs.SetFloat("sens",float.Parse(val));
    }
}
