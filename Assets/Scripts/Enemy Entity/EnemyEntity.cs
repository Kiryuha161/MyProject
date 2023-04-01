using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyEntity : MonoBehaviour
{
    private string _name;
    private int _levelDangerous;
    private int _speedMovement;
    private float _obstacleRange = 5f;
    
    
    public EnemyEntity(string name, int levelDangerous)
    {
        _name = name;
        _levelDangerous = levelDangerous;
    }
    
    private void Move()
    {
        transform.Translate(0, 0, _speedMovement);

        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if(Physics.SphereCast(ray, 1.5f, out hit))
        {
            if (hit.distance < _obstacleRange)
            {
                float angle = Random.Range(-110, 110);
                transform.Rotate(0, angle, 0);
            }
        }
    }
    


}
