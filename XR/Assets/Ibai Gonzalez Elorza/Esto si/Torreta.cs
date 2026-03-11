using UnityEngine;

public class Torreta : MonoBehaviour
{
    [SerializeField] GameObject proyectile;
    [SerializeField] float rotSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(0, rotSpeed * Time.deltaTime, 0);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(0, -rotSpeed * Time.deltaTime, 0);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate<GameObject>(proyectile, transform.position, transform.rotation);
        }
    }
}
