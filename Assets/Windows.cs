using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Windows : MonoBehaviour
{

  public Button button;
  public GameObject submenu;

    // Start is called before the first frame update
    void Start()
    {
      Button btn = button.GetComponent<Button>();
      btn.onClick.AddListener(TaskOnClick);
      RectTransform transf = submenu.GetComponent<RectTransform>();
      button.GetComponent<ContextMenu>().Hide();
    }

    void TaskOnClick()
    {
        RectTransform transf = submenu.GetComponent<RectTransform>();
        button.GetComponent<ContextMenu>().Show();
    }

}
