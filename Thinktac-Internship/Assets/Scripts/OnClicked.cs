using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClicked : MonoBehaviour {

	[SerializeField]
	GameObject WrongMark;
	[SerializeField]
	GameObject MakerObj;
	[SerializeField]
	Image Rectobj;
	AudioSource CorrectAudio;
	float EntryTime,WrongTime;
	bool OperationStart=false,MouseOnObject=false,EnterOnceOnly=true;
	[SerializeField]
	Text DisplayAnswerField,SideAnswerField;

	void Start(){
		CorrectAudio=GetComponent<AudioSource>();
	}
	void OnMouseDown(){
		EntryTime=Time.time;
		OperationStart=true;
		CorrectAudio.Play();
		if(EnterOnceOnly)
			GameManagerScript.NoOfAnswersFound++;
	}

	void DoOpertaion(){
			if(EntryTime+0.1f<=Time.time){
				Rectobj.gameObject.SetActive(true);
				if(EntryTime+0.2f<=Time.time){
					DisplayAnswerField.gameObject.SetActive(true);
					if(EntryTime+2.2f<=Time.time){
						MakerObj.SetActive(true);
						SideAnswerField.gameObject.SetActive(true);
						Rectobj.gameObject.SetActive(false);
						DisplayAnswerField.gameObject.SetActive(false);
						OperationStart=false;
						EnterOnceOnly=false;
					}	
				}
			}
	}

	void Update(){
		if(OperationStart){
			DoOpertaion();
		}
	/*	if(Input.GetMouseButtonDown(0) && !MouseOnObject)
  		{
			WrongTime=Time.time;
  			WrongMark.SetActive(true);
   		}
		if(WrongTime+0.3f<=Time.time){
			WrongMark.SetActive(false);
		}
	*/
	}

	void OnMouseEnter(){
 		MouseOnObject = true;
 	}
	 void OnMouseExit(){
		MouseOnObject = false;
	 }

}
