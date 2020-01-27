using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class badnaamopen : MonoBehaviour {

	public void load()
{
		SceneManager.LoadScene("Badnaam");
}

	public void exit()
 {
		Application.Quit ();
		Debug.Log("Exit button pressed");
}
}
