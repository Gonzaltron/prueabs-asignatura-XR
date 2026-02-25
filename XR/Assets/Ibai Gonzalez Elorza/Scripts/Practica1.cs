using UnityEngine;
using System.Collections.Generic;

public class Practica1 : MonoBehaviour
{
    int mesass;
    public GameObject[] mesas;
    [SerializeField] GameObject mesa;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(mesa);
        mesass++;
        GameObject temp = Instantiate(mesa);
        mesass++;
        temp.transform.position = new Vector3(2, 2, 2);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.M))
        {
            mesas = GameObject.FindGameObjectsWithTag("Mesa");
            for(int i = 0; i < mesass; i++)
            {
                Debug.Log(mesas[i].transform.GetChild(0).transform.position);
                Debug.Log(mesas[i].transform.GetChild(1).transform.position);
                Debug.Log(mesas[i].transform.GetChild(2).transform.position);
                Debug.Log(mesas[i].transform.GetChild(3).transform.position);
                mesas[i].transform.GetChild(4).GetComponent<MeshRenderer>().material.color = Color.black;
            }
        }
    }
}
