﻿using UnityEngine;

public class Parallax : MonoBehaviour {

	private float length, startPos;
	
	public float parallexEffect;
	
	public GameObject cam;

	void Start () 
	{
		startPos = transform.position.x;
		length = GetComponent<SpriteRenderer>().bounds.size.x;//
	}
	
	void FixedUpdate () 
	{
		
		float temp = (cam.transform.position.x * (1 - parallexEffect));
		
		float dist = (cam.transform.position.x * parallexEffect);

		transform.position = new Vector3(startPos + dist, transform.position.y, transform.position.z);

		if (temp > startPos + length)
		{
			startPos += length;
		}
		else if (temp < startPos - length)
		{
			startPos -= length;
		}
	}

}
