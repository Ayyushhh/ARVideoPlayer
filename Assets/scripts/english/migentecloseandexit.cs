using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class migentecloseandexit : MonoBehaviour {

	public void migenteopen()
{
		SceneManager.LoadScene("Mi Gente");
}

	public void exit()
 {
		Application.Quit ();
		Debug.Log("Exit button pressed");
}
}
