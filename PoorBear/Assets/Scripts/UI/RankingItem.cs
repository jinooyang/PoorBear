using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RankingItem : MonoBehaviour
{
    public TextMeshProUGUI nickname;
    public TextMeshProUGUI time;
    public TextMeshProUGUI score;
    public Image rankPanel;
    public TextMeshProUGUI rank;

    public void Setup(RankingData data)
    {
        nickname.text = data.nickname;
        time.text = data.time;
        score.text = data.score;
        rank.text = data.rank;
    }
}
