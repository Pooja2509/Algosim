using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxscript : MonoBehaviour
{
	
	public int indexValue;
	public int dataValue;
	public Transform boxBody;

	// Use this for initialization
	void Start () 
	{
		
	
	}

	public void BORN()
	{
		Debug.Log ("called" + indexValue+" "+dataValue);
		this.transform.position = new Vector3 (indexValue, 0, 0);
		boxBody.transform.Translate (Vector3.up * dataValue / 2);
		boxBody.transform.localScale = new Vector3 (1, dataValue, 1);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
