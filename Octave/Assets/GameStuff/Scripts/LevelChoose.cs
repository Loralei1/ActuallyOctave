using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;

public class LevelChoose : MonoBehaviour {
	
	
	private void Start()
	{
		SceneManager.LoadScene("MajorScene", LoadSceneMode.Additive);
	}
}
