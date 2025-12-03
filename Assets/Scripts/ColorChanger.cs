using DG.Tweening;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Color _newColor;
    [SerializeField] private float _duration;
    [SerializeField] private int _loops = -1;
    [SerializeField] private LoopType _loopType;

    private Renderer _objectRenderer;

    private void Start()
    {
        _objectRenderer = GetComponent<Renderer>();
        _objectRenderer.material.DOColor(_newColor, _duration).SetLoops(_loops, _loopType);
    }
}
