using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Cube : MonoBehaviour, IPointerClickHandler
{

    void Start()
    {
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("点击了物体！");
    }

}