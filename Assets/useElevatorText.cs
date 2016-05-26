using UnityEngine;
using System.Collections;

public class useElevatorText : MonoBehaviour {
    public GameObject studentText;

    void OnTriggerStay(Collider col)
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
