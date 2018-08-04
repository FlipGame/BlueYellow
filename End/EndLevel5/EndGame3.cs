using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame3 : MonoBehaviour {

			
void OnTriggerEnter(Collider col)
	{
		 if (col.gameObject.tag == "P3")
		 {
			 EndGame1.CountFive += 1;;
			 print("P3");
			 
		 }
	}
}
