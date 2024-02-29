using UnityEngine;
namespace Niveau5
{
  public class Parallax : MonoBehaviour
  {
    private MeshRenderer MeshRenderer;
    public float animationSpeed = 0.1f;
    private void Awake()
    {
      MeshRenderer = GetComponent<MeshRenderer>();
    }
    private void Update()
    {
      MeshRenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);
    }
  }
}
