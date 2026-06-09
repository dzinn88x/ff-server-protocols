using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000ED4 RID: 3796
	[Token(Token = "0x2000ED4")]
	[ExecuteInEditMode]
	internal class BlackWhiteEffect : MonoBehaviour
	{
		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x0600347E RID: 13438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000698")]
		private Shader BWShader
		{
			[Token(Token = "0x600347E")]
			[Address(RVA = "0x25E6838", Offset = "0x25E6838", VA = "0x7BBCDE6838")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x0600347F RID: 13439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000699")]
		private Material CurMaterial
		{
			[Token(Token = "0x600347F")]
			[Address(RVA = "0x25E695C", Offset = "0x25E695C", VA = "0x7BBCDE695C")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003480 RID: 13440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003480")]
		[Address(RVA = "0x25E6AE8", Offset = "0x25E6AE8", VA = "0x7BBCDE6AE8")]
		private void Start()
		{
		}

		// Token: 0x06003481 RID: 13441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003481")]
		[Address(RVA = "0x25E6BB0", Offset = "0x25E6BB0", VA = "0x7BBCDE6BB0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x06003482 RID: 13442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003482")]
		[Address(RVA = "0x25E6CC0", Offset = "0x25E6CC0", VA = "0x7BBCDE6CC0")]
		public BlackWhiteEffect()
		{
		}

		// Token: 0x0400481A RID: 18458
		[Token(Token = "0x400481A")]
		[FieldOffset(Offset = "0x18")]
		private Material m_CurMaterial;

		// Token: 0x0400481B RID: 18459
		[Token(Token = "0x400481B")]
		[FieldOffset(Offset = "0x20")]
		private Shader m_BWShader;
	}
}
