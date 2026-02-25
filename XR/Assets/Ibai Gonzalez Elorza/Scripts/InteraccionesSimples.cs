using UnityEngine;

public class InteraccionesSimples : MonoBehaviour
{
    public PropiedadesJugador valores;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("up"))
        {
            Debug.Log("arriba");
        }
        else if(Input.GetKeyDown("down"))
        {
                Debug.Log("abajo");
        }
        else if (Input.GetKeyUp(KeyCode.K))
        {
            Debug.Log("K");
        }
        else if (Input.GetKeyUp(KeyCode.N))
        {
            Debug.Log(valores.nombre + " " + valores.password);
        }
        else if (Input.GetKeyUp(KeyCode.C))
        {
            GameObject.Find("Hijo").GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
}
