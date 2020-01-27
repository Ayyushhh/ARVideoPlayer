using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class closercloseandexit : MonoBehaviour {

	public void closeropen()
{
		SceneManager.LoadScene("Closer");
}

	public void exit()
 {
		Application.Quit ();
		Debug.Log("Exit button pressed");
}
}
