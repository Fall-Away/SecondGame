using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
     [SerializeField]
    Transform player;

    [SerializeField]
    float agroRange;

    [SerializeField]
    float movespeed;
    int rnadomwait; 
    Rigidbody2D rb2d;
    public float distoplayer;
    public GameObject enemyBullet;
    public float attackdistance;
   public Transform bullettr;
   [SerializeField]
   private float currenttime;
   [SerializeField]
   private float creattime;
   [SerializeField]private float reroledtime;
   float reoledwiat;
  
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
       rnadomwait= Random.Range(1,3);
    }

    // Update is called once per frame
    void Update()
    {
       
       reoledwiat+=Time.deltaTime;
        currenttime+=Time.deltaTime;
         distoplayer = Vector2.Distance(transform.position,player.position);
        if(distoplayer<agroRange)
        {
          ChasePlayer(); 
        }
        else
        {
         SotpChase();
        }

        if(distoplayer<attackdistance)
        {
if(currenttime>creattime){
    reroledtime=0;
if(reoledwiat<reoledwiat){
   StartCoroutine("shot");
}

}
else{
    StopCoroutine("shot");
}
        }
        else
        {
            //ChasePlayer();
        }
    }
    void ChasePlayer()
    {
     if(transform.position.x<player.position.x)
     {
      rb2d.velocity = new Vector3(movespeed,0);  
       //transform.eulerAngles= new Vector3(0,0,0);
      transform.eulerAngles = new Vector3(0,180,0);       
     }
     else
     {
          //transform.eulerAngles= new Vector3(0,180,0);
          rb2d.velocity = new Vector3(-movespeed,0);
          transform.eulerAngles = new Vector3(0,0,0);    
     }

    }
    void SotpChase()
    {
       rb2d.velocity = new Vector3(0,0,0);
    }
    private IEnumerator shot()
    {
        SotpChase();
        yield return new WaitForSeconds(reroledtime);
            
        Instantiate(enemyBullet, bullettr.transform.position,transform.rotation);
        currenttime=0;
        yield return new WaitForSeconds(0.5f);
    }
    void shotnoco(){
            SotpChase();
      
            reroledtime=0;
        Instantiate(enemyBullet, bullettr.transform.position,transform.rotation);
        currenttime=0;
      
    }
}
