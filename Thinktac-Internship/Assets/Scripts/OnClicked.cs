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
	AudioSource CorrectAudio,newAudio;
	float EntryTime,WrongTime=0f;
	bool OperationStart=false,MouseOnObject=false,EnterOnceOnly=true;
	[SerializeField]
	Text DisplayAnswerField,SideAnswerField;

	void Awake(){
		//newAudio=IntractAreaScript.returnAudio();
	}
	void Start(){
		CorrectAudio=GetComponent<AudioSource>();
		//newAudio=IntractAreaScript.returnAudio();
	}
	void OnMouseDown(){
		EntryTime=Time.time;
		OperationStart=true;
		CorrectAudio.Play();
		if(EnterOnceOnly)
			GameManagerScript.NoOfAnswersFound++;
		WrongMark.SetActive(false);
	}

	void DoOpertaion(){
	//	newAudio.Stop();
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
	}
	void LateUpdate(){
		if(!OperationStart && Input.GetMouseButtonUp(0) ){
		//	newAudio.Play();
			WrongMark.SetActive(true);
			WrongTime=Time.time;
		}
		if(WrongTime+0.4f<=Time.time)
				WrongMark.SetActive(false);
	}

	void OnMouseEnter(){
 		MouseOnObject = false;
 	}
	 void OnMouseExit(){
		MouseOnObject = true;
	 }

}
