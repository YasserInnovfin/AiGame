using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePoints : MonoBehaviour
{

     public Texture2D tex;
   public Transform prefab;
   int i;
    // Start is called before the first frame update
    void Start()
    {i = 0;
         
    }

    // Update is called once per frame
   public void getPoints()
    {
        if(i<20){
        for(int point=0;point<4;point++){
            float RandomX = Random.Range(-4.62f,5.3f);
            float RandomY = Random.Range(-2.59f,3.7f);
            Instantiate(prefab,new Vector3(RandomX, RandomY,0), Quaternion.identity);
            i++;
        }
        }
    }
}
