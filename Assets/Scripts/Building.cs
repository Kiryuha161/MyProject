using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Academia : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    [SerializeField] [TextArea] private string _description;
    [SerializeField] private TextMeshProUGUI _descriptionText;
    private bool _isActivePanel = false;

    //�������� - ��� ��������� ��� �������� ����� � ������� ��������� ������ � ��������, � ����� ������� ���� ��� ������������� �����.

    // Start is called before the first frame update
    void Start()
    {
        _descriptionText.text = _description;
    }
        
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        _isActivePanel = !_isActivePanel;
        _panel.SetActive(_isActivePanel);
    }
}

