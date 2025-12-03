using DG.Tweening;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float _duration;
    [SerializeField] private int _loops = -1;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        transform.DORotate(_rotation, _duration, RotateMode.FastBeyond360).SetEase(Ease.Linear).SetLoops(_loops, _loopType);
    }
}
