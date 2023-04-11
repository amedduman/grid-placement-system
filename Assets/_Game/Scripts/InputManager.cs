using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] LayerMask _placementLayerMask;
    Vector3 _lastRayHittingPos;
    Camera _cam;

    private void Awake()
    {
        _cam = ServiceLocator.Get<Camera>(SerLocID.MainCamera);
    }

    public Vector3 GetSelectedMapPosition()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = _cam.nearClipPlane;
        Ray ray = _cam.ScreenPointToRay(mousePos);
        RaycastHit hitInfo;

        if(Physics.Raycast(ray, out hitInfo, Mathf.Infinity, _placementLayerMask))
        {
            _lastRayHittingPos = hitInfo.point;
        }

        return _lastRayHittingPos;
    }
}
