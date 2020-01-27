using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class roarcloseandexit : MonoBehaviour {

public void roaropen()
{
		SceneManager.LoadScene("Roar");
}

	public void exit()
 {
		Application.Quit ();
		Debug.Log("Exit button pressed");
}
}
