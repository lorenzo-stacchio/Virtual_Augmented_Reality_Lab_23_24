using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>Controls the collection of the mushrooms</summary>
[RequireComponent(typeof(Collider))]
public class MushroomController : MonoBehaviour
{

    public void Collect(BaseEventData eventData)
    {
        GameManager.collect_mushroom();
        Destroy(gameObject);

    }

}

