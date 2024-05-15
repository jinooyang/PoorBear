using TMPro;
using UnityEngine;

public class LoadNickName : MonoBehaviour
{
    public TextMeshProUGUI UserNickNameText;

    void Start()
    {
        UserNickNameText.text = "닉네임: "+ PlayerPrefs.GetString("UserNickName");
    }
}
