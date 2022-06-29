using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstSkill : MonoBehaviour
{
    float coolTime;

    int selectedSK = 9;

    bool chain = false;
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
        if (!chain)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                if (selectedSK != 9) { return; }
                selectedSK = 0;
                chain = true;
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                if (selectedSK != 9) { return; }
                selectedSK = 1;
                chain = true;
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (selectedSK != 9) { return; }
                selectedSK = 2;
                chain = true;
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                if (selectedSK != 9) { return; }
                selectedSK = 3;
                chain = true;
            }
        }
    }
}
