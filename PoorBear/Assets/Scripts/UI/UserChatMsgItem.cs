using System.Text;
using TMPro;
using UnityEngine;

public class UserChatMsgItem : MonoBehaviour
{
    public TextMeshProUGUI userNickName;
    public TextMeshProUGUI message;
    
    public void Setup(UserChatData data)
    {
        userNickName.text = new StringBuilder().Append(data.userNickname).Append(":").ToString();
        message.text = data.message;
    }
}
