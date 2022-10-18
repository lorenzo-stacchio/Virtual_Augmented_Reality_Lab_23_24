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
public class MushroomController : MonoBehaviour
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

    /// <summary>Teleport this instance randomly when triggered by a pointer click.</summary>
    /// <param name="eventData">The pointer click event which triggered this call.</param>
    /// 
    public void Collect(BaseEventData eventData)
    {
        WoodMan.instance.collect_mushroom();
        Destroy(gameObject);

    }

}

