using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inputIS : MonoBehaviour 
{
	insertinscript m_Script;
	managerIS m_Manager;
	public GameObject obj,temp;

	void Start()
	{
		m_Manager = obj.GetComponent<managerIS> ();
		m_Script = temp.GetComponent<insertinscript> ();
	}

	public void GetInput(string s)
	{
		Debug.Log ("yo");
		if (m_Manager.i == 0) 
		{
			m_Script.N = int.Parse (s);
		}

		else 
		{
			m_Script.arr [m_Manager.i - 1] = int.Parse(s);
			Debug.Log (m_Script.arr [m_Manager.i-1]);
		}  
		m_Manager.i += 1;

	}

}
