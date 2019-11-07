// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.VFX;

// public class TriggerSpawn : MonoBehaviour

  
// {
//       [Serialized Field] VisualEffect _vfx = null;
//       [Serialized Field] Camera _camera = null;

//       VFXEventAttribute _attrib;
//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         if(Input.GetMouseButtonDown(0)) {
//             var mousePos = Input.mousePosition;
//             mousePos.z = _vfx.transform.position - _camera.transform.position.z;
//             mousePos = _camera.ScreenToWorldPoint(pos);

//             if(_attrib == null) _vfx.CreateVFXEventAttribute();
//             _attrib.setVector3('position', pos);

//             _vfx.SendEvent("onManualSpawn", _attrib);

//         }
        
//     }
// }
