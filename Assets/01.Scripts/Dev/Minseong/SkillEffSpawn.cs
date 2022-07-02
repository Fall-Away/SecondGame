using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillEffSpawn : MonoBehaviour
{
    [SerializeField] GameObject SkillEff;
    void Start()
    {
        
    }

    void Update()
    {
        Spawn();
    }
    public void Spawn()
    {
        Instantiate(SkillEff, transform.position, Quaternion.identity);
    }
}
