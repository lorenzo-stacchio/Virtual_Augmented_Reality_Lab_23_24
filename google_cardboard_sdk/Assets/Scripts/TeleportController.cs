using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>Controls interactable teleporting objects in the Demo scene.</summary>
[RequireComponent(typeof (Collider))]
public class TeleportController : MonoBehaviour
{
    public void Teleport(BaseEventData eventData)
    {
        // Only trigger on left input button, which maps to
        // Daydream controller TouchPadButton and Trigger buttons.
        PointerEventData ped = eventData as PointerEventData;
        if (ped != null)
        {
            if (ped.button != PointerEventData.InputButton.Left)
            {
                return;
            }
        }

        // Get the position the raycast intersect with!
        Vector3 intersection_position = ped.pointerPressRaycast.worldPosition;
        GameObject player = GameObject.Find("Royal_Hog");

        //Just move along x and z axis!
        player.transform.position =
            new Vector3(intersection_position.x,
                player.transform.position.y,
                intersection_position.z);
    }
}
