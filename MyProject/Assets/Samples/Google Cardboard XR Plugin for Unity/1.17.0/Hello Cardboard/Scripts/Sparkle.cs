using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sparkle : MonoBehaviour
{
    // Start is called before the first frame update
 // Start is called before the first frame update
   
    
    private Vector3 _startingPosition;
    private bool IsTriggerPressed = false;
    private bool IsGazedCapsule = false;
  
   
    

    /// <summary>
    /// Start is called before the first frame update.
    /// </summary>
    public void Start()
    {
        _startingPosition = transform.parent.localPosition;
         
    
       
    }

    public void OnPointerEnterCapsule()
    {
        
        IsGazedCapsule = true;
          GameObject.Find("Capsule").GetComponent<ParticleSystem>().enableEmission = true;
           
    }

  

   
    public void OnPointerExit()
    {
      
       IsGazedCapsule = false;
       GameObject.Find("Capsule").GetComponent<ParticleSystem>().enableEmission = true;
        
      
}


    public void OnPointerClick()
    {   
        IsGazedCapsule = true;
   
       
    }

   
    public void Update()
    { 
       if(IsGazedCapsule){
          GameObject.Find("Capsule").GetComponent<ParticleSystem>().enableEmission = true;
       }
       
    }
}
