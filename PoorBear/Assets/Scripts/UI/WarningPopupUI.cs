using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WarningPopupUI : MonoBehaviour
{

    public TextMeshProUGUI warningMsg;
    public void CloseThisPopup()
    { 
        gameObject.SetActive(false);
    }

    public void OpenThisPopup()
    {
        gameObject.SetActive(true);
    }

    public void SetWarningMsg(string text)
    {
        warningMsg.text = text;
    }
}
