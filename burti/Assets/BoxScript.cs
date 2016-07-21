using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class BoxScript : MonoBehaviour {
	int x=0;
	public List<GameObject> burtebi;
	public GameObject burti;
	public int y = 100;
	void Start () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		Destroy(other.gameObject);
		parametrebii.qula++;
	}


	// Update is called once per frame
	void Update () {
		if (parametrebii.wageba == true)
		{
			return;
		}
		if (parametrebii.sicicxle == 0) {

			parametrebii.sicicxle = 3;
			parametrebii.wageba = true;

		}

		if (Input.GetKey (KeyCode.RightArrow)) {

			if (gameObject.transform.position.x < 1.7f) 
			{
				gameObject.transform.Translate (new Vector2 (0.1f, 0));
			}

					

		}
		if (Input.GetKey (KeyCode.LeftArrow)) {

			if (gameObject.transform.position.x > -1.7f) 
			{
				gameObject.transform.Translate (new Vector2 (-0.1f, 0));
			}


		}

	
		if (x == y) 
{
			
			print ("shemovida");
			Instantiate (burtebi[Random.Range(0,6)],new Vector3 (Random.Range (-2, 3), 7, 0), Quaternion.identity); 
			x = 0;
		}
		else
		{	x++;	    }
	}
}
