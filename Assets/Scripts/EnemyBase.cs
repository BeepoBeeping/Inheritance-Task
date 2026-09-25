using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public virtual void AttackPlayer()
    {
        print("Enemy is attacking player.");
    }

    void OnMouseOver()
    {
        transform.GetComponent<MeshRenderer>().material.color = Color.red;
        AttackPlayer();
    }

    void OnMouseExit()
    {
        transform.GetComponent<MeshRenderer>().material.color = Color.white;
    }

}
