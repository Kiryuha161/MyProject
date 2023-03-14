using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Building : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    private bool _isActivePanel = false;
    [SerializeField] [TextArea] protected string _description;
    [SerializeField] protected TextMeshProUGUI _descriptionText;

    

    // Start is called before the first frame update
    void Start()
    {
        Description();
    }

    protected virtual void Description()
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
