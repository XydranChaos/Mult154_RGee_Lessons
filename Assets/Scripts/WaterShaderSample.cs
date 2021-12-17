using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterShaderSample : MonoBehaviour
{
    private Renderer rend;
    public Color setColor = Color.green;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        rend.material.SetColor("Color_853dd49bd37d4e4dae0695e3bdc95ae9", setColor);
    }
}
