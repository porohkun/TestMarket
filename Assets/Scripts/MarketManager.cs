using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class MarketManager: MonoBehaviour
{
    public CanvasGroup MarketMenu;
    public CanvasGroup MainMenu;
    public MenuManager MM;
    public RawImage ShowImage;
    public Text ShowName;

    public float OffsetStep = 10f;

    public MarketButton BtnPrefab;
    public MarketContent CntPrefab;
    public Transform Grid;

    public MarketItem[] MarketItems = new MarketItem[0];

    void Start()
    {
        int offset = 0;
        foreach (MarketItem item in MarketItems)
        {
            MarketContent content = (MarketContent)Instantiate(CntPrefab);
            content.transform.SetParent(transform);
            content.transform.localPosition = new Vector3(OffsetStep * offset++, 0f, 0f);
            content.transform.localRotation = Quaternion.Euler(Vector3.zero);
            content.Initialize(item);
            RenderTexture rt = new RenderTexture(256, 256, 32, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Default);
            content.Camera.targetTexture = rt;


            MarketButton button = (MarketButton)Instantiate(BtnPrefab);
            button.Initialize(item);
            button.transform.SetParent(Grid);
            button.Image.texture = rt;

            item.Content = content;
            item.Button = button;
        }
    }

    public void BuyItem(MarketItem item)
    {
        ShowImage.texture = item.Content.Camera.targetTexture;
        ShowName.text = item.Name;
        MM.HideMenu(MarketMenu);
        MM.ShowMenu(MainMenu);
    }
}
