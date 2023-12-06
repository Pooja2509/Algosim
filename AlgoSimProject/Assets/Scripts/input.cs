using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class input : MonoBehaviour {

	data m_Data;
	manager m_Manager;
	public GameObject m_gameObj,m_tempGameObj;

	void Start()
	{
		m_Manager = m_gameObj.GetComponent<manager> ();
		m_Data = m_tempGameObj.GetComponent<data> ();
	}

	public void GetInput(string str)
	{
		Debug.Log ("yo");
		if (m_Manager.i == 0) 
		{
			m_Data.N = int.Parse (str);

		}

		else 
		{
			m_Data.arr [m_Manager.i - 1] = int.Parse(str);
			Debug.Log (m_Data.arr [m_Manager.i]);
		}  
		m_Manager.i += 1;


	}

}
