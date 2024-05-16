using System.Collections;
using System.Collections.Generic;
using UI;
using UnityEngine;

public class MainUIScreen : MonoBehaviour
{
    void Awake()
    {
        AudioManager.instance.PlayBgm(true);
        if (PlayerManager.Instance.UserNickname == null) UIScreen.Focus(GetComponent<UIScreen>());
        else gameObject.SetActive(false);
    }
}
