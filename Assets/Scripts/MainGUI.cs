using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGUI : MonoBehaviour
{
    public GameObject settings;

    public void Pause(){
        gameObject.SetActive(false);
        settings.SetActive(true);
    }

}
