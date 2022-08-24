using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 _startingPosition;
    private bool IsTriggerPressed = false;
    private bool IsGazedCapsule1 = false;
  
   
    

    /// <summary>
    /// Start is called before the first frame update.
    /// </summary>
    public void Start()
    {
        _startingPosition = transform.parent.localPosition;
         
    
       
    }

    public void OnPointerEnterCapsule1()
    {
        
        IsGazedCapsule1 = true;
        GameObject.Find("Capsule1").GetComponent<ParticleSystem>().enableEmission = true;
          GameObject.Find("Capsule1").SetActive(false);
            GameObject.Find("sphere1").GetComponent<MeshRenderer>().enabled = true;
           GameObject.Find("sphere2").GetComponent<MeshRenderer>().enabled = true;
           GameObject.Find("sphere3").GetComponent<MeshRenderer>().enabled = true;
           GameObject.Find("sphere4").GetComponent<MeshRenderer>().enabled = true;
           
    }

  

   
    public void OnPointerExit()
    {
      
       IsGazedCapsule1 = false;
       
        
      
}


    public void OnPointerClick()
    {   
        IsGazedCapsule1 = true;
   
       
    }

   
    public void Update()
    { 
       if(IsGazedCapsule1){
            GameObject.Find("sphere1").transform.Translate(Vector3.down * Time.deltaTime*10);
              GameObject.Find("sphere2").transform.Translate(Vector3.down * Time.deltaTime*10);
                GameObject.Find("sphere3").transform.Translate(Vector3.down * Time.deltaTime*10);
                  GameObject.Find("sphere4").transform.Translate(Vector3.down * Time.deltaTime*10);
       }
       
    }
}
