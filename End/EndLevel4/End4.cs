using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End4 : MonoBehaviour {
		
void OnTriggerEnter(Collider col)
	{
		 if (col.gameObject.tag == "P4")
		 {
			 End41.CountFour += 1;;
			 print("P4");
			 
		 }
	}

	void Update()
	{
		if(End41.CountFour == 4)
		{
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex+1);
			
		}
	}
}
