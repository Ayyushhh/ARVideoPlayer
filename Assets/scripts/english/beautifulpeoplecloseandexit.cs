using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class beautifulpeoplecloseandexit : MonoBehaviour {

	public void beautifulopen()
{
		SceneManager.LoadScene("Beautiful People");
}

	public void exit()
 {
		Application.Quit ();
		Debug.Log("Exit button pressed");
}
}
