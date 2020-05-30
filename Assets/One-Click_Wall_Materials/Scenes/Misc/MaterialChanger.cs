using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChanger : MonoBehaviour
{

    public List<Material> _wallMaterials;
    public List<MeshRenderer> _renderers;



    public int _currentMaterial;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NextMaterial()
    {
        if (_currentMaterial < _wallMaterials.Count-1)
        {

            _currentMaterial += 1;

        }
        foreach (MeshRenderer renderer in _renderers)
        {
            renderer.material = _wallMaterials[_currentMaterial];
        }
    }

    public void PreviousMaterial()
    {
        if (_currentMaterial > 0)
        {
            _currentMaterial -= 1;
        }
        foreach (MeshRenderer renderer in _renderers)
        {
            renderer.material = _wallMaterials[_currentMaterial];
        }

    }

}
