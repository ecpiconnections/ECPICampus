using UnityEngine;
using System.Collections;

public class elevatorText : MonoBehaviour {
    public GameObject studentText;

    void OnTriggerEnter(Collider col)
        {
            if (!studentText.activeInHierarchy)
                {
                    studentText.SetActive(true);
                }
        }
    void OnTriggerExit(Collider col)
    {
        if (studentText.activeInHierarchy)
        {
            studentText.SetActive(false);
        }
    }
	
}
