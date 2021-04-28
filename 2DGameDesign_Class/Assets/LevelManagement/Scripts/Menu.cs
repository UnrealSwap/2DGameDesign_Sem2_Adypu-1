using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LevelManagement
{
	[RequireComponent(typeof(Canvas))]
	public class Menu : MonoBehaviour
	{
		public void OnPlayPressed()
		{
			SceneManager.LoadScene("PlayGame");
		}

		public void OnSettingPressed()
		{
			MenuManager menumanager = Object.FindObjectOfType<MenuManager>();

			Menu settingsMenu = transform.parent.Find("SettingsMenu(Clone)").GetComponent<Menu>();
			if(menumanager!= null && settingsMenu!= null)
			{
				menumanager.openMenu(settingsMenu);
			}
		}

		public void OnCreditPressed()
		{
			MenuManager menumanager = Object.FindObjectOfType<MenuManager>();

			Menu creditScreen = transform.parent.Find("CreditScreen(Clone)").GetComponent<Menu>();
			if (menumanager != null && creditScreen != null)
			{
				menumanager.openMenu(creditScreen);
			}
		}
		public void OnBackPressed()
		{
			MenuManager menumanager = Object.FindObjectOfType<MenuManager>();
			if (menumanager != null )
			{
				menumanager.CloseMenu();
			}
		}



		
	}
}
