using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using TMPro;
using UnityEngine;

public class StopWatch : MonoBehaviour
{
   [SerializeField] public TextMeshProUGUI timeText;

   private void Awake()
   {
      GameManager.TimeCheck += ShowTime;
   }

   private void ShowTime(float time)
   {
      timeText.text = $"{(int)time / 60} : {(int)time}";
   }
}
