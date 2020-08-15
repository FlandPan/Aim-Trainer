using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkSpawner : MonoBehaviour
{
    float width = 15;
    float length = 30;
    Vector3 currPosition;
    public GameObject sphere;
    public static Queue<GameObject> onScreen;

    void Start()
    {
        currPosition = gameObject.transform.position;
        onScreen = new Queue<GameObject>();
    }
    void Spawn(){
        float x = Random.Range(currPosition.x-length,currPosition.x+length);
        float y = Random.Range(currPosition.y-width,currPosition.y+width);
        GameObject g = Instantiate(sphere,new Vector3(x,y,currPosition.z),new Quaternion());
        float r = PlayerPrefs.GetFloat("radius", 7);
        g.transform.localScale = new Vector3(r,r,r);
        onScreen.Enqueue(g);
    }
    void Update()
    {
        if(onScreen.Count < PlayerPrefs.GetInt("numScreen",3)){
            Spawn();
        }
    }
    public void SetNum(string n){
        PlayerPrefs.SetInt("numScreen",int.Parse(n));
    }
}
