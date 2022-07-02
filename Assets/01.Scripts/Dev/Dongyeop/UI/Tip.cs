using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tip : MonoBehaviour
{
    [SerializeField] private Text _tiptxt;

    private int _random = 0;

    private void Update()
    {
        switch(_random)
        {
            case 0:
                _tiptxt.GetComponent<Text>().text = " ";
                break;
            case 1:
                _tiptxt.GetComponent<Text>().text = "1";
                break;
            case 2:
                _tiptxt.GetComponent<Text>().text = "2";
                break;
            case 3:
                _tiptxt.GetComponent<Text>().text = "3";
                break;
            case 4:
                _tiptxt.GetComponent<Text>().text = "4";
                break;
            case 5:
                _tiptxt.GetComponent<Text>().text = "5";
                break;
            default:
                _tiptxt.GetComponent<Text>().text = " ";
                break;
        }

    }


    public void TipButton()
    {
        _random = Random.Range(1, 6);
        StopAllCoroutines();
        StartCoroutine(RandomReset());
    }

    IEnumerator RandomReset()
    {
        yield return new WaitForSeconds(5f);
        _random = 0;
    }
}
