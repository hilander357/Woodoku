using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Main : MonoBehaviour
{

    private Camera _camera;
    private Vector3 _startPosition;
    private int[] _rnd = new int[3];
    public static byte[] prefabSizeId = new byte[3];
    public GameObject[] prefabsList;
    public static List<GameObject> selectedPrebabsList;
    public static int finishedMovingBox = 0;
    public static List<GameObject> playGraundPrefabList = new List<GameObject>();
    public static bool[,] playGraund = new bool[11, 11];
    public static Main main;

    private byte[] _prefabSize = new byte[] { 5, 3, 4, 1, 5, 3 };
    public static bool[,,] prefab = new bool[,,] {
        { {true,  true, true, },{false, false,true },{false,false,true  } },
        { { false,true, false },{ false,true,false },{ false, true,false} },
        { { true, true, false },{ true, true,false },{ false,false,false} },
        { { false,false,false },{ false,true,false },{ false,false,false} },
        { { true, true, true  },{ false,true,false },{ false,true,false } },
        { { false,false,false },{ true, true,true }, { false,false,false} }
    };
    /////////////////////////////////////////////////////////////////////////////
    private void Awake()
    {
        selectedPrebabsList = new List<GameObject>();
        _camera = GetComponent<Camera>();
        main = this;
    }

    private void Start()
    {
        CreateNewMovingBox();
    }

    public void Head()
    {

        if (finishedMovingBox == 3)
        {
            for (int i = selectedPrebabsList.Count; i >= 0; i--)
            {
                Destroy(selectedPrebabsList[0]);
            }

            finishedMovingBox = 0;
            CreateNewMovingBox();
        }
    }

    private void CreateNewMovingBox()
    {
        for (int i = 0; i < 3; i++)
        {
            _rnd[i] = Random.Range(0, 6);
            prefabSizeId[i] = byte.Parse(_rnd[i].ToString());


            switch (i)
            {
                case 0:
                    _startPosition = new Vector3(0.495f, -12, 0);
                    break;
                case 1:
                    _startPosition = new Vector3(4.019f, -12, 0);
                    break;
                case 2:
                    _startPosition = new Vector3(7.546f, -12, 0);
                    break;
            }

            prefabsList[_rnd[i]].transform.position = _startPosition;
            selectedPrebabsList.Add(Instantiate(prefabsList[_rnd[i]]));
            _startPosition += new Vector3(0, 0);
        }
    }
}
