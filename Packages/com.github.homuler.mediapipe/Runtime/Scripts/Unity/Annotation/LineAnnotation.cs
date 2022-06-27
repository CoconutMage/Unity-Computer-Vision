// Copyright (c) 2021 homuler
//
// Use of this source code is governed by an MIT-style
// license that can be found in the LICENSE file or at
// https://opensource.org/licenses/MIT.

using UnityEngine;

namespace Mediapipe.Unity
{
#pragma warning disable IDE0065
  using Color = UnityEngine.Color;
#pragma warning restore IDE0065

  public class LineAnnotation : HierarchicalAnnotation
  {
    [SerializeField] private LineRenderer _lineRenderer;
    [SerializeField] private Color _color = Color.green;
    [SerializeField, Range(0, 1)] private float _lineWidth = 1.0f;

    private void OnEnable()
    {
      ApplyColor(_color);
      ApplyLineWidth(_lineWidth);
    }

    private void OnDisable()
    {
      ApplyLineWidth(0.0f);
    }

    private void OnValidate()
    {
      ApplyColor(_color);
      ApplyLineWidth(_lineWidth);
    }

    public void SetColor(Color color)
    {
      _color = color;
      ApplyColor(_color);
    }

    public void SetLineWidth(float lineWidth)
    {
      _lineWidth = lineWidth;
      ApplyLineWidth(_lineWidth);
    }

    public void Draw(Vector3 a, Vector3 b)
    {
      _lineRenderer.SetPositions(new Vector3[] { a, b });
    }

    public void Draw(GameObject a, GameObject b)
    {
      /*if (transform.parent.GetChild(11).Equals(transform) || transform.parent.GetChild(20).Equals(transform))// || transform.parent.GetChild(16).Equals(transform) || transform.parent.GetChild(17).Equals(transform) || transform.parent.GetChild(18).Equals(transform))
      {
        transform.GetChild(0).gameObject.SetActive(false);
        return;
      }*/
      _lineRenderer.SetPositions(new Vector3[] { a.transform.localPosition, b.transform.localPosition });
      transform.GetChild(0).position = a.transform.position;
      //transform.GetChild(0).LookAt(b.transform, transform.GetChild(0).right);
      Vector3 r = Quaternion.LookRotation((b.transform.position - transform.GetChild(0).position).normalized).eulerAngles;
      r.x += 90;
      transform.GetChild(0).rotation = Quaternion.Euler(r);
      Vector3 s = transform.GetChild(0).localScale;
      s.y = Vector3.Distance(b.transform.position, transform.GetChild(0).position);
      transform.GetChild(0).localScale = s;
    }

    public void ApplyColor(Color color)
    {
      if (_lineRenderer != null)
      {
        _lineRenderer.startColor = color;
        _lineRenderer.endColor = color;
      }
    }

    private void ApplyLineWidth(float lineWidth)
    {
      if (_lineRenderer != null)
      {
        _lineRenderer.startWidth = lineWidth;
        _lineRenderer.endWidth = lineWidth;
      }
    }
  }
}
