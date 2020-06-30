using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
	public Button backbtn;
    void Start()
    {
		backbtn.onClick.AddListener(() => GoToMasterScene());
    }

	private void GoToMasterScene()
	{
		SceneManager.LoadScene("MasterScene");
	}
}
