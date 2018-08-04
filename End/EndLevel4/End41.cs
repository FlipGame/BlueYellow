using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End41 : MonoBehaviour {

		public static int CountFour = 0;

	void OnTriggerEnter(Collider col)
	{
		 if (col.gameObject.tag == "P1")
		 {
			 CountFour += 1;;
			 print("P1");
			 
		 }
	}
}
