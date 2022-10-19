//-----------------------------------------------------------------------
// <copyright file="ObjectController.cs" company="Google Inc.">
// Copyright 2014 Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//-----------------------------------------------------------------------

using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>Controls interactable teleporting objects in the Demo scene.</summary>
[RequireComponent(typeof(Collider))]
public class TeleportController : MonoBehaviour
{

    /// <summary>Calls the Recenter event.</summary>
    public void Recenter()
    {
#if !UNITY_EDITOR
        GvrCardboardHelpers.Recenter();
#else
            if (GvrEditorEmulator.Instance != null)
            {
                GvrEditorEmulator.Instance.Recenter();
            }
#endif  // !UNITY_EDITOR
    }

  
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

        Vector3 temp = ped.pointerPressRaycast.worldPosition;
        UnityEngine.Debug.Log("OnBeginDrag: " + temp);
        GameObject player = GameObject.Find("Royal_Hog");
        player.transform.position = new Vector3(temp.x, player.transform.position.y, temp.z);
        
    }

    



}

