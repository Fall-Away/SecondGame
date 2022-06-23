using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour
{
    
    [SerializeField] private GameObject _yeonEff;

    [SerializeField] private GameObject _gyeokEff;

    [SerializeField] private GameObject _wiEff;

    [SerializeField] private GameObject _heEff;

    [SerializeField] private GameObject _hwaEff;
    [SerializeField] private GameObject _paEff;
    [SerializeField] private GameObject _ryuEff;

    float coolTime;

    
    void Update()
    {
        coolTime += Time.deltaTime;

        Yeon();
        Hwa();
        Pa();
        Ryu();
    }

    void Yeon()
    {
        if (Input.GetKeyDown(KeyCode.Q) && coolTime >= 2)
        {
            Instantiate(_yeonEff, transform.position, Quaternion.identity);
            coolTime = 0;

            Debug.Log("연 - 격, 위, 해");
        }
    }
    void Hwa()
    {
        if (Input.GetKeyDown(KeyCode.W) && coolTime >= 2)
        {
            Instantiate(_hwaEff, transform.position, Quaternion.identity);
            coolTime = 0;
        }
    }
    void Pa()
    {
        if (Input.GetKeyDown(KeyCode.E) && coolTime >= 2)
        {
            Instantiate(_paEff, transform.position, Quaternion.identity);
            coolTime = 0;
        }
    }
    void Ryu()
    {
        if (Input.GetKeyDown(KeyCode.R) && coolTime >= 2)
        {
            Instantiate(_ryuEff, transform.position, Quaternion.identity);
            coolTime = 0;
        }
    }
}
