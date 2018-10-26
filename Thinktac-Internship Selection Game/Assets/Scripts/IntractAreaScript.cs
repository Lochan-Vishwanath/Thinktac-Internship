using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntractAreaScript : MonoBehaviour {

	static AudioSource audioclip1;

	void Start(){
		audioclip1=GetComponent<AudioSource>();
	} 

	public static AudioSource returnAudio(){
		return audioclip1;
	}

}
