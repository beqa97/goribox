using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {
	
		void Start () {

		}
		
		// Update is called once per frame
		void Update () {
		if (gameObject.transform.position.y < -6.5f) 
		{
			parametrebii.sicicxle--;
			Destroy(gameObject);
		}
	}

}
