using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class back1 : MonoBehaviour {
public void load1()
{
		SceneManager.LoadScene("mainpage");
}

	public void exit()
 {
		Application.Quit ();
		Debug.Log("Exit button pressed");
}
}
