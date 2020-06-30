using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Myfirstscript : MonoBehaviour
{
	public Button btn;
	public string secondScene;
    void Start()
    {
		btn.onClick.AddListener(()=>OpenSecondScene());
		Debug.Log("First unity Script");
    }
    void Update()
    {
		if (Input.GetKey(KeyCode.S))
		{
			Debug.Log("Print S");
		}
		else if (Input.GetKeyDown(KeyCode.F))
		{
			Debug.Log("Print F");
		}
		else if(Input.GetKeyUp(KeyCode.A))
		{
			Debug.Log("Print A");
		}
    }
	public void OpenSecondScene()
	{
		SceneManager.LoadScene(secondScene);
	}
}
