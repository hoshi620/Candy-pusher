using UnityEngine;
using UnityEngine.InputSystem;

public class CreateCandy : MonoBehaviour
{

    private int CandyCount = 0;
    public GameObject CandyPrefab;
    public GameObject[] CandyPrefabs;
    float time = 0f;
    void AddCandy()
    {
        CandyCount = CandyCount + 1;
        Debug.Log(CandyCount);

        int rand = Random.Range(0, 100);
        int candyType = 0;
        
        if(rand < 5)
        {
            candyType = 0;
        }
        else if(rand < 80)
        {
            candyType = 1;
        }
        else if(rand < 99)
        {
            candyType = 2;
        }
            //オブジェクトの生成方法
            //型　変数　＝　初期値(Instantiateで作られたオブジェクト)
            GameObject creatPrefab = Instantiate(CandyPrefabs[candyType]);
        
        creatPrefab.transform.position = this.transform.position;
    }
    void Start()
    {
        AddCandy();



    }

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            AddCandy();
        }
    }
}  