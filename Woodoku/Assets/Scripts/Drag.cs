using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MovingBoxController
{
    public void Moving(Transform tr, int id)
    {
        tr.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + Vector3.forward;
        _selectedPrefabListGameObject[id].transform.position = tr.position += Vector3.forward;
    }
}
