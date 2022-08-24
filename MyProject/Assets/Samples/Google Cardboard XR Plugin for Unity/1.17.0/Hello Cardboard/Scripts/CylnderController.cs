using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylnderController : MonoBehaviour
{
    
    // The objects are about 1 meter in radius, so the min/max target distance are
    // set so that the objects are always within the room (which is about 5 meters
    // across).
    //private const float _minObjectDistance = 2.5f;
    //private const float _maxObjectDistance = 3.5f;
    //private const float _minObjectHeight = 0.5f;
    //private const float _maxObjectHeight = 3.5f;

    private Renderer _myRendererCylinder;
    private Vector3 _startingPosition;
    private bool IsTriggerPressed = false;
    private bool IsGazedCylinder = false;
  
   
    

    /// <summary>
    /// Start is called before the first frame update.
    /// </summary>
    public void Start()
    {
        _startingPosition = transform.parent.localPosition;
         
    
       
    }

    public void OnPointerEnterCylinder()
    {
        
        IsGazedCylinder = true;
        GameObject.Find("Cylinder").SetActive(false);
           
           GameObject.Find("Cube2").GetComponent<Renderer>().enabled = true;
        
    }

  

   
    public void OnPointerExit()
    {
      
       IsGazedCylinder = false;
        
      
}


    public void OnPointerClick()
    {   
        IsGazedCylinder = true;
   
       
    }

   
    public void Update()
    { 
       
           
         
             

        
        //  if(IsGazedCylinder) {
           
        //     GameObject.Find("Cylinder").SetActive(false);
           
        //    GameObject.Find("Cube2").GetComponent<Renderer>().enabled = true;}
           
   
    //    if(!IsGazedCylinder)
    //      {
          
    //         //GameObject.Find("Cylinder").GetComponent<MeshRenderer>().enabled= true;
    //         GameObject.Find("Cube2").GetComponent<MeshRenderer>().enabled = false;
           // GameObject cylinderObject = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
       
            // cylinderObject.transform.position = new Vector3(450, 244, 173);
            //  cylinderObject.transform.localScale = new Vector3(25, 25, 25);
            // cylinderObject.GetComponent<MeshRenderer>().material.color = Color.green  ;
            // IsGazedCylinder=false;

    //      }

       




        }

       


}
