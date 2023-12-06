using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class data : MonoBehaviour
{
	[SerializeField]
	public GameObject[] dataBoxes;

	public int N;
	public int[] arr = new int[10];
	//public GameObject[] dataBoxes=new GameObject[20];


	public int state = -2;

	public int p;
	public int q;

	public float speedSort=0.01f;

	void Fillprefabs()
	{
		
		for (int i = 0; i < N; i++)
		{
			dataBoxes [i].GetComponent<boxscript> ().dataValue = arr [i];
			dataBoxes [i].GetComponent<boxscript> ().indexValue = i;
			dataBoxes [i].transform.GetChild (0).GetComponent<Renderer> ().material.color = Color.blue;
			dataBoxes [i].GetComponent<boxscript> ().BORN ();

		}
		state = 0;
	}


	void realSwap(int i,int j)
	{
		//Debug.Log ("Real swap"+i+" "+j+"=");
		int temp = arr [i];
		arr [i] = arr [j];
		arr[j]=temp;

		GameObject TGO = dataBoxes [i];
		dataBoxes [i] = dataBoxes [j];
		dataBoxes [j] = TGO;
	}




	void highlightBox(int i,int j)
	{
		//Debug.Log ("HightLight"+i+" "+j+"=");

		dataBoxes [i].transform.GetChild(0).GetComponent<Renderer> ().material.color = Color.red;
		dataBoxes [j].transform.GetChild(0).GetComponent<Renderer> ().material.color = Color.red;
		state = 2;
	}

	void UnhighlightBox(int i,int j)
	{
		//Debug.Log ("UnHightLight"+i+" "+j+"=");

		dataBoxes [i].transform.GetChild(0).GetComponent<Renderer> ().material.color = Color.blue;
		dataBoxes [j].transform.GetChild(0).GetComponent<Renderer> ().material.color = Color.blue;

		//real swap
		if (arr [i] >= arr [j])
			realSwap (i, j);

		q++;
		state = 0;
		//Debug.Log ("B="+Time.time);
	}

	void pullOutBox(int i,int j)
	{
		//Debug.Log ("pullOutBox"+i+" "+j+"=");

		dataBoxes [i].transform.Translate(Vector3.back*speedSort);
		dataBoxes [j].transform.Translate(Vector3.back*speedSort);

		if (dataBoxes [i].transform.position.z<= -1f)
			state = 3;

	}

	void pushInBox(int i,int j)
	{
		//Debug.Log ("pushInBox "+i+" "+j+"=");
		dataBoxes [i].transform.Translate(Vector3.forward*speedSort);
		dataBoxes [j].transform.Translate(Vector3.forward*speedSort);

		if (dataBoxes [i].transform.position.z >= 0f)
			state = 5;
	}


	void Swap(int i,int j)
	{
		//Debug.Log ("Physical swap "+i+" "+j+"=");
		dataBoxes [i].transform.Translate(Vector3.right*speedSort);
		dataBoxes [j].transform.Translate(Vector3.left*speedSort);

		if (dataBoxes [i].transform.position.x >= j)
			state = 4;

		if (dataBoxes [j].transform.position.x <= i)
			state = 4;
	}

	void processBoxes(int i,int j)
	{
		//Debug.Log ("Process"+i+" "+j+"=");
		if (arr [i] <= arr [j])
			state = 4;

		else
		{
			Swap (i, j);
		}

	}

	public void incspeed()
	{  
		speedSort+=0.1f;
	}

	public void decspeed()
	{
		speedSort -= 0.1f;
	}



	void PLAY()
	{
		if (Input.GetKey (KeyCode.Space))
			state = -1;

	}



	int y=1;

	// Update is called once per frame
	void Update () 
	{
		//Debug.Log ("select  p=" + p+ " q=" + q);

		switch (state)
		{
		case -2:PLAY ();break;
		case -1: Fillprefabs ();break;
		case 0: bubbleSortProcess ();break;
		case 1:  highlightBox (q, q+1); break;
		case 2:  pullOutBox (q, q+1);   break;
		case 3:  processBoxes (q, q+1);break;
		case 4:  pushInBox (q, q+1);      break;
		case 5:  UnhighlightBox (q, q+1);break;
		}

		if (Input.GetKey (KeyCode.M))
			incspeed();

		if (Input.GetKeyDown (KeyCode.N))
			decspeed();


	}

	void bubbleSortProcess()
	{
		Debug.Log ("p=" + p+ " q=" + q);

		if (q <N-1)
			state = 1;
		else 
		{
			p++;
			if (p == N)
				state = -1;

			q = 0;
			state = 1;
		}
	}

}
