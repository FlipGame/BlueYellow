using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame2 : MonoBehaviour {

			
void OnTriggerEnter(Collider col)
	{
		 if (col.gameObject.tag == "P2")
		 {
			 EndGame1.CountFive += 1;;
			 print("P2");
			 
		 }
	}
}
