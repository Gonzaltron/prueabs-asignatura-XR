using UnityEngine;

public class Tanque : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float rotSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward * Time.deltaTime * 5);
        }
        if(Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(-Vector3.forward * Time.deltaTime *5);
        }
        if(Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(0, -rotSpeed * Time.deltaTime, 0, Space.Self);
        }
        if(Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(0, rotSpeed * Time.deltaTime, 0, Space.Self);
        }
    }
}
