using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOne : MonoBehaviour {

	public static int CountThree = 0;

	void OnTriggerEnter(Collider col)
	{
		 if (col.gameObject.tag == "P1")
		 {
			 CountThree += 1;;
			 print("P2");
			 
		 }
	}

}
