﻿using UnityEngine;

public class CameraMovement : MonoBehaviour {

	/*
	This class handles the camera movement by taking into an account the position of the player (cube) by adding
	an offset to the position of the camera so it follow the desired object as it moves through the road 
	*/

	public Transform transformPlayer;
	void Update () {
		transform.position = transformPlayer.position + new Vector3(0, 2.658f, 2.963f);
	}}