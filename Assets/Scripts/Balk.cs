using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balk : MonoBehaviour
{
    [SerializeField] GameObject _balkBreakEffectPrefab;
    [SerializeField] int _damage;
    private void OnTriggerEnter(Collider other)
    {
        PlayerModifier playerModifier = other.attachedRigidbody.GetComponent<PlayerModifier>();
        if (playerModifier)
        {
            playerModifier.HitBlock(_damage);
            Destroy(transform.parent.gameObject);
            Instantiate(_balkBreakEffectPrefab, transform.position, transform.rotation);
        }
    }
}
