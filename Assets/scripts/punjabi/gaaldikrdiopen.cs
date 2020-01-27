using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gaaldikrdiopen : MonoBehaviour {

	public void load()
{
		SceneManager.LoadScene("Gaal ni Kardi");
}

	public void exit()
 {
		Application.Quit ();
		Debug.Log("Exit button pressed");
}
}
