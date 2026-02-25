using UnityEngine;

public class Generarcubo : MonoBehaviour
{
    [SerializeField] GameObject cube;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject temp = Instantiate(cube);
        temp.transform.position = new Vector3(1, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
