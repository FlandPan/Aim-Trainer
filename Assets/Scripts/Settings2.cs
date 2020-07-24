using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings2 : MonoBehaviour
{
    public InputField sensivity;
    public InputField radius;
    public InputField numScreen;
    public GameObject mainGUI;
    void Start()
    {
        sensivity.text = "" + PlayerPrefs.GetFloat("sens",100f);
        radius.text = "" + PlayerPrefs.GetFloat("radius", 7.0f);
        numScreen.text = "" + PlayerPrefs.GetInt("numScreen", 3);
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
