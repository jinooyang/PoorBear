using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RankingData
{
    public string nickname;
    public string time;
    public string score;
    public string rank;

    public RankingData(string nickname, string time, string score, string rank)
    {
        this.nickname = nickname;
        this.time = time;
        this.score = score;
        this.rank = rank;
    }
}
