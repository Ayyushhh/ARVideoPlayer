using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sadbackandexit : MonoBehaviour {

	public void sad()
{
		SceneManager.LoadScene("Sad");
}

	public void exit()
 {
		Application.Quit ();
		Debug.Log("Exit button pressed");
}
}
