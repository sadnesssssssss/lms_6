using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _fieldName;
    [SerializeField] private TextMeshProUGUI _inputFieldName;
    
    
    public void OnButtonClick()
    {
        _fieldName.text = _inputFieldName.text;
    }
}
