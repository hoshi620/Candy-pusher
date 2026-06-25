using UnityEngine;
using UnityEngine.InputSystem;

public class CreateCandy : MonoBehaviour
{
    private int CandyCount = 0;

    public GameObject CandyPrefab;
    void AddCandy()
    {
        CandyCount = CandyCount + 1;
        Debug.Log(CandyCount);

        //オブジェクトの生成方法
        //型　変数　＝　初期値(Instantiateで作られたオブジェクト)
        GameObject creatPrefab = Instantiate(CandyPrefab);
        // position
        creatPrefab.transform.position = this.transform.position;
    }
    void Start()
    {
        AddCandy();



    }

    void Update()
    {
        if (Keyboard.current.spaceKey.isPressed)
        {
            AddCandy();
        }
    }
}  