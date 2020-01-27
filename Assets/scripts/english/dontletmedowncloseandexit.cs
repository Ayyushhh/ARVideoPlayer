using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dontletmedowncloseandexit : MonoBehaviour {

public void dontletopen()
{
		SceneManager.LoadScene("Don't let me down");
}

	public void exit()
 {
		Application.Quit ();
		Debug.Log("Exit button pressed");
}}
