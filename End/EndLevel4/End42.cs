using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End42 : MonoBehaviour {
		
void OnTriggerEnter(Collider col)
	{
		 if (col.gameObject.tag == "P2")
		 {
			 End41.CountFour += 1;;
			 print("P2");
			 
		 }
	}
}
