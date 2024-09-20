using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Rigidbody rb;
    public LayerMask whatIsEnemies;
 
    //Stats
    [Range(0f,1f)]
    public float bounciness;
    public bool useGravity;

    //Damage
    public int bulletDamage;

    //Lifetime
    public int maxCollisions;
    public float maxLifetime;

    private int collisions;
    PhysicMaterial physics_mat;

    private void Setup()
    {
        //Create a new Physics material
        physics_mat = new PhysicMaterial();
        physics_mat.bounciness = bounciness;
        physics_mat.frictionCombine = PhysicMaterialCombine.Minimum;
        physics_mat.bounceCombine = PhysicMaterialCombine.Maximum;
        //Assign material to collider
        GetComponent<SphereCollider>().material = physics_mat;

        //Set gravity
        rb.useGravity = useGravity;
    }
    
    private void Start()
    {
        Setup();
    }

    private void Update()
    {
        //When to Destroy the bullet:
        if (collisions >= maxCollisions) DestroyBullet();

        //Count down lifetime
        maxLifetime -= Time.deltaTime;
        if(maxLifetime <= 0) DestroyBullet();
    }

    private void Delay()
    {
        Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision collision) 
    {
        //Don't count collisions with other bullets
        if(collision.collider.CompareTag("Bullet")) return;

        //Destroy if bullet hits an enemy directly
        if (collision.collider.CompareTag("Enemy") && collision.gameObject.TryGetComponent<EnemyAI>(out EnemyAI enemyComponent))
            {
                enemyComponent.TakeDamage(bulletDamage);

                DestroyBullet();
            } 
        //Count up collision each time the bullet contacts a collider
        collisions++;
    
    }

    private void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
