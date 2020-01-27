using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class s3 : MonoBehaviour {
public void loadinngg()
{
		SceneManager.LoadScene("Naina");
}

	public void exit()
 {
		Application.Quit ();
		Debug.Log("Exit button pressed");
}
}
