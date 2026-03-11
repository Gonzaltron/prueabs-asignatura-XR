using UnityEngine;

public class Interpolaciones : MonoBehaviour
{
    [SerializeField] GameObject cubo;
    Vector3 initialPos = Vector3.zero;
    Vector3 endPos = new Vector3(10, 0, 0);
    float moveTime = 0;
    [SerializeField] float moveDuration = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveTime += Time.deltaTime;
        float t = moveTime / moveDuration;
        cubo.transform.position = Vector3.Lerp(initialPos, endPos, t);
    }
}
