using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode2 : MonoBehaviour
{
     private Renderer _myRendererCube;
    private Renderer _myRendererSphere;
    private Vector3 _startingPosition1;
    private bool IsTriggerPressed = false;
    private bool IsGazed = false;
 
 
    

    /// <summary>
    /// Start is called before the first frame update.
    /// </summary>
    public void Start()
    {
        _startingPosition1 = transform.parent.localPosition;
      
        
        //GameObject.Find("Cube").GetComponent<Renderer>().material.color = Color.white;
       
    }

    

   
    public void OnPointerEnterCapsule1()
    {
        //SetMaterialSphere(true);
        IsGazed = true;
        
    }

  

   
    public void OnPointerExit()
    {
      
       
      
      

        

        
       
    }

    /// <summary>
    /// This method is called by the Main Camera when it is gazing at this GameObject and the screen
    /// is touched.
    /// </summary>
    public void OnPointerClick()
    {   
        IsGazed = true;
   
       
    }

   
    public void Update()
    { 
       
           
         if(GameObject.Find("Capsule1") == null ){
           transform.Translate(Vector3.down * Time.deltaTime*10);
           
          
         
        
         
    }
   
    //    if(!IsGazedSphere)
    //      {
    //       print("hey"); 
    //       //transform.position = new Vector3(18,400,69);
    //       IsGazedSphere=false;

    //      }

          // if(IsGazedCube)
    
    // {       
    //    // GameObject.Find("Cube").GetComponent<Renderer>().material.color = new Color(0, 204, 102);
    //     //gameObject.GetComponent<Renderer>().material.color = Color.red;
    //     GameObject.Find("Cube").GetComponent<Renderer>().material.color = Color.green;

    // }
        //   if(!IsGazedCube)
        //   {
          
        //   //GameObject.Find("Cube").GetComponent<Renderer>().material.color = Color.white;
        //   SetMaterial(false);
        //    //IsGazedCube=false;





        }
}
