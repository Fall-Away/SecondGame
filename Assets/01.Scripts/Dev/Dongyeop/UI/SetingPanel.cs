using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetingPanel : MonoBehaviour //ESC�� �������� ������ �г��� �����̴ϴ�
{
    [SerializeField] private float _panelSpeed = 300f;

    [SerializeField] private GameObject _bgm_Check;
    [SerializeField] private GameObject _soundeffect_Check;

    private Vector3 _dir = Vector3.zero;

    private bool _panelMain = true;
    private bool _bgmCheck = false;
    private bool _soundeffectCheck = false;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && _panelMain == true)
            StartCoroutine(PanelMain());
        if (Input.GetKeyDown(KeyCode.Escape) && _panelMain == false)
            StartCoroutine(PanelRight());

        _bgm_Check.SetActive(_bgmCheck);
        _soundeffect_Check.SetActive(_soundeffectCheck);
    }


    public void ExitButtonDown() // ��ư��
    {
        StartCoroutine(PanelRight());
    }

    public void BGM_Mute()
    {
        _bgmCheck = !_bgmCheck;
    }
    public void SoundEffect_Mute()
    {
        _soundeffectCheck = !_soundeffectCheck;
    }



    IEnumerator PanelMain() //panel�� �߾����� ������ �ϴ� ��ũ��Ʈ
    {
        _dir = Vector3.right;
        while (true)
        {
            transform.position += _dir * _panelSpeed * Time.deltaTime;
            if (transform.position.x >= 960)
            {
                _dir = Vector3.zero;
                StopCoroutine(PanelMain());
                Time.timeScale = 1;
                _panelMain = false;
                break;
            }
            yield return null;
        }
    }

    IEnumerator PanelRight() //panel�� �߾ӿ��� ���������� ���� ��ũ��Ʈ
    {
        Time.timeScale = 1;
        _dir = Vector3.right;
        while (true)
        {
            transform.position += _dir * _panelSpeed * Time.deltaTime;
            if (transform.position.x >= 3500)
            {
                _dir = Vector3.zero;
                StopCoroutine(PanelRight());
                gameObject.transform.position = new Vector3(-1200, 540, 0);
                _panelMain = true;
                break;
            }
            yield return null;
        }
    }
}
