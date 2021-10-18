using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Menu_button : GazeableButton
{

    [SerializeField]
    private InputMode button_mode;
	private VRCanvasMenu parentPanel;

	public override void Start(){
		base.Start();
		parentPanel = GetComponentInParent<VRCanvasMenu> ();
	}


    public override void OnPress(RaycastHit hitInfo)
    {
        base.OnPress(hitInfo);
        if (parentPanel != null) {
			parentPanel.SetActiveButton (this);
			Debug.Log("activate" + this.ToString());
		} else {
			Debug.LogError ("Button not a child of object with VRPanel component. ", this);
		}
    }


    public InputMode getMode(){
		return button_mode;
	}

}
