using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class diltutdaopen : MonoBehaviour {

	public void load()
{
		SceneManager.LoadScene("Dil tutda");
}

	public void exit()
 {
		Application.Quit ();
		Debug.Log("Exit button pressed");
}
}
