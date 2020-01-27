using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class rapnew1 : MonoBehaviour {

	public void backingg()
{
		SceneManager.LoadScene("Rap");
}

	public void exit()
 {
		Application.Quit ();
		Debug.Log("Exit button pressed");
}
}
