using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Academy : Building
{
    // Start is called before the first frame update
    void Start()
    {
        Description();
        
    }

    protected override void Description()
    {

        _description = "�������� - ��� ��������� ��� �������� ����� � ������� ��������� ������ � ��������, � ����� ������� ���� ��� ������������� �����.";
        base.Description();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
