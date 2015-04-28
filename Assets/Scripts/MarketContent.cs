using UnityEngine;
using System.Collections;

public class MarketContent : MonoBehaviour
{
    public Camera Camera;
    public Transform ContentObject;

    private MarketItem Item;

    public void Initialize(MarketItem item)
    {
        Item = item;
        transform.name = item.Name;
        Transform content = (Transform)Instantiate(item.Model);
        content.SetParent(ContentObject);
        content.localPosition = Vector3.zero;
        ContentObject.gameObject.AddComponent<Rotor>();
    }
}
