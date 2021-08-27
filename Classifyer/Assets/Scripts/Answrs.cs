using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answrs : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public Color color;
    public void whatColor(Color newCOL){
        color = newCOL;
    }
}
