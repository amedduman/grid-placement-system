using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRaycaster : MonoBehaviour
{
    [SerializeField] LayerMask _layersToCast;

    public bool IsAvailable()
    {
        bool hasCasted = false;

        for (int i = 0; i < transform.childCount; i++)
        {
            var tr = transform.GetChild(i);

            if (Physics.Raycast(tr.position, Vector3.down, Mathf.Infinity, _layersToCast))
            {
                hasCasted = true;
            }
        }

        return hasCasted;
    }

    private void OnDrawGizmos()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            var tr = transform.GetChild(i);

            Gizmos.color = Color.white;
            float sphereSize = .1f;
            Vector3 spherePos = tr.position;
            spherePos.y += sphereSize;
            Gizmos.DrawSphere(spherePos, sphereSize);

            Gizmos.color = Color.red;
            Gizmos.DrawLine(tr.position, tr.position + Vector3.down * 100);
        }
        
    }
}
