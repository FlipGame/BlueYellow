using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTow : MonoBehaviour {

		
void OnTriggerEnter(Collider col)
	{
		 if (col.gameObject.tag == "P2")
		 {
			 EndOne.CountThree += 1;;
			 print("P2");
			 
		 }
	}

}
