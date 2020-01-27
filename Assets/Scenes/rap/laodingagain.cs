using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class laodingagain : MonoBehaviour {
public void loadinng()
{
		SceneManager.LoadScene("mainpage");
}

	public void exit()
 {
		Application.Quit ();
		Debug.Log("Exit button pressed");
}
}
