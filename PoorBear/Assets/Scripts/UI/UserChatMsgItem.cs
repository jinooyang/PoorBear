using System;
using System.Text;
using Fusion;
using TMPro;
using UnityEngine;

public class UserChatMsgItem : MonoBehaviour
{
    public TextMeshProUGUI userNickName;
    public TextMeshProUGUI message;
    

    public void Setup(string msg)
    {
        var splitIndex = msg.IndexOf(":", 0, StringComparison.Ordinal);
        userNickName.text = msg[..splitIndex];
        message.text = msg[(splitIndex+1)..];
    }
}
