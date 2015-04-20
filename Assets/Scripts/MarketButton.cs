using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MarketButton : MonoBehaviour
{
    public RawImage Image;
    public Text Name;
    public Text Price;

    private MarketItem Item;
    public void Initialize(MarketItem item)
    {
        Item = item;
        transform.name = item.Name;
        Name.text = item.Name;
        Price.text = string.Format("{0} ₽", item.Price);
    }

    public void Click()
    {
        FindObjectOfType<MarketManager>().BuyItem(Item);
    }
}
