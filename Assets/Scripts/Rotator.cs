using DG.Tweening;
using UnityEngine;

public class Rotator : Parent
{
    [SerializeField] private Vector3 _rotation;

    private void Start()
    {
        transform.DORotate(_rotation, Duration, RotateMode.FastBeyond360).SetEase(Ease.Linear).SetLoops(Loops, LoopType);
    }
}
