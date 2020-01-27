using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backandclose1 : MonoBehaviour {

	public void back()
{
		SceneManager.LoadScene("mainpage");
}

	public void exit()
 {
		Application.Quit ();
		Debug.Log("Exit button pressed");
}
}
