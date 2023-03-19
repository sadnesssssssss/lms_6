
using TMPro;
using UnityEngine;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _fieldName;
    [SerializeField] private TextMeshProUGUI _inputFieldName;
    
    
    public void OnButtonClick()
    {
        _fieldName.text = _inputFieldName.text;
    }
}
