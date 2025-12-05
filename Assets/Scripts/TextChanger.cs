using DG.Tweening;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshPro))]
public class TextChanger : Parent
{
    [SerializeField] private string _string = "текст, который последовательно меняется разными способами)";
    [SerializeField] private string _string2 = "(замена, добавление, эффект замены с перебором)";
    [SerializeField] private string _string3 = "Задание. Практика с DOTween";

    private TextMeshPro _text;

    private void Start()
    {
        _text = GetComponent<TextMeshPro>();

        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText(_string, Duration));
        sequence.Append(_text.DOText(_string2, Duration).SetRelative(this));
        sequence.Append(_text.DOText(_string3, Duration, true, ScrambleMode.All));
        sequence.SetLoops(Loops, LoopType);
    }
}
