using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndThree : MonoBehaviour {

		
void OnTriggerEnter(Collider col)
	{
		 if (col.gameObject.tag == "P3")
		 {
			 EndOne.CountThree += 1;;
			 print("P3");
			 
		 }
	}

	void Update()
	{
		if(EndOne.CountThree == 3)
		{
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex+1);
			//EndOne.CountThree = 0;
		}
	}
}
