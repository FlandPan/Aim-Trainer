using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public InputField sensivity;
    public InputField radius;
    public InputField timing;
    public InputField speed;
    public GameObject mainGUI;
    void Start()
    {
        sensivity.text = "" + PlayerPrefs.GetFloat("sens",100f);
        radius.text = "" + PlayerPrefs.GetFloat("radius", 7.0f);
        timing.text = "" + PlayerPrefs.GetFloat("timing", 1.0f);
        speed.text = "" + PlayerPrefs.GetFloat("force", 10.0f);
    }

    public void RadiusChanged(string val){
        float valF = float.Parse(val);
        if(valF <= 10 && valF > 0){
            PlayerPrefs.SetFloat("radius", valF);
        }else if(valF > 10){
            PlayerPrefs.SetFloat("radius", 10);
        }else if(valF <= 0){
            PlayerPrefs.SetFloat("radius", 1);
        }
        radius.text = "" + PlayerPrefs.GetFloat("radius", 7.0f);
    }
    public void Exit(){
        mainGUI.SetActive(true);
        gameObject.SetActive(false);
    }
}   
