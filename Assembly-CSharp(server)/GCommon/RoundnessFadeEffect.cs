using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000EDC RID: 3804
	[Token(Token = "0x2000EDC")]
	[ExecuteInEditMode]
	public class RoundnessFadeEffect : MonoBehaviour
	{
		// Token: 0x060034A4 RID: 13476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034A4")]
		[Address(RVA = "0x2490188", Offset = "0x2490188", VA = "0x7BBCC90188")]
		private void Start()
		{
		}

		// Token: 0x060034A5 RID: 13477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034A5")]
		[Address(RVA = "0x24903C8", Offset = "0x24903C8", VA = "0x7BBCC903C8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x060034A6 RID: 13478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034A6")]
		[Address(RVA = "0x24904B8", Offset = "0x24904B8", VA = "0x7BBCC904B8")]
		public RoundnessFadeEffect()
		{
		}

		// Token: 0x0400484B RID: 18507
		[Token(Token = "0x400484B")]
		[FieldOffset(Offset = "0x18")]
		private Material m_CurMaterial;

		// Token: 0x0400484C RID: 18508
		[Token(Token = "0x400484C")]
		[FieldOffset(Offset = "0x20")]
		private Shader m_Shader;

		// Token: 0x0400484D RID: 18509
		[Token(Token = "0x400484D")]
		[FieldOffset(Offset = "0x28")]
		public Color m_Color;

		// Token: 0x0400484E RID: 18510
		[Token(Token = "0x400484E")]
		[FieldOffset(Offset = "0x38")]
		public float m_Radius;

		// Token: 0x0400484F RID: 18511
		[Token(Token = "0x400484F")]
		[FieldOffset(Offset = "0x3C")]
		public float m_Speed;
	}
}
