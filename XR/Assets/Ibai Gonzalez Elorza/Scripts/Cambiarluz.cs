using UnityEngine;

public class Cambiarluz : MonoBehaviour
{
    [SerializeField] GameObject luz;
    bool active = true;
    bool activeC = true;
    [SerializeField] GameObject camara1;
    [SerializeField] GameObject camara2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        camara1.SetActive(true);
        camara2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            if(active)
            {
                active = false;
                luz.SetActive(false);
            }
            else if(!active)
            {
                active = true;
                luz.SetActive(true);
            }
        }
        if(Input.GetKeyDown(KeyCode.C))
        {
            if(activeC)
            {
                activeC = false;
                camara1.SetActive(false);
                camara2.SetActive(true);
            }
            else if(!activeC)
            {
                activeC = true;
                camara1.SetActive(true);
                camara2.SetActive(false);
            }
        }
    }
}
