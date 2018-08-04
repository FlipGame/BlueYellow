using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame6 : MonoBehaviour {
	
void OnTriggerEnter(Collider col)
	{
		 if (col.gameObject.tag == "P6")
		 {
			 EndGame1.CountFive += 1;;
			 print("P6");
			 
		 }
	}

	void Update()
	{
		if(EndGame1.CountFive == 6)
		{
			print("EndGame");
			//SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex+1);
			//EndOne.CountThree = 0;
		}
	}
}
