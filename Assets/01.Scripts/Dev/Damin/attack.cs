using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    [SerializeField]private float destroyspeed;
    // Start is called before the first frame update
    void Start()
    {
    Invoke("destroy",destroyspeed);
    transform.eulerAngles= new Vector3(0,180,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void onTrigerEnter2D(Collider2D collision){
        
    }
    void destroy(){
        Destroy(gameObject);
    }
}
