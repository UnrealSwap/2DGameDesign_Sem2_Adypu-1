using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
	public GameObject MenuCanvas;
	public GameObject SettingCanvas;


	public void SettingButton()
	{
		MenuCanvas.SetActive(false);
		SettingCanvas.SetActive(true);
	}

	public void BackButton()
	{
		MenuCanvas.SetActive(true);
		SettingCanvas.SetActive(false);
	}
}
