﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class r1 : MonoBehaviour {

	public void loading1()
{
		SceneManager.LoadScene("Dheeme Dheeme");
}

	public void exit()
 {
		Application.Quit ();
		Debug.Log("Exit button pressed");
}
}
