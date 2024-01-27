using System;
using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class OnCLick : MonoBehaviour
{

    private Camera _camera;
    private Renderer _renderer;

    private Ray _ray;
    private RaycastHit _raycastHit;
    
    void Start()
    {
        _camera = Camera.main;
        _renderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _ray = new Ray(
                _camera.ScreenToWorldPoint(Input.mousePosition),
                _camera.transform.forward);

            if (Physics.Raycast(_ray, out _raycastHit, 1000f))
            {
                if (_raycastHit.transform == transform)
                {
                    Debug.Log("Click");
                }
            }
        }
    }
}
