using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Projectile", menuName = "CustomObjects/Projectile")]
public class ProjectileType : ScriptableObject
{
    public int damage;
    public float speed;
    public float size;
    public Color color = Color.black;
    public Sprite sprite;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
