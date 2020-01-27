using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class punjabibackandexit : MonoBehaviour {

	public void punjabi()
{
		SceneManager.LoadScene("Punjabi");
}

	public void exit()
 {
		Application.Quit ();
		Debug.Log("Exit button pressed");
}
}
