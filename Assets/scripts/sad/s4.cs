using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class s4 : MonoBehaviour {
public void loadinnggg()
{
		SceneManager.LoadScene("Raabta");
}

	public void exit()
 {
		Application.Quit ();
		Debug.Log("Exit button pressed");
}
}
