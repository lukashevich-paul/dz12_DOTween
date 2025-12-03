using DG.Tweening;
using UnityEngine;

public class Scaler : MonoBehaviour
{

    [SerializeField] private Vector3 _scale;
    [SerializeField] private float _duration;
    [SerializeField] private int _loops = -1;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        transform.DOScale(_scale, _duration).SetLoops(_loops, _loopType);
    }
}
