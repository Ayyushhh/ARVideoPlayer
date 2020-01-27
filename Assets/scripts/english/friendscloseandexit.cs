using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class friendscloseandexit : MonoBehaviour {

public void friendsnopen()
{
		SceneManager.LoadScene("Friends");
}

	public void exit()
 {
		Application.Quit ();
		Debug.Log("Exit button pressed");
}
}
