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
public class ObjectController : MonoBehaviour
{
    /// <summary>
    /// The material to use when this object is inactive (not being gazed at).
    /// </summary>
    public Material InactiveMaterial;

    /// <summary>
    /// The material to use when this object is active (gazed at).
    /// </summary>
    public Material GazedAtMaterial;

    // The objects are about 1 meter in radius, so the min/max target distance are
    // set so that the objects are always within the room (which is about 5 meters
    // across).
    //private const float _minObjectDistance = 2.5f;
    //private const float _maxObjectDistance = 3.5f;
    //private const float _minObjectHeight = 0.5f;
    //private const float _maxObjectHeight = 3.5f;

    private Renderer _myRendererCube;
    //private Renderer _myRendererSphere;
    private Vector3 _startingPosition;
    private bool IsTriggerPressed = false;
    //private bool IsGazedSphere = false;
    private bool IsGazedCube = false;
    private Color objColor ;
    

    /// <summary>
    /// Start is called before the first frame update.
    /// </summary>
    public void Start()
    {
        _startingPosition = transform.parent.localPosition;
      
        _myRendererCube = GameObject.Find("Cube").GetComponent<Renderer>();
        //_myRendererSphere = GameObject.Find("Sphere").GetComponent<Renderer>();
        SetMaterialCube(false);
        //SetMaterialSphere(false);
        //GameObject.Find("Cube").GetComponent<Renderer>().material.color = Color.white;
       
    }

    /// <summary>
    /// Teleports this instance randomly when triggered by a pointer click.
    /// </summary>
    // public void TeleportRandomly()
    // {
    //     // Picks a random sibling, activates it and deactivates itself.
    //     int sibIdx = transform.GetSiblingIndex();
    //     int numSibs = transform.parent.childCount;
    //     sibIdx = (sibIdx + Random.Range(1, numSibs)) % numSibs;
    //     GameObject randomSib = transform.parent.GetChild(sibIdx).gameObject;

    //     // Computes new object's location.
    //     float angle = Random.Range(-Mathf.PI, Mathf.PI);
    //     float distance = Random.Range(_minObjectDistance, _maxObjectDistance);
    //     float height = Random.Range(_minObjectHeight, _maxObjectHeight);
    //     Vector3 newPos = new Vector3(Mathf.Cos(angle) * distance, height,
    //                                  Mathf.Sin(angle) * distance);

    //     // Moves the parent to the new position (siblings relative distance from their parent is 0).
    //     transform.parent.localPosition = newPos;

    //     randomSib.SetActive(true);
    //     gameObject.SetActive(false);
    //     SetMaterial(false);
    // }

    /// <summary>
    /// This method is called by the Main Camera when it starts gazing at this GameObject.
    /// </summary>
    // public void OnPointerEnterSphere()
    // {
    //     SetMaterialSphere(true);
    //     IsGazedSphere = true;
    // }

    public void OnPointerEnterCube()
    {
         SetMaterialCube(true);
         //objColor = GameObject.Find("Cube").GetComponent<Renderer>().material.color;
         //GameObject.Find("Cube").GetComponent<Renderer>().material.color = Color.green;
        IsGazedCube = true;

    }

    /// <summary>
    /// This method is called by the Main Camera when it stops gazing at this GameObject.
    /// </summary>
    public void OnPointerExit()
    {
        SetMaterialCube(false);
        //SetMaterialSphere(false);
       //IsGazedSphere = false;
       IsGazedCube=false;

        

        
       
    }

    /// <summary>
    /// This method is called by the Main Camera when it is gazing at this GameObject and the screen
    /// is touched.
    /// </summary>
    public void OnPointerClick()
    {   
        //IsGazedSphere = true;
   
       
    }

    /// <summary>
    /// Sets this instance's material according to gazedAt status.
    /// </summary>
    ///
    /// <param name="gazedAt">
    /// Value `true` if this object is being gazed at, `false` otherwise.
    /// </param>
    private void SetMaterialCube(bool gazedAt)
    {
        if (InactiveMaterial != null && GazedAtMaterial != null)
        {
            _myRendererCube.material = gazedAt ? GazedAtMaterial : InactiveMaterial;
        }
    }
    // private void SetMaterialSphere(bool gazedAt)
    // {
    //     if (InactiveMaterial != null && GazedAtMaterial != null)
    //     {
    //         _myRendererSphere.material = gazedAt ? GazedAtMaterial : InactiveMaterial;
    //     }
    // }
    public void Update()
    { 
       
           
    //      if(IsGazedSphere ){
    //        GameObject.Find("Sphere").transform.Translate(Vector3.down * Time.deltaTime*10);
          
         
        
         
    // }
   
    //    if(!IsGazedSphere)
    //      {
          
    //       GameObject.Find("Sphere").transform.position = new Vector3(150,150,150);
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
