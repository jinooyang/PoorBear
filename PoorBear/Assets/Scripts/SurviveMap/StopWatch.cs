using TMPro;
using UnityEngine;

namespace SurviveMap
{
   public class StopWatch : MonoBehaviour
   {
      [SerializeField] public TextMeshProUGUI timeText;

      private void Awake()
      {
         GameManager.TimeCheck += ShowTime;
      }
   
      private void ShowTime(float time)
      {
         timeText.text = $"{(int)time / 60} : {(int)time%60}";
      }
   }
}
