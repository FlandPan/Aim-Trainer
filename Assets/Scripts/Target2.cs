using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target2 : MonoBehaviour
{
    void OnDestroy()
    {
        BlinkSpawner.onScreen.Dequeue();
    }
}
