using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
	public Button btn1;
	public Button btn2;
	public Button btn3;
	public string Scene1;
	public string Scene2;
	public string Scene3;
	// Start is called before the first frame update
	void Start()
    {
		btn1.onClick.AddListener(() => OpenScene1());
		btn2.onClick.AddListener(() => OpenScene2());
		btn3.onClick.AddListener(() => OpenScene3());
	}

	private void OpenScene1()
	{
		SceneManager.LoadScene(Scene1);
	}

	private void OpenScene2()
	{
		SceneManager.LoadScene(Scene2);
	}

	private void OpenScene3()
	{
		SceneManager.LoadScene(Scene3);
	}
}
