using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour
{
    float coolTime;

    public int selectedSK = 9;
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
        if (Input.GetKeyDown(KeyCode.Q)) { if (selectedSK != 9) { return; } selectedSK = 0;  }
        if (Input.GetKeyDown(KeyCode.W)) { if (selectedSK != 9) { return; } selectedSK = 1; }
        if (Input.GetKeyDown(KeyCode.E)) { if (selectedSK != 9) { return; } selectedSK = 2; }
        if (Input.GetKeyDown(KeyCode.R)) { if (selectedSK != 9) { return; } selectedSK = 3; }
    }
}
