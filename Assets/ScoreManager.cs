// Yan
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private TextMeshPro textMeshPro;

    private void Awake()
    {
        textMeshPro = GetComponent<TextMeshPro>();
        int comboCount = 0;
    }

    private void SetComboCount(int comboCount)
    {
        textMeshPro.SetText(comboCount.ToString());
    }

    string StyleConvert(int i)
    {
        return i switch
        {
            0 => "D",
            1 => "C",
            2 => "B",
            3 => "A",
            4 => "S",
            _ => "X",
        };
    }
}
