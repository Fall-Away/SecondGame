using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bcb : MonoBehaviour
{
    [SerializeField]GameObject hitpos;
    [SerializeField]private float speed;
    bool isleft= true;
    Rigidbody2D rigd;
    int nextmove=2;
    void Start()
    {
        rigd=GetComponent<Rigidbody2D>();
    }

    void Update()
    {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        Vector2 forntvec = new Vector2(rigd.position.x-nextmove,rigd.velocity.y-15);
        // Vector2 forntvec = new Vector2(hitpos.y,.velocity.y-15);
    Debug.DrawRay(forntvec,Vector3.down, new Color(0,1,0));
    RaycastHit2D rayhit = Physics2D.Raycast(forntvec,Vector3.down,1,LayerMask.GetMask("Ground"));
    if(rayhit.collider == null)
    {
        if(isleft)
        {
            nextmove = -2;
            transform.eulerAngles = new Vector3(0,180,0);
            isleft = false;
        }
        else
        {
            nextmove = 2;
            transform.eulerAngles = new Vector3(0,0,0);
            isleft = true;  
        }
Debug.Log("낭떠러지");
    }
    }
    void FixedUpdate()
    {
    
    }
}
