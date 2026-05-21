using UnityEngine;

public class Pusher : MonoBehaviour
{
    //アクセス修飾子
    public float speed = 1f;
    public float movePower = 5f;
    private Vector3 startPosition;
    private Rigidbody rb;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    　void Start()
    {
        Debug.Log("ゲームが開始した");
        // 自身に付いているgidbodyコンポーネントを取得して、変数rbに入れる
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float z = Mathf.Sin(Time.time * speed) * movePower;
        // 自身のローカル座標の位置を　最初の位置情報に　ｚ（Sin波の変動値）を加算して返す
        //this.transform.localPosition = startPosition + new Vector3(0, 0, z);
        rb.linearVelocity =new Vector3(0, 0, z);
    }
}
