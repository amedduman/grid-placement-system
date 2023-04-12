using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementSystem : MonoBehaviour
{
    [SerializeField] GridObjectDatabaseSO _database;
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
        var worldPos = _inputManager.GetSelectedMapPosition();
        Vector3Int cellPos = _grid.WorldToCell(worldPos);
        var cellCenterPos = _grid.GetCellCenterWorld(cellPos);
        _selectedGridIndicator.position = new Vector3(cellCenterPos.x, _selectedGridIndicator.transform.position.y, cellCenterPos.z);


        var cellWorldPos = _grid.CellToWorld(cellPos);




        if(Input.GetMouseButtonDown(0))
        {
            var objPrf = _database._gridObjectList[0].ObjectPrefab;
            var obj = Instantiate(objPrf, cellWorldPos, Quaternion.identity);
            UpdateAvailabityOfCells(cellPos, _database._gridObjectList[0].ShapeInfo);
        }
    }

    private void UpdateAvailabityOfCells(Vector3Int startingCellPos, string shapeInfo)
    {
        string[] lines = shapeInfo.Split();
        foreach (var item in lines)
        {
            Debug.Log(item);
        }

        for (int i = 0; i < shapeInfo.Length; i++)
        {
            if (shapeInfo[i] == '1')
            {

            }
        }
    }
}
