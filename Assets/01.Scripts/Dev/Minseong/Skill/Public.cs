using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Public : MonoBehaviour
{
    public float time;
    void Update()
    {
        time += Time.deltaTime;
    }
    public void ResetTime()
    {
        time = 0;
    }
}
