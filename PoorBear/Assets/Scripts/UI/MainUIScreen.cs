using System.Collections;
using System.Collections.Generic;
using UI;
using UnityEngine;

public class MainUIScreen : MonoBehaviour
{
    void Awake()
    {
        AudioManager.instance.PlayBgm(true);
        UIScreen.Focus(GetComponent<UIScreen>());
    }
}
