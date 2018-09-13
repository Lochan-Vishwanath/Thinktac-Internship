using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuButton : MonoBehaviour {

	[SerializeField]
	Text ButtonText,discription;
	[SerializeField]
	RawImage backgroundimage;
	
	public void OnMouseEnter(){
 		ButtonText.fontSize+=5;
		discription.gameObject.SetActive(true);
		backgroundimage.gameObject.SetActive(true);
 	}
	public void OnMouseExit(){
		ButtonText.fontSize-=5;
		discription.gameObject.SetActive(false);
		backgroundimage.gameObject.SetActive(false);
	}
}
