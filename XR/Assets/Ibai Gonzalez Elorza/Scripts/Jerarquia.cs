using UnityEngine;

public class Jerarquia : MonoBehaviour
{
    public GameObject padre;
    public GameObject hijo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hijo.transform.SetParent(padre.transform);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))
        {
            Debug.Log(padre.transform.childCount);
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log(padre.transform.GetChild(0).gameObject.name);
        }
    }
}
