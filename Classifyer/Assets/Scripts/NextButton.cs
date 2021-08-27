using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class NextButton : MonoBehaviour


{
    [SerializeField] public RawImage Image1;
    [SerializeField] public RawImage Image2;
    [SerializeField] public RawImage Image3;
    [SerializeField] public RawImage Image4;
    [SerializeField] public RawImage Image5;
    [SerializeField] public RawImage Image6;
    [SerializeField] public RawImage Image7;
    [SerializeField] public RawImage Image8;
    [SerializeField] public RawImage Image9;

    [SerializeField] public Button Dog;
    [SerializeField] public Button Cat;
    [SerializeField] public Button Butterfily;
    [SerializeField] public Button Chicken;
    [SerializeField] public Button Elephant;
    [SerializeField] public Button Horse;



public void AddPhotos(){
    string path;
   
    Dog.GetComponent<Image>().color = Color.white;
    Cat.GetComponent<Image>().color = Color.white;
    Butterfily.GetComponent<Image>().color = Color.white;
    Chicken.GetComponent<Image>().color = Color.white;
    Elephant.GetComponent<Image>().color = Color.white;
    Horse.GetComponent<Image>().color = Color.white;

    path = "Assets/Resources/Images";
    var files = Directory.GetDirectories(path);
    var result = files[Random.Range(0,files.Length)];
    var imagefolders = Directory.GetDirectories(result);
    string imagefolder = imagefolders[Random.Range(0,imagefolders.Length-1)];
    print (imagefolders[0]);

    var targetFile1 = Directory.GetFiles(imagefolder)[0];
    int indexOfImage = targetFile1.IndexOf("Images");
    string StrippedString= targetFile1.Substring(indexOfImage);
    int indexofpng = StrippedString.IndexOf(".png");
    string resultstr= StrippedString.Substring(0,indexofpng);
    var texture = Resources.Load<Texture2D>(resultstr);
    Image1.texture = texture;

     targetFile1 = Directory.GetFiles(imagefolder)[2];
     indexOfImage = targetFile1.IndexOf("Images");
     StrippedString= targetFile1.Substring(indexOfImage);
     indexofpng = StrippedString.IndexOf(".png");
     resultstr= StrippedString.Substring(0,indexofpng);
     var texture2 = Resources.Load<Texture2D>(resultstr);
    Image2.texture = texture2;

         targetFile1 = Directory.GetFiles(imagefolder)[4];
     indexOfImage = targetFile1.IndexOf("Images");
     StrippedString= targetFile1.Substring(indexOfImage);
     indexofpng = StrippedString.IndexOf(".png");
     resultstr= StrippedString.Substring(0,indexofpng);
     var texture3 = Resources.Load<Texture2D>(resultstr);
    Image3.texture = texture3;

         targetFile1 = Directory.GetFiles(imagefolder)[6];
     indexOfImage = targetFile1.IndexOf("Images");
     StrippedString= targetFile1.Substring(indexOfImage);
     indexofpng = StrippedString.IndexOf(".png");
     resultstr= StrippedString.Substring(0,indexofpng);
     var texture4 = Resources.Load<Texture2D>(resultstr);
    Image4.texture = texture4;

         targetFile1 = Directory.GetFiles(imagefolder)[8];
     indexOfImage = targetFile1.IndexOf("Images");
     StrippedString= targetFile1.Substring(indexOfImage);
     indexofpng = StrippedString.IndexOf(".png");
     resultstr= StrippedString.Substring(0,indexofpng);
     var texture5 = Resources.Load<Texture2D>(resultstr);
    Image5.texture = texture5;

         targetFile1 = Directory.GetFiles(imagefolder)[10];
     indexOfImage = targetFile1.IndexOf("Images");
     StrippedString= targetFile1.Substring(indexOfImage);
     indexofpng = StrippedString.IndexOf(".png");
     resultstr= StrippedString.Substring(0,indexofpng);
     var texture6 = Resources.Load<Texture2D>(resultstr);
    Image6.texture = texture6;

         targetFile1 = Directory.GetFiles(imagefolder)[12];
     indexOfImage = targetFile1.IndexOf("Images");
     StrippedString= targetFile1.Substring(indexOfImage);
     indexofpng = StrippedString.IndexOf(".png");
     resultstr= StrippedString.Substring(0,indexofpng);
     var texture7 = Resources.Load<Texture2D>(resultstr);
    Image7.texture = texture7;
    
         targetFile1 = Directory.GetFiles(imagefolder)[14];
     indexOfImage = targetFile1.IndexOf("Images");
     StrippedString= targetFile1.Substring(indexOfImage);
     indexofpng = StrippedString.IndexOf(".png");
     resultstr= StrippedString.Substring(0,indexofpng);
     var texture8 = Resources.Load<Texture2D>(resultstr);
    Image8.texture = texture8;

         targetFile1 = Directory.GetFiles(imagefolder)[16];
     indexOfImage = targetFile1.IndexOf("Images");
     StrippedString= targetFile1.Substring(indexOfImage);
     indexofpng = StrippedString.IndexOf(".png");
     resultstr= StrippedString.Substring(0,indexofpng);
     var texture9 = Resources.Load<Texture2D>(resultstr);
    Image9.texture = texture9;

    if(imagefolders[0].Contains("Dog")){
        Dog.GetComponent<Answrs>().color = Color.green;
    }
    else{
        Dog.GetComponent<Answrs>().color = Color.red;
    }
        if(imagefolders[0].Contains("cat")){
        Cat.GetComponent<Answrs>().color = Color.green;
    }
    else{
        Cat.GetComponent<Answrs>().color = Color.red;
    }

        if(imagefolders[0].Contains("butterfly")){
        Butterfily.GetComponent<Answrs>().color = Color.green;
    }
    else{
        Butterfily.GetComponent<Answrs>().color = Color.red;
    }

        if(imagefolders[0].Contains("chicken")){
        Chicken.GetComponent<Answrs>().color = Color.green;
    }
    else{
        Chicken.GetComponent<Answrs>().color = Color.red;
    }

        if(imagefolders[0].Contains("elephant")){
        Elephant.GetComponent<Answrs>().color = Color.green;
    }
    else{
        Elephant.GetComponent<Answrs>().color = Color.red;
    }
        if(imagefolders[0].Contains("Horse")){
        Horse.GetComponent<Answrs>().color = Color.green;
    }
    else{
        Horse.GetComponent<Answrs>().color = Color.red;
    }
}

public void getResults(){
    Dog.GetComponent<Image>().color =  Dog.GetComponent<Answrs>().color;
    Cat.GetComponent<Image>().color =  Cat.GetComponent<Answrs>().color;
    Butterfily.GetComponent<Image>().color =  Butterfily.GetComponent<Answrs>().color;
    Chicken.GetComponent<Image>().color =  Chicken.GetComponent<Answrs>().color;
    Elephant.GetComponent<Image>().color =  Elephant.GetComponent<Answrs>().color;
    Horse.GetComponent<Image>().color =  Horse.GetComponent<Answrs>().color;

}

}
