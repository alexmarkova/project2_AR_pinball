using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbableWall : MonoBehaviour
{
     private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            NavigationManager.Instance.CloseToAClimbable();
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            NavigationManager.Instance.LeaveAClimbable();
        }
    }

}
