﻿using UnityEngine;
using System.Collections;

public class MenuMusicScript : MonoBehaviour {
	
	private static MenuMusicScript instance = null;
	public static MenuMusicScript Instance {
		get { return instance; }
	}
	
	void Awake() {
		if( instance != null && instance != this ) {
			Destroy (this.gameObject);
			return;
		} else {
			instance = this;
		}
		DontDestroyOnLoad(gameObject);
	}
}
