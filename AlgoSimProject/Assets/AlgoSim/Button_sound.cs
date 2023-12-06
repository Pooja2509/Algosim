using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_sound : MonoBehaviour 
{
	public AudioSource myAudioSource;
	public AudioClip myAudioClip;

	public void playClip()
	{
		myAudioSource = GetComponent <AudioSource> ();
		myAudioSource.clip = myAudioClip;
		myAudioSource.Play ();
	}

	// Use this for initialization
}
