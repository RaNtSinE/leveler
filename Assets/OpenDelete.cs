using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class OpenDelete : MonoBehaviour
{

  public Button button;
  public GameObject window;
  public GameObject submenu;
  public GameObject blocker;
    // Start is called before the first frame update
    void Start()
    {
      Button btn = button.GetComponent<Button>();
      btn.onClick.AddListener(TaskOnClick);
      RectTransform transf = window.GetComponent<RectTransform>();
      transf.localScale = new Vector3(0,1,1);
    }

    void TaskOnClick()
    {
        RectTransform transf = window.GetComponent<RectTransform>();
        transf.localScale = new Vector3(1,1,1);
        RectTransform transfs = submenu.GetComponent<RectTransform>();
        transfs.localScale = new Vector3(0,1,1);
        RectTransform transfb = blocker.GetComponent<RectTransform>();
        transfb.localScale = new Vector3(0,1,1);
    }
}
