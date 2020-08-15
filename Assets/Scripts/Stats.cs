using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    public static float shots = 0;
    public static float hits = 0;
    float timeTotal = 30;
    public Text hitPercent;
    public Text bestHitPercent;
    public Text timeRemaining;

    void Update()
    {
        if(timeTotal > 0){
            timeTotal -= Time.deltaTime;
        }
        timeRemaining.text = "" + Mathf.FloorToInt(timeTotal);
        if(shots > 0){
            hitPercent.text = "Current: " + Mathf.Round(hits/shots*1000)/1000;
        }
        if(timeTotal <= 0){
            if(PlayerPrefs.GetFloat("BestPercent", 0) < Mathf.Round(hits/shots*1000)/1000){
                PlayerPrefs.SetFloat("BestPercent", Mathf.Round(hits/shots*1000)/1000);
            }
            Reset();
        }
        bestHitPercent.text = "Best: " + Mathf.Round(PlayerPrefs.GetFloat("BestPercent",0)*1000)/1000;
    }

    public void Reset(){
        shots = 0;
        hits = 0;
        timeTotal = 30;
    }

    public static void OnShot(){
        shots ++;
    }
    public static void OnHit(){
        hits ++;
    }

}
