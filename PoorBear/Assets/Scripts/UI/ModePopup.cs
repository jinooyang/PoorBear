using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModePopup : MonoBehaviour
{
    [SerializeField] public GameObject popUpUI;

    public void OpenPopup()
    {
        popUpUI.SetActive(true);
    }

    public void ClosePopup()
    {
        popUpUI.SetActive(false);
    }
}
