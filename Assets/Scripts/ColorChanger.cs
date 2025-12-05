using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class ColorChanger : Parent
{
    [SerializeField] private Color _newColor;

    private Renderer _objectRenderer;

    private void Start()
    {
        _objectRenderer = GetComponent<Renderer>();
        _objectRenderer.material.DOColor(_newColor, Duration).SetLoops(Loops, LoopType);
    }
}
