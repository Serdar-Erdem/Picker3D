using Controllers.Player;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DiamondManager : MonoBehaviour
{
    [SerializeField] public int generalDiamondValue;
    [SerializeField] private TextMeshProUGUI generalDiamondValueText;
    [SerializeField] private PlayerMovementController _playerMovementController;

    private void Start()
    {
        _playerMovementController = GameObject.Find("GameRoot/LevelHolder/level0(Clone)/PlayerManager").GetComponent<PlayerMovementController>();
    }

    private void Update()
    {
        GameFinishControl();
    }

    private void GameFinishControl()
    {
        if (_playerMovementController._totalScore <= 0)
        {
            GeneralTextManagement();
        }
    }
    private void GeneralTextManagement()
    {
        generalDiamondValueText.text = generalDiamondValue.ToString();
    }
}
