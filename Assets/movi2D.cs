using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movi2D : MonoBehaviour
{
    public float velocidade;
    void Start()
    {
        Debug.Log("Metodo de start de "+this.name);
        velocidade = 6.0f;
        transform.position = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime*velocidade);
    }
}
