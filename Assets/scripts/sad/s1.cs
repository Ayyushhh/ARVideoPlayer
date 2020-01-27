using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class s1 : MonoBehaviour {
public void loadinngg()
{
		SceneManager.LoadScene("Humsafar");
}

	public void exit()
 {
		Application.Quit ();
		Debug.Log("Exit button pressed");
}
}
