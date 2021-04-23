using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicScript : MonoBehaviour
{

    public GameObject SpecifyTilesGameObject;
    public Image Imagecomponent;
    
    // Update is called once per frame
    void Update()
    {
		if (Input.GetKey(KeyCode.Space))
		{
            Imagecomponent.enabled = false;

        }
    }
}
