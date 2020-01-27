using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class attentioncloseandexit : MonoBehaviour {

	public void attentionopen()
{
		SceneManager.LoadScene("Attention");
}

	public void exit()
 {
		Application.Quit ();
		Debug.Log("Exit button pressed");
}
}
