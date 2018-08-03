using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End1 : MonoBehaviour {
	
void OnTriggerEnter(Collider col)
	{
		 if (col.gameObject.tag == "Player")
		 {
			 print("End");
			 //SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex+1);
		 }
	}
}
