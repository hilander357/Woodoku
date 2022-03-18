using UnityEngine;


public class MovingBoxController : Main
{
    [SerializeField] private GameObject[] _prefabList;
    private int[] _selectedPrefabListId;
    protected GameObject[] _selectedPrefabListGameObject;


    private void Awake()
    {
        _selectedPrefabListId = new int[3];
        _selectedPrefabListGameObject = new GameObject[3];
    }

    private void Start()
    {
        CreateBox();
    }
    private void CreateBox()
    {
        Vector3[] _spawnPosition = new Vector3[3] 
        {new Vector3(0.495f, -12f, 0f), new Vector3(4.019f, -12f, 0f) , new Vector3(7.546f, -12, 0)};


        for(int i = 0; i < 3; i++)
        {
            _selectedPrefabListId[i] = int.Parse(Random.Range(0, 5).ToString());
            
            _selectedPrefabListGameObject[i] = Instantiate(_prefabList[_selectedPrefabListId[i]]);
            _selectedPrefabListGameObject[i].transform.position = _spawnPosition[i];
        }
    }
}
