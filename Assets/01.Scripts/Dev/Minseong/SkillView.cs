using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillView : MonoBehaviour
{
    float time;
    float fadeRate = 0;
    void Start()
    {
        
    }

    void Update()
    {
        time += Time.deltaTime;

        transform.position = GameObject.Find("SkillPos").GetComponent<Transform>().position;

        Fade();
        Destroy(gameObject,3);
    }
    void Fade()
    {
        if(time <= 1)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, fadeRate);
            fadeRate += 0.007f;
        }
        if(time >= 1.5)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, fadeRate);
            fadeRate -= 0.007f;
        }
    }
}
