using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridPlaceableObject : MonoBehaviour
{
    [SerializeField] SimpleRaycaster _gridAvailabiltyChecker;

    public bool CanBePlaced()
    {
        return _gridAvailabiltyChecker.IsAvailable();
    }
}
