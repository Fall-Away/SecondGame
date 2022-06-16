using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    Rigidbody2D rb;
    Vector3 vec;
  [SerializeField]private Transform playerpos;
   [SerializeField]private Transform enemypos;
    // Start is called before the first frame update
    void Start()
    {
    rb= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    { 
       transform.position = enemypos.position;
    Vector3 direction = playerpos.position -transform.position;
        float angel = Mathf.Atan2(direction.y ,direction.x)* Mathf.Rad2Deg;
           rb.rotation= angel;

        if(Input.GetKeyDown(KeyCode.H))
        {
            transform.eulerAngles= new Vector3(0,0,30);

        }
    }
}
