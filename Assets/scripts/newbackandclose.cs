using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newbackandclose : MonoBehaviour {
	
	public void ARvideo()
{
		SceneManager.LoadScene("ARvideos");
}

	public void exit ()
 {
		Application.Quit ();
		Debug.Log("Exit button pressed");
}
	
}
