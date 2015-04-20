using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GridLayoutCorrector : MonoBehaviour
{
    void Start()
    {
        var rectTr = GetComponent<RectTransform>();
        var grid = GetComponent<GridLayoutGroup>();
        float buttonSize = (rectTr.rect.height - grid.spacing.y) / 2;
        grid.cellSize = new Vector2(buttonSize, buttonSize);
    }
}
