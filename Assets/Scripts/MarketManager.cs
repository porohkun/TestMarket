using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class MarketManager: MonoBehaviour
{
    MarketItem[] Contents;

    public CanvasGroup MarketMenu;
    public CanvasGroup MainMenu;
    public MenuManager MM;
    public RawImage ShowImage;
    public Text ShowName;

    public float OffsetStep = 10f;
    public static Dictionary<string, Transform> Prefabs = new Dictionary<string, Transform>();

    public MarketButton BtnPrefab;
    public MarketContent CntPrefab;
    public Transform Grid;

    public Transform white_box;
    public Transform blue_box;
    public Transform green_box;
    public Transform red_box;
    public Transform white_cap;
    public Transform blue_cap;
    public Transform green_cap;
    public Transform red_cap;
    public Transform white_sphere;
    public Transform abstract1;
    public Transform abstract2;
    public Transform abstract3;
    public Transform abstract4;
    public Transform abstract5;
    public Transform abstract6;

    void Start()
    {
        LoadPrefabs();

        Contents = MarketItem.Load();

        int offset = 0;
        foreach (MarketItem item in Contents)
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

    void LoadPrefabs()
    {
        Prefabs.Add("white_box", white_box);
        Prefabs.Add("blue_box", blue_box);
        Prefabs.Add("green_box", green_box);
        Prefabs.Add("red_box", red_box);
        Prefabs.Add("white_cap", white_cap);
        Prefabs.Add("blue_cap", blue_cap);
        Prefabs.Add("green_cap", green_cap);
        Prefabs.Add("red_cap", red_cap);
        Prefabs.Add("white_sphere", white_sphere);
        Prefabs.Add("abstract1", abstract1);
        Prefabs.Add("abstract2", abstract2);
        Prefabs.Add("abstract3", abstract3);
        Prefabs.Add("abstract4", abstract4);
        Prefabs.Add("abstract5", abstract5);
        Prefabs.Add("abstract6", abstract6);
    }

    public void BuyItem(MarketItem item)
    {
        ShowImage.texture = item.Content.Camera.targetTexture;
        ShowName.text = item.Name;
        MM.HideMenu(MarketMenu);
        MM.ShowMenu(MainMenu);
    }
}
