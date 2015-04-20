using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuManager : MonoBehaviour
{
    public void ShowMenu(CanvasGroup menu)
    {
        menu.blocksRaycasts = true;
        menu.interactable = true;
        menu.alpha = 1;
    }

    public void HideMenu(CanvasGroup menu)
    {
        menu.alpha = 0;
        menu.interactable = false;
        menu.blocksRaycasts = false;
    }
}
