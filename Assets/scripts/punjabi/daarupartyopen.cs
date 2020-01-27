using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class daarupartyopen : MonoBehaviour {

	public void load()
{
		SceneManager.LoadScene("Daaru Party");
}

	public void exit()
 {
		Application.Quit ();
		Debug.Log("Exit button pressed");
}
}
