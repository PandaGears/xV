﻿using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
[System.Serializable]
public class GameManager : MonoBehaviour {

	public static GameManager gm;
    //store gameObject reference
    public GameObject Env;

    bool ismenu = false;
        
    public List<GameObject> placableObjects = new List<GameObject>();

    private void Update()
    {
        
        
    }

    void Awake () {
		if (gm == null)
			gm = this;

		var objectArray = Resources.LoadAll("", typeof(GameObject));
		foreach (Object item in objectArray)
		{
			placableObjects.Add((GameObject)item);
		}
	}

    public void ToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void ToMain()
    {
        SceneManager.LoadScene("Main Scene");
    }


}
