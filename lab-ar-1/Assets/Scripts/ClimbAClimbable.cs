using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbAClimbable : MonoBehaviour
{
    public LayerMask climbableLayer;

    private Vector3 startClimbTouchPoint;

    private void FixedUpdate()
    {
#if UNITY_EDITOR
        ClimbInEditor();
#else
        ClimbInPhone();
#endif

    }

    void ClimbInEditor()
    {
        Ray ray;
        RaycastHit hit;

        if (Input.GetMouseButton(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 3f, climbableLayer))
            {
                startClimbTouchPoint = hit.point;
            }
        }
        else if (Input.GetMouseButton(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 3f, climbableLayer))
            {
                Vector3 touchPositionChange = hit.point - startClimbTouchPoint;
                transform.position = new Vector3(transform.position.x, transform.position.y - touchPositionChange.y, transform.position.z);
            }
        }
    }

    void ClimbInPhone()
    {
        if (Input.touchCount == 0) return;

        Ray ray;
        RaycastHit hit;

        if (Input.GetTouch(0).phase == TouchPhase.Began)
        {
            ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            if (Physics.Raycast(ray, out hit, 1f, climbableLayer))
            {
                startClimbTouchPoint = hit.point;
            }
        }
        else if (Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            if (Physics.Raycast(ray, out hit, 1f, climbableLayer))
            {
                Vector3 touchPositionChange = hit.point - startClimbTouchPoint;
                transform.position = new Vector3(transform.position.x, transform.position.y - touchPositionChange.y, transform.position.z);
            }
        }
    }
}
