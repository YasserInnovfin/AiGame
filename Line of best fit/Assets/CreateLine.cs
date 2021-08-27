using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLine : MonoBehaviour
{
    // Start is called before the first frame update
    private LineRenderer lineRenderer;
    private Vector2 mousePos;
    private Vector2 StartMousePos;

    [SerializeField] private TextAlignment Slope;
    private float distance;

    void Start()
    { 

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            StartMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if(Input.GetMouseButtonUp(0)){
                    GameObject go1 = new GameObject();
                    lineRenderer = go1.AddComponent<LineRenderer>();
        lineRenderer.widthMultiplier = 0.1f;
        lineRenderer.positionCount =2;

            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            lineRenderer.SetPosition(0, new Vector3(StartMousePos.x,StartMousePos.y,0f));
            lineRenderer.SetPosition(1, new Vector3(mousePos.x,mousePos.y,0f));
            
        }
    }
}
