using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alpha : MonoBehaviour
{
  [SerializeField]
    Transform player;

    [SerializeField]
    float agroRange;

    [SerializeField]
    float movespeed;

    Rigidbody2D rb2d;
    public float distoplayer;

   [SerializeField]
   private float currenttime;
   [SerializeField]
   private float creattime;
   //   public bool isright=false;
      private bool ischase =false;
   //   public bool isleft=false;
 
      Vector3 vec =Vector3.zero;
 
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    
    }


    void Update()
    {
       transform.position+=movespeed*vec*Time.deltaTime;
      
        currenttime+=Time.deltaTime;
         distoplayer = Vector2.Distance(transform.position,player.position);
        if(distoplayer<agroRange)
        {
    vecteorpos(); 
         // ChasePlayer();
        // StartCoroutine(vecteorpos()) ;
        }
   
/*
if(isright)
{
       //rb2d.velocity = new Vector3(movespeed,0);  
      transform.eulerAngles = new Vector3(0,180,0);
}
if(isleft)
{
    //rb2d.velocity = new Vector3(-movespeed,0);
          transform.eulerAngles = new Vector3(0,0,0);    
}
*/
    }
    void ChasePlayer()
    {


     if(transform.position.x<player.position.x)
     {
    
      rb2d.velocity = new Vector3(movespeed,0);  
       //transform.eulerAngles= new Vector3(0,0,0);
      transform.eulerAngles = new Vector3(0,180,0);
      //isright=true;
        
     }
     else
     {
       // isright=false;
          //transform.eulerAngles= new Vector3(0,180,0);
          rb2d.velocity = new Vector3(-movespeed,0);
          transform.eulerAngles = new Vector3(0,0,0);    
     }
     }

    
    void SotpChase()
    {
       rb2d.velocity = new Vector3(0,0,0);
    }
    private void vecteorpos()
    {
    if(!ischase)
     {
          if(transform.position.x<player.position.x)
     {
    
 
    //  isright=true;
               transform.eulerAngles = new Vector3(0,180,0);
       vec=Vector3.right;
      
     }
     else
     {
     //   isleft=true;
   vec=Vector3.left;
     }
      }
      ischase=true;
      //yield return null;
    }
}
