using UnityEngine;

public class CrearDestruir : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject.CreatePrimitive(PrimitiveType.Sphere);
            GameObject micubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
            micubo.transform.position = new Vector3(2, 2, 2);
        }
        else if(Input.GetKeyDown(KeyCode.T))
        {
            Instantiate(prefab);
        }
    }
}
