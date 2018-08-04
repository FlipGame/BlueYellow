using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame4 : MonoBehaviour {

			
void OnTriggerEnter(Collider col)
	{
		 if (col.gameObject.tag == "P4")
		 {
			 EndGame1.CountFive += 1;;
			 print("P4");
			 
		 }
	}
}
