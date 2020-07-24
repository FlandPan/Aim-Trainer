using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject g;
    public float force;
    public float timing;
    void Start()
    {
        Spawn();
    }
    void Spawn()
    {
        Vector3 direction = new Vector3(Random.Range(-1.0f,1),Random.Range(-1.0f,1),0);
        direction.Normalize();
        GameObject h = Instantiate(g,this.transform.position,new Quaternion());
        float f = PlayerPrefs.GetFloat("radius",7f);
        h.transform.localScale = new Vector3(f,f,f);
        h.GetComponent<Rigidbody>().AddForce(direction*PlayerPrefs.GetFloat("force",10),ForceMode.Impulse);
        Invoke("Spawn", PlayerPrefs.GetFloat("timing",1));
    }
    public void SetTiming(string t){
        PlayerPrefs.SetFloat("timing", float.Parse(t));
    }
    public void SetForce(string f){
        PlayerPrefs.SetFloat("force", float.Parse(f));
    }
}
