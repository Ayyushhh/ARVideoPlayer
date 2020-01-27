using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backandclose : MonoBehaviour {

public void back()
{
	SceneManager.LoadScene("mainpage");
}

public void close()
{
	Application.Quit ();
	Debug.Log("Exit pressed button");
}

}
