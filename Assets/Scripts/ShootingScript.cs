using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ShootingScript : MonoBehaviour 
{
	public GameObject bullet;
	private Vector2 touchOrigin = -Vector2.one;
	//public Transform spawnPos;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		int horizontal = 0;
		int vertical = 0;

//		#if UNITY_EDITOR || UNITY_STANDALONE
//
		if (Input.GetMouseButtonDown (0)) 
		{
			GameObject go = Instantiate (bullet, transform.position, transform.rotation)as GameObject;
			//GameObject go = Instantiate (bullet, spawnPos.position, spawnPos.rotation)as GameObject;
			go.GetComponent<Rigidbody> ().AddForce (transform.forward * 15, ForceMode.Impulse);
		}

			
//		if (Input.touchCount > 0) 
//		{
//			Touch myTouch = Input.touches[0];
//			if (myTouch.phase == TouchPhase.Began)
//				touchOrigin = myTouch.position;
//			else if (myTouch.phase == TouchPhase.Ended && touchOrigin.x >= 0) 
//			{
//				Vector2 touchEnd = myTouch.position;
//				float x = touchEnd.x - touchOrigin.x;
//				float y = touchEnd.y - touchOrigin.y;
//				touchOrigin.x = -1;
//				if (Mathf.Abs (x) > Mathf.Abs (y))
//					horizontal = x > 0 ? 1 : -1;
//				else
//					vertical = y > 0 ? 1 : -1;
//			}
//		}
//
//		if (horizontal != 0 || vertical != 0) 
//		{
//			GameObject go = Instantiate (bullet, transform.position, transform.rotation)as GameObject;
//			//GameObject go = Instantiate (bullet, spawnPos.position, spawnPos.rotation)as GameObject;
//			go.GetComponent<Rigidbody> ().AddForce (transform.forward * 50, ForceMode.Impulse);	
//		} 

	}
}
