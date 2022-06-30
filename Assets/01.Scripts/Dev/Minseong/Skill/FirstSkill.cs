using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstSkill : MonoBehaviour
{
    [SerializeField] SecondSkill yeon;
    [SerializeField] SecondSkill hwa;
    [SerializeField] SecondSkill pa;
    [SerializeField] SecondSkill ryu;

    [SerializeField] GameObject skill1;
    [SerializeField] GameObject skill2;
    [SerializeField] GameObject skill3;
    [SerializeField] GameObject skill4;

    [SerializeField] Public time;

    int selectedSK = 9;

    bool chain = false;
    private void Start()
    {
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
        if (chain)
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
            if (selectedSK == 3 && Input.GetKeyDown(KeyCode.Q) && time.time >= 2.5)
            {
                Instantiate(skill4, transform.position, Quaternion.identity);
                time.ResetTime();
            }
        }
        if (!chain)
        {
            if (Input.GetKeyDown(KeyCode.Q) && time.time >= 2.5)
            {
                Instantiate(skill1, transform.position, Quaternion.identity);
                selectedSK = 0;
                chain = true;
                Debug.Log("yeon");
            }
        }
        if (!chain)
        {
            if (Input.GetKeyDown(KeyCode.W) && time.time >= 2.5)
            {
                Instantiate(skill2, transform.position, Quaternion.identity);
                selectedSK = 1;
                chain = true;
            }
        }
        if (!chain)
        {
            if (Input.GetKeyDown(KeyCode.E) && time.time >= 2.5)
            {
                Instantiate(skill3, transform.position, Quaternion.identity);
                selectedSK = 2;
                chain = true;
            }
        }
        if (!chain)
        {
            if (Input.GetKeyDown(KeyCode.R) && time.time >= 2.5)
            {
                Instantiate(skill4, transform.position, Quaternion.identity);
                selectedSK = 3;
                chain = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            chain = false;
            yeon.chain = false;
            hwa.chain = false;
            pa.chain = false;
            ryu.chain = false;

            yeon.selectedSK = 3;
            hwa.selectedSK = 3;
            pa.selectedSK = 3;
            ryu.selectedSK = 3;
            
            Debug.Log("enter");
            selectedSK = 4;
            time.ResetTime();
        }

    }
}
