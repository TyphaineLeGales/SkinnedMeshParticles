using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.VFX;

public class TriggerSpawn : MonoBehaviour
{
    [SerializeField] Camera _camera = null;
    [SerializeField] VisualEffect _vfx = null;
    VFXEventAttribute _attrib;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var pos = Input.mousePosition;
            pos.z = _vfx.transform.position.z - _camera.transform.position.z;
            pos = _camera.ScreenToWorldPoint(pos);

            if (_attrib == null) _attrib = _vfx.CreateVFXEventAttribute();
            _attrib.SetVector3("position", pos);
            _vfx.SendEvent("Start", _attrib);
        }
    }
}
