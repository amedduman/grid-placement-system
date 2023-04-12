using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementSystem : MonoBehaviour
{
    [SerializeField] GridPlaceableObject _obj;
    [SerializeField] Transform _selectedGridIndicator;
    InputManager _inputManager;
    Grid _grid;

    private void Awake()
    {
        _inputManager = ServiceLocator.Get<InputManager>();
        _grid = ServiceLocator.Get<Grid>();
    }

    void Update()
    {
        _selectedGridIndicator.position = _inputManager.GetSelectedMapPosition();
        Vector3Int cellPos = _grid.WorldToCell(_inputManager.GetSelectedMapPosition());
        //_selectedGridIndicator.position = cellPos;
        var cellCenterPos = _grid.GetCellCenterWorld(cellPos);
        _selectedGridIndicator.position = new Vector3(cellCenterPos.x, _selectedGridIndicator.transform.position.y, cellCenterPos.z);
    }
}
