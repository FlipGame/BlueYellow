using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End3 : MonoBehaviour {
		
void OnTriggerEnter(Collider col)
	{
		 if (col.gameObject.tag == "P3")
		 {
			 End41.CountFour += 1;;
			 print("P3");
			 
		 }
	}
}
