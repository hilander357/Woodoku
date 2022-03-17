using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Moving : MonoBehaviour
{
    private Vector3[] _spawnPosition = new Vector3 [3];
    public byte movingBoxId;

    private void Awake()
    {
        _spawnPosition[0] = new Vector3(0.495f, -12, 0);
        _spawnPosition[1] = new Vector3(4.019f, -12, 0);
        _spawnPosition[2] = new Vector3(7.546f, -12, 0);
    }

    public void MovingColider(Transform tr)
    {
        tr.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + Vector3.forward;
        Main.selectedPrebabsList[movingBoxId].transform.position = tr.position;
    } 

    public void EndMoving(Transform tr)
    {
        tr.position = new Vector3(int.Parse(Math.Round(tr.position.x).ToString()),
            int.Parse(Math.Round(tr.position.y).ToString()), 0);
        Main.selectedPrebabsList[movingBoxId].transform.position = tr.position;

        switch (Main.prefabSizeId[movingBoxId])
        {

            case 1:
                if (tr.position.x <= -1)
                {
                    tr.position = _spawnPosition[movingBoxId];
                    Main.selectedPrebabsList[movingBoxId].transform.position = tr.position;
                }
                else
                if (tr.position.x >= 9)
                {
                    tr.position = _spawnPosition[movingBoxId];
                    Main.selectedPrebabsList[movingBoxId].transform.position = tr.position;
                }
                else
                if (tr.position.y >= 0)
                {
                    tr.position = _spawnPosition[movingBoxId];
                    Main.selectedPrebabsList[movingBoxId].transform.position = tr.position;
                }
                else
                if (tr.position.y <= -8)
                {
                    tr.position = _spawnPosition[movingBoxId];
                    Main.selectedPrebabsList[movingBoxId].transform.position = tr.position;
                }
                else
                {
                    ProtectionBox(tr);
                }
                break;
            case 2:
                if (tr.position.x <= 0)
                {
                    tr.position = _spawnPosition[movingBoxId];
                    Main.selectedPrebabsList[movingBoxId].transform.position = tr.position;
                }
                else
                if (tr.position.x >= 9)
                {
                    tr.position = _spawnPosition[movingBoxId];
                    Main.selectedPrebabsList[movingBoxId].transform.position = tr.position;
                }
                else
                if (tr.position.y >= 0)
                {
                    tr.position = _spawnPosition[movingBoxId];
                    Main.selectedPrebabsList[movingBoxId].transform.position = tr.position;
                }
                else
                if (tr.position.y <= -9)
                {
                    tr.position = _spawnPosition[movingBoxId];
                    Main.selectedPrebabsList[movingBoxId].transform.position = tr.position;
                }
                else
                {
                    ProtectionBox(tr);
                }
                break;
            case 3:
                if (tr.position.x <= -1)
                {
                    tr.position = _spawnPosition[movingBoxId];
                    Main.selectedPrebabsList[movingBoxId].transform.position = tr.position;
                }
                else
                if (tr.position.x >= 9)
                {
                    tr.position = _spawnPosition[movingBoxId];
                    Main.selectedPrebabsList[movingBoxId].transform.position = tr.position;
                }
                else
                if (tr.position.y >= 1)
                {
                    tr.position = _spawnPosition[movingBoxId];
                    Main.selectedPrebabsList[movingBoxId].transform.position = tr.position;
                }
                else
                if (tr.position.y <= -9)
                {
                    tr.position = _spawnPosition[movingBoxId];
                    Main.selectedPrebabsList[movingBoxId].transform.position = tr.position;
                }
                else
                {
                    ProtectionBox(tr);
                }
                break;
            case 5:
                if (tr.position.x <= 0)
                {
                    tr.position = _spawnPosition[movingBoxId];
                    Main.selectedPrebabsList[movingBoxId].transform.position = tr.position;
                }
                else
                if (tr.position.x >= 8)
                {
                    tr.position = _spawnPosition[movingBoxId];
                    Main.selectedPrebabsList[movingBoxId].transform.position = tr.position;
                }
                else
                if (tr.position.y >= 1)
                {
                    tr.position = _spawnPosition[movingBoxId];
                    Main.selectedPrebabsList[movingBoxId].transform.position = tr.position;
                }
                else
                if (tr.position.y <= -9)
                {
                    tr.position = _spawnPosition[movingBoxId];
                    Main.selectedPrebabsList[movingBoxId].transform.position = tr.position;
                }
                else
                {
                    ProtectionBox(tr);
                }
                break;
            default:
                if (tr.position.x <= 0)
                {
                    tr.position = _spawnPosition[movingBoxId];
                    Main.selectedPrebabsList[movingBoxId].transform.position = tr.position;
                }
                else
                if (tr.position.x >= 8)
                {
                    tr.position = _spawnPosition[movingBoxId];
                    Main.selectedPrebabsList[movingBoxId].transform.position = tr.position;
                }
                else
                if (tr.position.y >= 0)
                {
                    tr.position = _spawnPosition[movingBoxId];
                    Main.selectedPrebabsList[movingBoxId].transform.position = tr.position;
                }
                else
                if (tr.position.y <= -8)
                {
                    tr.position = _spawnPosition[movingBoxId];
                    Main.selectedPrebabsList[movingBoxId].transform.position = tr.position;
                }
                else
                {
                    ProtectionBox(tr);
                }
                break;
        }


    }

    private void ProtectionBox(Transform tr)
    {

        Debug.Log($"X:{tr.position.x} Y: {tr.position.y}");
        bool protector = false;
        if (Main.prefab[Main.prefabSizeId[movingBoxId], 0, 0] == true && Main.playGraund[int.Parse((tr.position.x ).ToString()), int.Parse((tr.position.y).ToString())])
        {
            protector = true;
        }
        else
            if (Main.prefab[Main.prefabSizeId[movingBoxId], 0, 1] == true && Main.playGraund[int.Parse((tr.position.x + 1).ToString()), int.Parse((tr.position.y).ToString())])
        {
            protector = true;
        }
        else
            if (Main.prefab[Main.prefabSizeId[movingBoxId], 0, 2] == true && Main.playGraund[int.Parse((tr.position.x + 2).ToString()), int.Parse((tr.position.y).ToString())])
        {
            protector = true;
        }
        else
            if (Main.prefab[Main.prefabSizeId[movingBoxId], 1, 0] == true && Main.playGraund[int.Parse((tr.position.x ).ToString()), int.Parse((tr.position.y - 1).ToString())])
        {
            protector = true;
        }
        else
            if (Main.prefab[Main.prefabSizeId[movingBoxId], 1, 1] == true && Main.playGraund[int.Parse((tr.position.x + 1).ToString()), int.Parse((tr.position.y - 1).ToString())])
        {
            protector = true;
        }
        else
            if (Main.prefab[Main.prefabSizeId[movingBoxId], 1, 2] == true && Main.playGraund[int.Parse((tr.position.x + 2).ToString()), int.Parse((tr.position.y - 1).ToString())])
        {
            protector = true;
        }
        else
             if (Main.prefab[Main.prefabSizeId[movingBoxId], 2, 0] == true && Main.playGraund[int.Parse((tr.position.x).ToString()), int.Parse((tr.position.y - 2).ToString())])
        {
            protector = true;
        }
        else
             if (Main.prefab[Main.prefabSizeId[movingBoxId], 2, 1] == true && Main.playGraund[int.Parse((tr.position.x + 1).ToString()), int.Parse((tr.position.y - 2).ToString())])
        {
            protector = true;
        }
        else
              if (Main.prefab[Main.prefabSizeId[movingBoxId], 2, 2] == true && Main.playGraund[int.Parse((tr.position.x + 2).ToString()), int.Parse((tr.position.y - 2).ToString())])
        {
            protector = true;
        }

        if (protector)
        {
            tr.position = _spawnPosition[movingBoxId];
            Main.selectedPrebabsList[movingBoxId].transform.position = tr.position;

        }
        else
        {

            tr.position += new Vector3(0, 0, 30);
            if (Main.prefab[Main.prefabSizeId[movingBoxId],0,0]){
                Main.playGraund[int.Parse((tr.position.x).ToString()), int.Parse((-tr.position.y).ToString())] = true;
            }
            if (Main.prefab[Main.prefabSizeId[movingBoxId], 0, 1])
            {
                Main.playGraund[int.Parse((tr.position.x + 1).ToString()), int.Parse((-tr.position.y).ToString())] = true;
            }
            if (Main.prefab[Main.prefabSizeId[movingBoxId], 0, 2])
            {
                Main.playGraund[int.Parse((tr.position.x + 2).ToString()), int.Parse((-tr.position.y).ToString())] = true;
            }
            if (Main.prefab[Main.prefabSizeId[movingBoxId], 1, 0])
            {
                Main.playGraund[int.Parse((tr.position.x).ToString()), int.Parse((-tr.position.y + 1).ToString())] = true;
            }
            if (Main.prefab[Main.prefabSizeId[movingBoxId], 1, 1])
            {
                Main.playGraund[int.Parse((tr.position.x + 1).ToString()), int.Parse((-tr.position.y + 1).ToString())] = true;
            }
            if (Main.prefab[Main.prefabSizeId[movingBoxId], 1, 2])
            {
                Main.playGraund[int.Parse((tr.position.x + 2).ToString()), int.Parse((-tr.position.y + 1).ToString())] = true;
            }

            if (Main.prefab[Main.prefabSizeId[movingBoxId], 2, 0])
            {
                Main.playGraund[int.Parse((tr.position.x).ToString()), int.Parse((-tr.position.y + 2).ToString())] = true;
            }
            if (Main.prefab[Main.prefabSizeId[movingBoxId], 2, 1])
            {
                Main.playGraund[int.Parse((tr.position.x + 1).ToString()), int.Parse((-tr.position.y + 2).ToString())] = true;
            }
            if (Main.prefab[Main.prefabSizeId[movingBoxId], 2, 2])
            {
                Main.playGraund[int.Parse((tr.position.x + 2).ToString()), int.Parse((-tr.position.y + 2).ToString())] = true;
            }
            Main.selectedPrebabsList[movingBoxId].transform.position = tr.position;
            Main.finishedMovingBox++;
            

        }
    }

}
