using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class OpenSubmenuAdd : MonoBehaviour
{

  public Button button;
  public GameObject window;
  public GameObject windowClose1;
  public GameObject windowClose2;
  public GameObject windowClose3;
  public GameObject windowClose4;
  public GameObject windowClose5;
  public GameObject windowClose6;
  public GameObject blocker;
    // Start is called before the first frame update
    void Start()
    {
      Button btn = button.GetComponent<Button>();
      btn.onClick.AddListener(TaskOnClick);
      RectTransform transf = window.GetComponent<RectTransform>();
      transf.localScale = new Vector3(0,1,1);

      Button btnb = blocker.GetComponent<Button>();
      btnb.onClick.AddListener(TaskOnClickBlocker);
    }

    void TaskOnClick()
    {
        RectTransform transf1 = windowClose1.GetComponent<RectTransform>();
        transf1.localScale = new Vector3(0,1,1);
        RectTransform transf2 = windowClose2.GetComponent<RectTransform>();
        transf2.localScale = new Vector3(0,1,1);
        RectTransform transf3 = windowClose3.GetComponent<RectTransform>();
        transf3.localScale = new Vector3(0,1,1);
        RectTransform transf4 = windowClose4.GetComponent<RectTransform>();
        transf4.localScale = new Vector3(0,1,1);
        RectTransform transf5 = windowClose5.GetComponent<RectTransform>();
        transf5.localScale = new Vector3(0,1,1);
        RectTransform transf6 = windowClose6.GetComponent<RectTransform>();
        transf6.localScale = new Vector3(0,1,1);
        RectTransform transf = window.GetComponent<RectTransform>();
        transf.localScale = new Vector3(1,1,1);
        RectTransform transfb = blocker.GetComponent<RectTransform>();
        transfb.localScale = new Vector3(1,1,1);

    }

    void TaskOnClickBlocker()
    {
        RectTransform transf = window.GetComponent<RectTransform>();
        transf.localScale = new Vector3(0,1,1);
    }
}
