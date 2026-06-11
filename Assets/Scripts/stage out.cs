using TMPro;
using UnityEngine;

public class stageout : MonoBehaviour
{
    //  変数Scoreの値をUIとして表示する
    public TextMeshProUGUI scoreText;

    //　アクセス修飾子 型　変数名
    private int Score;

    // このコードをアタッチしたオブジェクトに他のオブジェクトがすり抜けた時に呼ばれる
    void OnTriggerEnter(Collider other)
    {


        Score = Score + 1;
        Debug.Log($"スコア：{Score}");

        //Debug.Log($"{ other.name}がすり抜けた");
        // すり抜けたオブジェクトを破棄
        Destroy(other.gameObject);
    }
}
