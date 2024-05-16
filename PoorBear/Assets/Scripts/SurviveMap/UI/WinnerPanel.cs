
using System;
using TMPro;
using UnityEngine;

public class WinnerPanel : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI winner;

    private void OnDisable()
    {
        SetWinnerNickname("");
    }

    public void SetWinnerNickname(string nickname)
    {
        winner.text = nickname;
    }
}
