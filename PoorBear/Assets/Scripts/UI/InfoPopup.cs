using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class InfoPopup : MonoBehaviour
{
    [SerializeField] public GameObject helpPopup;
    [SerializeField] public Button openBtn;
    
    public void OpenPopupUI()
    {
        helpPopup.SetActive(true);
        openBtn.gameObject.SetActive(false);
    }

    public void ClosePopupUI()
    {
        helpPopup.SetActive(false);
        openBtn.gameObject.SetActive(true);
    }
    
}
