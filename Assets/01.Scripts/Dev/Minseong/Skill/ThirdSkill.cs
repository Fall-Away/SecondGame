using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdSkill : MonoBehaviour
{
    float coolTime;

    int selectedSK = 9;
    private void Start()
    {/*
        gameObject.GetComponentInChildren<GameObject>().SetActive(false);*/
    }
    void Update()
    {
        coolTime += Time.deltaTime;
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
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (selectedSK != 9) { return; }
            selectedSK = 0;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (selectedSK != 9) { return; }
            selectedSK = 1;
        }
    }
}
