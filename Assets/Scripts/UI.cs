using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;
//using UnityEngine.UIElements;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] GameObject scroll;
    bool isButtonEnabled;

    private void Start()
    {
        isButtonEnabled = false;
        gameObject.GetComponent<Button>().onClick.AddListener(TurnOnAndOff);
        scroll.SetActive(isButtonEnabled);
    }

    void TurnOnAndOff()
    {
        isButtonEnabled ^= true;
        scroll.SetActive(isButtonEnabled);

    }

}
