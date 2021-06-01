using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class URL_video : MonoBehaviour
{
	public Button yourButton;

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(OnClick);
	}

	void OnClick()
	{
		Debug.Log("You have clicked the button!");
		Application.OpenURL("http://unity3d.com/");
	}
}