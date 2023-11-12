using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class draggingtime : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
//this is all just drag stuff and can be ignored

    public Transform parentToReturnTo = null;
   

    //Old code to set card type as influence:
    //public enum Slot {inspire, devote, monster, neutral};
    //public Slot typeOfCard = Slot.devote;

    public void OnBeginDrag(PointerEventData eventData)
    {
        parentToReturnTo = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent);

        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        this.transform.SetParent(parentToReturnTo);

        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}
