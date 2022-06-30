using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{

    //enemyMove en;
    Rigidbody2D rb;
    Vector3 vec;
  [SerializeField]private Transform playerpos;
   [SerializeField]private Transform enemypos;
    // Start is called before the first frame update
    void Start()
    {
        //en=GetComponent<enemyMove>();
    rb= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    { 
        transform.position = enemypos.position;
       if(transform.position.x<playerpos.position.x)
       {
       // rb.rotation+=180;
           transform.eulerAngles = new Vector3(0,180,0);
       }
       else
       {
         // rb.rotation-=180;
        transform.eulerAngles = new Vector3(0,0,0);  
       }/*
      
    Vector3 direction = playerpos.position -transform.position;
        float angel = Mathf.Atan2(direction.y ,direction.x)* Mathf.Rad2Deg;
           rb.rotation= angel;
      if(Input.GetKeyDown(KeyCode.H))
        {
            transform.eulerAngles= new Vector3(0,0,30);

        }*/
        // enemyMove en = GameObject.FindGameObjectsWithTag("enemy")
        // if(en.isright==true )
        // {
        //         transform.eulerAngles = new Vector3(0,180,0);
        // }
        // else
        // {
        //         transform.eulerAngles = new Vector3(0,0,0);
        // }
    }
}
