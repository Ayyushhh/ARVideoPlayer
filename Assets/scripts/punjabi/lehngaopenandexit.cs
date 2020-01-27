using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lehngaopenandexit : MonoBehaviour {

	public void load()
{
		SceneManager.LoadScene("Lehenga");
}

	public void exit()
 {
		Application.Quit ();
		Debug.Log("Exit button pressed");
}
}
