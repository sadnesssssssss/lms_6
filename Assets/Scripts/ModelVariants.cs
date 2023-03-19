using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ModelVariants : MonoBehaviour
{

    [SerializeField] public GameObject[] _models;
    private GameObject _currentSelected;
    [SerializeField] private TMP_Dropdown _dropdown;

    private void Start()
    {
        _currentSelected = _models[0];

        List<TMP_Dropdown.OptionData> _optionDataList = new List<TMP_Dropdown.OptionData>();
        foreach (var item in _models)
        {
            TMP_Dropdown.OptionData data = new TMP_Dropdown.OptionData();
            data.text = item.name;
            _optionDataList.Add(data);
        }
        _dropdown.options = _optionDataList;

        _dropdown.onValueChanged.AddListener(Select);

    }

    public void Select(int index) {
        _currentSelected.SetActive(false);
        _currentSelected = _models[index];
        _currentSelected.SetActive(true);
    }


}
