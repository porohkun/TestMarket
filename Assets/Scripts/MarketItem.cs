using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PNetJson;

public class MarketItem
{
    public string Name;
    public int Price;
    public string Model;

    public MarketContent Content;
    public MarketButton Button;

    private MarketItem(JSONValue item)
    {
        Name = item["name"];
        Price = item["price"];
        Model = item["model"];
    }

    public static MarketItem[] Load(JSONArray array)
    {
        MarketItem[] items = new MarketItem[array.Length];
        for (int i=0;i<array.Length;i++)
        {
            items[i] = new MarketItem(array[i]);
        }
        return items;
    }
}
