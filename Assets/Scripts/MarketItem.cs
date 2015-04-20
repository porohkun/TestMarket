using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class MarketItem
{
    public string Name;
    public int Price;
    public string Model;

    public MarketContent Content;
    public MarketButton Button;

    private MarketItem()
    {

    }
    public static MarketItem[] Load()
    {
        return new MarketItem[15]
        {
            new MarketItem()
            {
                Name = "Белый ящик",
                Price = 15,
                Model = "white_box"
            },
            new MarketItem()
            {
                Name = "Синий бокс",
                Price = 23,
                Model = "blue_box"
            },
            new MarketItem()
            {
                Name = "Белошар",
                Price = 37,
                Model = "white_sphere"
            },
            new MarketItem()
            {
                Name = "Зелен короб",
                Price = 11,
                Model = "green_box"
            },
            new MarketItem()
            {
                Name = "Белая табла",
                Price = 28,
                Model = "white_cap"
            },
            new MarketItem()
            {
                Name = "Синяя таблетка",
                Price = 14,
                Model = "blue_cap"
            },
            new MarketItem()
            {
                Name = "Красная капсула",
                Price = 34,
                Model = "red_cap"
            },
            new MarketItem()
            {
                Name = "Зелен горох",
                Price = 75,
                Model = "green_cap"
            },
            new MarketItem()
            {
                Name = "Штучка",
                Price = 31,
                Model = "abstract1"
            },
            new MarketItem()
            {
                Name = "Фигень",
                Price = 19,
                Model = "abstract2"
            },
            new MarketItem()
            {
                Name = "Красный куб",
                Price = 8,
                Model = "red_box"
            },
            new MarketItem()
            {
                Name = "Абзац",
                Price = 22,
                Model = "abstract3"
            },
            new MarketItem()
            {
                Name = "Штуковина",
                Price = 64,
                Model = "abstract4"
            },
            new MarketItem()
            {
                Name = "Непонятка",
                Price = 48,
                Model = "abstract5"
            },
            new MarketItem()
            {
                Name = "Шуршурка",
                Price = 100,
                Model = "abstract6"
            }
        };
    }
}
