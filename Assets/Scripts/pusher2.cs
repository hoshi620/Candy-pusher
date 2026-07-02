using UnityEngine;

public class pusher2: MonoBehaviour
{

    private Vector3 startPosition;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = this.transform.position;
        Debug.Log("ÉQÅ[ÉÄÇ™äJénÇµÇΩ");
        
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Sin(Time.time * 1f)*3f;
        this.transform.position = startPosition + new Vector3(x, 0, 0);
    }
}
