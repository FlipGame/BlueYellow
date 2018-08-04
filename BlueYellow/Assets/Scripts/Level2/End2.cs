using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End2 : MonoBehaviour {
	
void OnTriggerEnter(Collider col)
	{
		 if (col.gameObject.tag == "P2")
		 {
			 End1.Count += 1;;
			 print("P2");
			 
		 }
	}

	void Update()
	{
		if(End1.Count == 2)
		{
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex+1);
		}
	}
}
