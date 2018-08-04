using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End1 : MonoBehaviour {
	public static int Count = 0;
void OnTriggerEnter(Collider col)
	{
		 if (col.gameObject.tag == "P1")
		 {
			 Count = 1;
			 print("P1");
		 }
	}
}
