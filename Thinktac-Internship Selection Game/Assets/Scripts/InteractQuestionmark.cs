using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractQuestionmark : MonoBehaviour {

	[SerializeField]
	Button button;
	[SerializeField]
	InputField ipfield;
	[SerializeField]
	Text enteredno;
	[SerializeField]
	Image Qmark;
	[SerializeField]
	RawImage WrongAnswerScreen,NoTextEntered;
	bool WrongAnswerScreenActivated=false,NoTextEnteredActivated=false;
	float screentime;

	AudioSource audioclip;

	void Start(){
		audioclip=GetComponent<AudioSource>();
	}

	public void OnButtonClicked(){
		audioclip.Play();
		Qmark.gameObject.SetActive(false);
		button.gameObject.SetActive(false);
		ipfield.gameObject.SetActive(true);
	}
	public void OnTextChanged(){
		string EnteredString=ipfield.text.ToString();
		if(EnteredString!=""){
			float FrequencyEntered=float.Parse(EnteredString);
			if(FrequencyEntered>=300 && FrequencyEntered<=1500){
				ipfield.gameObject.SetActive(false);
				enteredno.gameObject.SetActive(true);
				enteredno.text=FrequencyEntered.ToString()+"Hz";
				button.gameObject.SetActive(true);
			}
			else{
				WrongAnswerScreen.gameObject.SetActive(true);
				WrongAnswerScreenActivated=true;
				screentime=Time.time;
				Qmark.gameObject.SetActive(true);
				button.gameObject.SetActive(true);
				ipfield.gameObject.SetActive(false);
			}
		}
		else{
			NoTextEntered.gameObject.SetActive(true);
			NoTextEnteredActivated=true;
			screentime=Time.time;
			Qmark.gameObject.SetActive(true);
			button.gameObject.SetActive(true);
			ipfield.gameObject.SetActive(false);
		}
	}

	void Update(){
		if(WrongAnswerScreenActivated){
			if(screentime+1.5f<=Time.time){
				WrongAnswerScreen.gameObject.SetActive(false);
			}	
		}
		if(NoTextEnteredActivated){
			if(screentime+1.5f<=Time.time){
				NoTextEntered.gameObject.SetActive(false);
			}	
		}
	}
}
