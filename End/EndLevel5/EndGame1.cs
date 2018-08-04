using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame1 : MonoBehaviour {

	public static int CountFive = 0;

	void OnTriggerEnter(Collider col)
	{
		 if (col.gameObject.tag == "P1")
		 {
			 CountFive += 1;;
			 print("P1");
			 
		 }
	}
}
