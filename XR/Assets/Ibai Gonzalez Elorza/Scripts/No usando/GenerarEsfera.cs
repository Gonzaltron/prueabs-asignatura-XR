using UnityEngine;

public class GenerarEsfera : MonoBehaviour
{
    [SerializeField] GameObject sphere;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        GameObject temp = Instantiate(sphere);
        temp.transform.position = new Vector3(2, 2, 2);
    }
}
