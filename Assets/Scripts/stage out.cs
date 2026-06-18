using UnityEngine;
using TMPro;

public class stageout : MonoBehaviour
{
    private int Score=0;
    public TextMeshProUGUI scoreText;

    // このコードをアタッチしたオブジェクトに他のオブジェクトがすり抜けた時に呼ばれる
    // かつ他のオブジェクトがすり抜けた時に中の処理を行うイベント関数
    void OnTriggerEnter(Collider other)
    {
       Score += 1;



       scoreText.text = $"スコア:{Score}";


       //変数名　otherってなに？
       Debug.Log($"{ other.name}がすり抜けた");
       // すり抜けたオブジェクトを破棄
       Destroy(other.gameObject);
    }
}
