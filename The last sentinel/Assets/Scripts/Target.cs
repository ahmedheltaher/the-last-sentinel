using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;
    public void TakeDamage(float amount) {
        health -= amount;
        if (health <= 0f) {
            die();
        }
    }
    void die() {
        if(gameObject.CompareTag("Drone"))
        {
            Destroy(gameObject);
        }
        else
            Destroy(gameObject,2f);
    } 
}
