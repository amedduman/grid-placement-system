using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    [Multiline(10)] [TextArea]
    [SerializeField] string _shapeInfo;
    string[] _lines;
    // Start is called before the first frame update
    void Start()
    {
        _lines = _shapeInfo.Split();
        foreach (var item in _lines)
        {
            Debug.Log(item);
        }

        for (int i = 0; i < _shapeInfo.Length; i++)
        {
            if(_shapeInfo[i] == '1')
            {

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
