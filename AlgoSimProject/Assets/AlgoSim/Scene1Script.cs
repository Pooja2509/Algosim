using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Scene1Script: MonoBehaviour 
{
	public Text textAreaValue;
	public string[] stringsValue;
	public float speedValue = 0.5f;

	// Use this for initialization
	int strIndexValue = 0;
	int chrIndexValue = 0;

	void Start () 
	{
		StartCoroutine (DisplayTimer ());
	}

	IEnumerator DisplayTimer()
	{
		while (1==1) 
		{
			yield return new WaitForSeconds (speedValue);
			if (chrIndexValue > stringsValue [strIndexValue].Length) {
				continue;
			}

			textAreaValue.text = stringsValue [strIndexValue].Substring (0, chrIndexValue);
			chrIndexValue++;
		}
	}



	// Update is called once per frame
	void Update () 
	{

	}
}

