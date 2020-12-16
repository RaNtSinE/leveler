using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MainSelect : MonoBehaviour, ISelectHandler, IDeselectHandler, IPointerEnterHandler, IPointerExitHandler
{

    public GameObject edit;
    public GameObject tutorial;
    public Toggle firstSelect;
    public Toggle select;
    public RectTransform open;
    public RectTransform close1;
    public RectTransform close2;
    public Text title;
    public Sprite sprite1;
    public Sprite sprite2;
    Image m_Image;


    void Start()
    {
      m_Image = edit.GetComponent<Image>();
      tutorial.GetComponent<Selectable>().Select();
      firstSelect.isOn = true;
    }

    public void OnSelect(BaseEventData eventData)
    {
        this.gameObject.GetComponentInChildren<Text>().color = new Color(0.03F, 0.27F, 0.58F);
        m_Image.sprite = sprite2;
        title.text = this.gameObject.GetComponentInChildren<Text>().text;
        select.isOn = true;
        open.localScale = new Vector3(1,1,1);
        close1.localScale = new Vector3(0,1,1);
        close2.localScale = new Vector3(0,1,1);
    }

    public void OnDeselect(BaseEventData eventData)
    {
        this.gameObject.GetComponentInChildren<Text>().color = Color.black;
        m_Image.sprite = sprite1;
        select.isOn = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        this.gameObject.GetComponentInChildren<Text>().color = new Color(0.03F, 0.27F, 0.58F);
        m_Image.sprite = sprite2;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (select.isOn == false)
        {
          this.gameObject.GetComponentInChildren<Text>().color = Color.black;
          m_Image.sprite = sprite1;
        }
    }
}
