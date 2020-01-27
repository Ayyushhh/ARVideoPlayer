using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class englishbackandexit : MonoBehaviour {

public void english()
{
		SceneManager.LoadScene("English");
}

	public void exit()
 {
		Application.Quit ();
		Debug.Log("Exit button pressed");
}
	

}
