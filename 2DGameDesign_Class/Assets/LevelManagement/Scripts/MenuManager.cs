using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace LevelManagement
{
    public class MenuManager : MonoBehaviour
    {
        public Menu MainMenuPrefab;
        public Menu SettingsMenuPrefab;
        public Menu CreditScreenPrefab;

        [SerializeField]
        public Transform _menuParent;

		private Stack<Menu> _menuStack = new Stack<Menu>();

		private void Awake()
		{
			InitializeMenus();
		}

		private void InitializeMenus()
		{
			if (_menuParent == null)
			{
                GameObject menuParentObject = new GameObject("Menus");
                _menuParent = menuParentObject.transform;
			}

            Menu[] menuPrefab = {MainMenuPrefab,SettingsMenuPrefab,CreditScreenPrefab };

			foreach (Menu prefab in menuPrefab)
			{
				if (prefab != null)
				{
                    Menu menuInstance = Instantiate(prefab, _menuParent);
					//Set default menue to main menu and rest other to setactive false
					if (prefab != MainMenuPrefab)
					{
						menuInstance.gameObject.SetActive(false);
					}
					else
					{
						openMenu(menuInstance);
					}
				}
			}
		}

		public void openMenu(Menu menuInstance)
		{
			if (menuInstance == null)
			{
				Debug.Log("MenuManager OpenMenu ERROR");
			}

			if (_menuStack.Count>0)
			{
				//Firstly Disable all the Menu in the stack
				foreach (Menu menu in _menuStack)
				{
					menu.gameObject.SetActive(false);
				}
			}

			menuInstance.gameObject.SetActive(true);
			_menuStack.Push(menuInstance);
		}

		public void CloseMenu()
		{
			if (_menuStack.Count == 0)
			{
				Debug.Log("MenuManager CloseMenu ERROR: No Menu in stack");
				return;
			}

			Menu topMenu = _menuStack.Pop();
			topMenu.gameObject.SetActive(false);

			if (_menuStack.Count>0)
			{
				Menu nextMenu = _menuStack.Peek();
				nextMenu.gameObject.SetActive(true);
			}
		}
    }
}
