using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class elevator : MonoBehaviour {

    public GameObject infoText;

	void OnTriggerStay(Collider col)
        {
            if (col.tag == "Player")
            {
                if (!infoText.activeInHierarchy)
                {
                    infoText.SetActive(true);
                }
                if (Application.loadedLevelName == "j1st")
                {
                    if (Input.GetKeyDown(KeyCode.Alpha2))
                    {
                        Application.LoadLevel("Second_Floor");
                    }
                    if (Input.GetKeyDown(KeyCode.Alpha3))
                    {
                        Application.LoadLevel("3floor");
                    }
                }
                else if (Application.loadedLevelName == "Second_Floor")
                {
                    if (Input.GetKeyDown(KeyCode.Alpha1))
                    {
                        Application.LoadLevel("j1stEle");
                    }
                    if (Input.GetKeyDown(KeyCode.Alpha3))
                    {
                        Application.LoadLevel("3floor");
                    }
                }
                else if (Application.loadedLevelName == "3floor")
                {
                    if (Input.GetKeyDown(KeyCode.Alpha1))
                    {
                        Application.LoadLevel("j1stEle");
                    }
                    if (Input.GetKeyDown(KeyCode.Alpha2))
                    {
                        Application.LoadLevel("Second_Floor");
                    }
                }
            }
        }
    void OnTriggerExit(Collider col)
        {
            if (infoText.activeInHierarchy)
            {
                infoText.SetActive(false);
            }
        }
	// Update is called once per frame
	void Update () {
	
	}
}
