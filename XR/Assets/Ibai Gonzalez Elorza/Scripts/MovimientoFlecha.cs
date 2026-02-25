using UnityEngine;

public class MovimientoFlecha : MonoBehaviour
{
    public float speed;
    public float ratationSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position = new Vector3(0, 0, transform.position + speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            this.transform.position = new Vector3(0, 0, transform.position - speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.D)
        {

        }

        else if(Input.GetKey(KeyCode.A)
        {

        }
        
    }
}
