using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondSkill : MonoBehaviour
{
    [SerializeField] GameObject skill1;
    [SerializeField] GameObject skill2;
    [SerializeField] GameObject skill3;

    [SerializeField] Public time;
    public int selectedSK = 9;

    public bool chain = false;
    private void Start()
    {/*
        gameObject.GetComponentInChildren<GameObject>().SetActive(false);*/
        selectedSK = 3;
    }
    void Update()
    {
        SwitchingBullet();
        SelectSkill();
    }
    public void SelectSkill()
    {
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == selectedSK) { weapon.gameObject.SetActive(true); }
            else { weapon.gameObject.SetActive(false); }
            i++;
        }
    }
    void SwitchingBullet()
    {
        
            if (selectedSK == 0 && Input.GetKeyDown(KeyCode.Q) && time.time >= 2.5)
            {
                Instantiate(skill1, transform.position, Quaternion.identity);
                time.ResetTime();
            }
            if (selectedSK == 1 && Input.GetKeyDown(KeyCode.Q) && time.time >= 2.5)
            {
                Instantiate(skill2, transform.position, Quaternion.identity);
                time.ResetTime();
            }
            if (selectedSK == 2 && Input.GetKeyDown(KeyCode.Q) && time.time >= 2.5)
            {
                Instantiate(skill3, transform.position, Quaternion.identity);
                time.ResetTime();
            }
        if (!chain)
        {
            if (Input.GetKeyDown(KeyCode.W) && time.time >= 2.5)
            {
                Instantiate(skill1, transform.position, Quaternion.identity);
                selectedSK = 0;
                chain = true;
            }
        }
        if (!chain)
        {
            if (Input.GetKeyDown(KeyCode.E) && time.time >= 2.5)
            {
                Instantiate(skill2, transform.position, Quaternion.identity);
                selectedSK = 1;
                chain = true;
            }
        }
        if (!chain)
        {
            if (Input.GetKeyDown(KeyCode.R) && time.time >= 2.5)
            {
                Instantiate(skill3, transform.position, Quaternion.identity);
                selectedSK = 2;
                chain = true;
            }
        }
        
    }
}
