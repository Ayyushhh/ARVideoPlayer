using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class r5 : MonoBehaviour {

	public void loading1()
{
		SceneManager.LoadScene("Wakhra");
}

	public void exit()
 {
		Application.Quit ();
		Debug.Log("Exit button pressed");
}
}
