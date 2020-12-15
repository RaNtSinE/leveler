using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Open : MonoBehaviour
{

  public Button button;
  public GameObject window;
    // Start is called before the first frame update
    void Start()
    {
      Button btn = button.GetComponent<Button>();
      btn.onClick.AddListener(TaskOnClick);
      RectTransform transf = window.GetComponent<RectTransform>();
      transf.localScale = new Vector3(1,0,1);
    }

    void TaskOnClick()
    {
        RectTransform transf = window.GetComponent<RectTransform>();
        transf.localScale = new Vector3(1,1,1);
    }
}
