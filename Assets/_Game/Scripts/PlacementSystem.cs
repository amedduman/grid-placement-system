using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementSystem : MonoBehaviour
{
    [SerializeField] Transform _selectedGridIndicator;
    InputManager _inputManager;
    Grid _grid;

    private void Awake()
    {
        _inputManager = ServiceLocator.Get<InputManager>();
        _grid = ServiceLocator.Get<Grid>();
    }

    // Update is called once per frame
    void Update()
    {
        _selectedGridIndicator.position = _inputManager.GetSelectedMapPosition();
        Vector3Int cellPos = _grid.WorldToCell(_inputManager.GetSelectedMapPosition());
        _selectedGridIndicator.position = cellPos;
    }
}
