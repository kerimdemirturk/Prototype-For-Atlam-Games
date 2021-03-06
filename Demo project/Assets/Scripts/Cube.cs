using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cube : MonoBehaviour
{
    static int staticID = 0;
    //array for numbers text on cube
    [SerializeField] private TMP_Text[] numberText;

    //cubes components and variables about cubes
    [HideInInspector] public int CubeID;
    [HideInInspector] public Color CubeColor;
    [HideInInspector] public int CubeNumber;
    [HideInInspector] public Rigidbody cubeRb;
    [HideInInspector] public bool isİtMainCube;

    private MeshRenderer cubeMeshRen;

    private void Awake()
    {
        //access cubes components
        CubeID = staticID++;
        cubeMeshRen = GetComponent<MeshRenderer>();
        cubeRb = GetComponent<Rigidbody>();
    }

    //Set color to cubes.
    public void GiveColor(Color color)
    {
        CubeColor = color;
        cubeMeshRen.material.color = color;
    }

    //Setting a loop for give random value to cube.
    public void GiveNumber(int number)
    {
        CubeNumber = number;
        for(int i = 0; i<6; i++)
        {
            numberText[i].text = number.ToString();
        }
    }


    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
