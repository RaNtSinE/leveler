using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ContextMenu : MonoBehaviour, IPointerExitHandler, IPointerEnterHandler
{

  public GameObject submenu;
  // public Button button;

    private bool hasFocus = false;
    public GameObject submenu1;
    public RectTransform cv;
    private bool scheduleShow = false;

    // Start is called before the first frame update
    void Start()
    {
      // Button btn = button.GetComponent<Button>();
      cv = submenu1.GetComponent<RectTransform>();
      // btn.onClick.AddListener(TaskOnClick);
      Button subbtn = submenu.GetComponent<Button>();
      subbtn.onClick.AddListener(TaskOnClick);
      RectTransform transf = submenu.GetComponent<RectTransform>();
      cv.localScale = new Vector3(1,0,1);
    }

    void TaskOnClick()
    {
        RectTransform transf = submenu.GetComponent<RectTransform>();
        Show();
    }

    // Update is called once per frame
    public void Update()
    {
        if (!scheduleShow && !hasFocus)
        {
          if (Input.GetMouseButtonUp(0))
          {
            cv.localScale = new Vector3(1,0,1);
          }
        } else if (scheduleShow)
        {
          cv.localScale = new Vector3(1,1,1);
          scheduleShow = false;
        }
    }

    public void Show()
    {
      scheduleShow = true;
    }

    public void Hide()
    {
      scheduleShow = false;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
      hasFocus = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
      hasFocus = true;
    }
}
