using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkedListContainer : MonoBehaviour {

	public GameObject[] gameObject = new GameObject[7];

	int i;

	// Use this for initialization
	void Start () 
	{
		for (i=0; i < 6; i++) 
		{
			gameObject [i].transform.localScale = new Vector3 (1,  1, 1);
			gameObject [++i].transform.localScale = new Vector3 (0.1f,  1.2f, 0.1f);
			gameObject [++i].transform.localScale = new Vector3 (0.2f,  0.2f, 0.2f);
		}
		gameObject [i].transform.localScale = new Vector3 (1,  1, 1);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
