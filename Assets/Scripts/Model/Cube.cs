using UnityEngine;

public class Cube : MonoBehaviour
{
    public int speed;
    public int time;
    public int distance;
    private Vector3 startPos;
    private bool isMove;

    public void Move()
    {
        startPos = transform.position;
        isMove = true;
    }
    private void Update()
    {
        if (isMove)
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
            if (Vector3.Distance(startPos, transform.position) >= distance)
            {
                Destroy(gameObject);    
            }
        } 
        
    }
}
