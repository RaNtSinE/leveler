using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Window : MonoBehaviour
{
    public Button button;
    public GameObject submenu;
    public Button outSide;
    public GameObject content;

    void Start ()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        RectTransform transf = submenu.GetComponent<RectTransform>();
        transf.localScale = new Vector3(1,0,1);
        Image img = outSide.GetComponent<Image>();
        img.raycastTarget = false;
        Button otsd = outSide.GetComponent<Button>();
        otsd.onClick.AddListener(CloseWindow);
        Button [] list = content.GetComponents<Button>();
        for (int i = 0; i < list.Length; i++)
          list[i].onClick.AddListener(CloseWindow);
    }

    void TaskOnClick()
    {
        RectTransform transf = submenu.GetComponent<RectTransform>();
        transf.localScale = new Vector3(1,1,1);
        transf.SetAsLastSibling();
        Image img = outSide.GetComponent<Image>();
        img.raycastTarget = true;
    }

    void CloseWindow()
    {
      RectTransform transf = submenu.GetComponent<RectTransform>();
      transf.localScale = new Vector3(1,0,1);
      Image img = outSide.GetComponent<Image>();
      img.raycastTarget = false;
    }
}
