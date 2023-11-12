using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dropzone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public List<dropzone> droparea = new List<dropzone>();
    
    //SETS CONDITION BASED ON TYPE; public draggingtime.Slot typeOfCard = draggingtime.Slot.neutral;

    public void OnPointerEnter(PointerEventData eventData)
    {
       // Debug.Log("on");
    }
    public void OnPointerExit(PointerEventData eventData)
    {
       // Debug.Log("on");
    }

    public void OnDrop(PointerEventData eventData)
    {
       //we need to change condition for card drop to be if card cost <= availablecost -- based on card database
       draggingtime d = eventData.pointerDrag.GetComponent<draggingtime>();
       d.parentToReturnTo = this.transform;

        if (gameObject.name == "Drop area")
        {
            //playarea.playzone.Add(this);
            droparea.Add(this);
        }
        //else do not add or maybe remove

        // SETS CONDITION BASED ON TYPE: if(typeOfCard == d.typeOfCard || typeOfCard == draggingtime.Slot.neutral)
    }
}
//trying to get rid of this from droparea and hand