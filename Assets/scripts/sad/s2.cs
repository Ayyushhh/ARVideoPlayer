using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class s2 : MonoBehaviour {
public void loadinngg()
{
		SceneManager.LoadScene("Kabhi jo badal barse");
}

	public void exit()
 {
		Application.Quit ();
		Debug.Log("Exit button pressed");
}
}
