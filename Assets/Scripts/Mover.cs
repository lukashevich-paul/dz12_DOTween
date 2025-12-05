using DG.Tweening;
using UnityEngine;

public class Mover : Parent
{
    [SerializeField] private Vector3 _position;

    private void Start()
    {
        transform.DOMove(_position, Duration).SetLoops(Loops, LoopType);
    }
}
