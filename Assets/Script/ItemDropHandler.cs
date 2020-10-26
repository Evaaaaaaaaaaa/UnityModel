using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDropHandler : MonoBehaviour, IDropHandler
{
    public GameObject icon; 
    public GameObject model;
    public void OnDrop(PointerEventData eventData){
        RectTransform invPanel = transform as RectTransform;
        if (!RectTransformUtility.RectangleContainsScreenPoint(invPanel, Input.mousePosition)){
            Debug.Log("Drap item");
            //transform.localPosition = Vector3.zero; 
            model.SetActive(!model.activeInHierarchy);
        }

    }

    public void update(){

    }
    
}
