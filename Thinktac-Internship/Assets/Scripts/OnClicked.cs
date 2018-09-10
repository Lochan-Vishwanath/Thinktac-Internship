using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClicked : MonoBehaviour {

	[SerializeField]
	GameObject gobj;
	void OnMouseDown(){
		//Debug.Log("Clicked");
		gobj.SetActive(true);
	}

}
