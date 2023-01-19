using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GemTriggerController : MonoBehaviour
{
    [SerializeField] private DiamondManager _diamondManager;
    [SerializeField] private int _diamondValue;
    [SerializeField] public TextMeshPro _diamondValueText;


    private void Start()
    {
        _diamondManager = GameObject.Find("GameRoot/DiamondManager").GetComponent<DiamondManager>();
        TextManagement();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            collectDiamond(_diamondValue);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            relaeseDiamond();
        }
    }

    private void collectDiamond(int amount)
    {
        _diamondManager.generalDiamondValue = amount;
    }

    private void relaeseDiamond()
    {
        _diamondManager.generalDiamondValue = 0;
    }

    private void TextManagement()
    {
        _diamondValueText.text = _diamondValue.ToString();
    }

}