using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetingPanel : MonoBehaviour
{
    [SerializeField] private float _panelSpeed = 300f;

    private Vector3 _dir = Vector3.zero;
    private bool _panelMain = true;
    private bool _panelRight = false;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && _panelMain == true)
        {
            StartCoroutine(PanelMain());
            _panelMain = false;
        }
        if (Input.GetKeyDown(KeyCode.Escape) && _panelRight == true)
        {
            StartCoroutine(PanelRight());
            _panelRight = false;
        }
    }

    IEnumerator PanelMain()
    {
        _dir = Vector3.right;
        while (true)
        {
            transform.position += _dir * _panelSpeed * Time.deltaTime;
            if (transform.position.x >= 960)
            {
                _dir = Vector3.zero;
                StopCoroutine(PanelMain());
                _panelRight = true;
                break;
            }
            yield return null;
        }
    }

    IEnumerator PanelRight()
    {
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
