﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_ManagementPlayer : MonoBehaviour {

	public AudioSource audio;

	[Space]
	[Header("Pencil")]
	public AudioClip pencilWin;
	public AudioClip pencilPunch;

	//PENCIL
	public void PencilWin(){

		audio.PlayOneShot (pencilWin);

	}
	public void PencilPunch(){

		audio.PlayOneShot (pencilPunch);

	}
}