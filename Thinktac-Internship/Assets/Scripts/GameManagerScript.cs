using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour {

	public static byte NoOfAnswersFound=0;

	public Text AnsFoundText;
	public Button NextButton;

	void Update(){

		switch(NoOfAnswersFound){
			case 1:AnsFoundText.text="You have found 1 Answer, Find the other 3.";break;
			case 2:AnsFoundText.text="You have found 2 Answer, Find the other 2.";break;
			case 3:AnsFoundText.text="You have found 3 Answer, Find the other 1.";break;
			case 4:AnsFoundText.text="You have found all the answers, Goto next question.";break;
		}
		if(NoOfAnswersFound>=4){
			NextButton.gameObject.SetActive(true);	
		}
		
	}

}
