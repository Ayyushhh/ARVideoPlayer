using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rapcloseandexit : MonoBehaviour {

	public void rap()
{
		SceneManager.LoadScene("Rap");
}

	public void exit()
 {
		Application.Quit ();
		Debug.Log("Exit button pressed");
}
}
