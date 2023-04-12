using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class GridObjectDatabaseSO : ScriptableObject
{
    public List<GridObject> _gridObjectList;
}

[System.Serializable]
public class GridObject
{
    [Multiline(10)] public string ShapeInfo;
    public GameObject ObjectPrefab;
}
