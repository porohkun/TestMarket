using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[System.Serializable]
public class MarketItem
{
    public string ID;
    public string Name;
    public int Price;
    public Transform Model;

    public MarketContent Content { get; set; }
    public MarketButton Button { get; set; }
}
