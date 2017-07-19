using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour 
{
	private Rigidbody rb;
	private AudioSource AudioS;

	public GameObject soldier;


	int foot=0;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody> ();
		AudioS = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
//		if (!soldier.activeInHierarchy)
//			return;
//		else 
//		{
			float x = CrossPlatformInputManager.GetAxis ("Horizontal");
			float y = CrossPlatformInputManager.GetAxis ("Vertical");

			Vector3 movement = new Vector3 (x, 0, y);
			rb.velocity = movement * 1f;

			if (x != 0 && y != 0)
				transform.eulerAngles = new Vector3 (transform.eulerAngles.x, Mathf.Atan2 (x, y) * Mathf.Rad2Deg, transform.eulerAngles.z);

			if (x != 0 && y != 0) 
			{
				
				soldier.GetComponent<Animation> ().Play ("Walk Aiming");

				//Audio Footsteps
				if (AudioS.isPlaying == false && foot < 2) 
				{
					AudioS.volume = Random.Range (0.8f, 1);
					AudioS.pitch = Random.Range (0.8f, 1.1f);
					AudioS.Play ();
				}
			} 
			else
				soldier.GetComponent<Animation> ().Play ("Idle Aim");
			
			foot++;
			if (foot > 1)
				foot = 0;
//		}
	}

	public void LostPlayer()
	{
		rb.transform.position = new Vector3 (0f, 0f, 0f);
	}



}
