using DG.Tweening;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshPro))]
public class TextChanger : MonoBehaviour
{
    [SerializeField] private string _string = "текст, который последовательно меняется разными способами)";
    [SerializeField] private string _string2 = "(замена, добавление, эффект замены с перебором)";
    [SerializeField] private string _string3 = "Задание. Практика с DOTween";
    [SerializeField] private float _duration;
    [SerializeField] private int _loops;

    private TextMeshPro _text;

    private void Start()
    {
        _text = GetComponent<TextMeshPro>();

        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText(_string, _duration));
        sequence.Append(_text.DOText(_string2, _duration).SetRelative(this));
        sequence.Append(_text.DOText(_string3, _duration, true, ScrambleMode.All));
        sequence.SetLoops(_loops, LoopType.Restart);
    }
}
