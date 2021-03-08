using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationManager : Manager<NavigationManager>
{
    public float normalHeight = 1.2f;

    private WalkOnSurface walkOnSurface;

    void Start()
    {
        walkOnSurface = GetComponent<WalkOnSurface>();

#if !UNITY_EDITOR
        walkOnSurface.enabled = false;
#endif

    }


    private void OnEnable()
    {
        AltRealityARManager.onExperienceStart += OnExperienceStart;
        AltRealityARManager.onExperienceReset += OnExperienceReset;
    }

    private void OnDisable()
    {
        AltRealityARManager.onExperienceStart -= OnExperienceStart;
        AltRealityARManager.onExperienceReset -= OnExperienceReset;
    }

    void OnExperienceStart()
    {
        walkOnSurface.enabled = true;
    }

    void OnExperienceReset()
    {
        walkOnSurface.enabled = false;
    }


    public void CloseToAClimbable()
    {
        walkOnSurface.enabled = false;
    }

    public void LeaveAClimbable()
    {
        walkOnSurface.enabled = true;
    }

}
