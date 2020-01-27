using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class najaopen : MonoBehaviour {
public void load()
{
		SceneManager.LoadScene("Na Ja");
}

	public void exit()
 {
		Application.Quit ();
		Debug.Log("Exit button pressed");
}
}
