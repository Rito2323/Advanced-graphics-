//-----------------------------------------------------------------------
// <copyright file="ObjectController.cs" company="Google LLC">
// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//-----------------------------------------------------------------------

using System.Collections;
using UnityEngine;

/// <summary>
/// Controls target objects behaviour.
/// </summary>
public class SphereControl : MonoBehaviour
{
  

    // The objects are about 1 meter in radius, so the min/max target distance are
    // set so that the objects are always within the room (which is about 5 meters
    // across).
    //private const float _minObjectDistance = 2.5f;
    //private const float _maxObjectDistance = 3.5f;
    //private const float _minObjectHeight = 0.5f;
    //private const float _maxObjectHeight = 3.5f;

    private Renderer _myRendererCube;
    private Renderer _myRendererSphere;
    private Vector3 _startingPosition1;
    private bool IsTriggerPressed = false;
    private bool IsGazedSphere = false;
    private bool IsGazedCube = false;
    private Color objColor ;
    

    /// <summary>
    /// Start is called before the first frame update.
    /// </summary>
    public void Start()
    {
        _startingPosition1 = transform.parent.localPosition;
      
        
        //GameObject.Find("Cube").GetComponent<Renderer>().material.color = Color.white;
       
    }

    

   
    public void OnPointerEnterSphere()
    {
        //SetMaterialSphere(true);
        IsGazedSphere = true;
        
    }

  

   
    public void OnPointerExit()
    {
      
       IsGazedSphere = false;
       //transform.position = new Vector3(-272,161,-135);
      
      

        

        
       
    }

    /// <summary>
    /// This method is called by the Main Camera when it is gazing at this GameObject and the screen
    /// is touched.
    /// </summary>
    public void OnPointerClick()
    {   
        IsGazedSphere = true;
   
       
    }

   
    public void Update()
    { 
       
       
        if(IsGazedSphere ){
         transform.Translate(Vector3.down * Time.deltaTime*10);}
           
          
         
        
         
    //}
   
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
