using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame5 : MonoBehaviour {

			
void OnTriggerEnter(Collider col)
	{
		 if (col.gameObject.tag == "P5")
		 {
			 EndGame1.CountFive += 1;;
			 print("P5");
			 
		 }
	}
}
