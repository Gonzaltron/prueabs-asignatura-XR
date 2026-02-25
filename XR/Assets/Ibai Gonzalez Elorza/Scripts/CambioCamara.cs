using UnityEngine;

public class CambioCamara : MonoBehaviour
{
    [SerializeField] Camera camInicial;
    [SerializeField] Camera camNueva;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        camInicial.enabled = true;
        camNueva.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            camInicial.enabled = !camInicial.enabled;
            camNueva.enabled = !camNueva.enabled;
        }
    }
}
