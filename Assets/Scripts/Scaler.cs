using DG.Tweening;
using UnityEngine;

public class Scaler : Parent
{

    [SerializeField] private Vector3 _scale;

    private void Start()
    {
        transform.DOScale(_scale, Duration).SetLoops(Loops, LoopType);
    }
}
