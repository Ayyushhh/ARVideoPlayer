using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class taaraopenandexit : MonoBehaviour {

	public void load()
{
		SceneManager.LoadScene("5 Taara");
}

	public void exit()
 {
		Application.Quit ();
		Debug.Log("Exit button pressed");
}
}
