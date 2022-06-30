using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]private int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
           float hor =Input.GetAxis("Horizontal");
           Vector3 vec = new Vector3(hor,0,0);
           transform.position += speed * vec * Time.deltaTime;
    }
}
