using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARHotspot : MonoBehaviour
{

    private Transform mainCamera;
    private Transform arSessionOrigin;

    void Start()
    {
        mainCamera = Camera.main.transform;
        arSessionOrigin = mainCamera.parent;
    }

    public void OnTap()
    {
        float distance = Vector3.Distance(transform.position, mainCamera.position);
        Vector3 destination = transform.position - mainCamera.localPosition;

        LeanTween.move(arSessionOrigin.gameObject, destination+Vector3.up, distance / 2f);
    }

 
}
