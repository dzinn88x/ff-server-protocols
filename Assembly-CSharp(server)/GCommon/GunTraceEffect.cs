using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000EAF RID: 3759
	[Token(Token = "0x2000EAF")]
	internal class GunTraceEffect : ReusableObject
	{
		// Token: 0x06003378 RID: 13176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003378")]
		[Address(RVA = "0x211D3A8", Offset = "0x211D3A8", VA = "0x7BBC91D3A8")]
		private void Start()
		{
		}

		// Token: 0x06003379 RID: 13177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003379")]
		[Address(RVA = "0x211D480", Offset = "0x211D480", VA = "0x7BBC91D480", Slot = "4")]
		public override void Prepare()
		{
		}

		// Token: 0x0600337A RID: 13178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600337A")]
		[Address(RVA = "0x211D4B4", Offset = "0x211D4B4", VA = "0x7BBC91D4B4")]
		private void Update()
		{
		}

		// Token: 0x0600337B RID: 13179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600337B")]
		[Address(RVA = "0x211D5FC", Offset = "0x211D5FC", VA = "0x7BBC91D5FC")]
		public GunTraceEffect()
		{
		}

		// Token: 0x040047A5 RID: 18341
		[Token(Token = "0x40047A5")]
		[FieldOffset(Offset = "0x2C")]
		public float DelayDestoryTime;

		// Token: 0x040047A6 RID: 18342
		[Token(Token = "0x40047A6")]
		[FieldOffset(Offset = "0x30")]
		public float Speed;

		// Token: 0x040047A7 RID: 18343
		[Token(Token = "0x40047A7")]
		[FieldOffset(Offset = "0x34")]
		private float m_StartTime;

		// Token: 0x040047A8 RID: 18344
		[Token(Token = "0x40047A8")]
		[FieldOffset(Offset = "0x38")]
		private Renderer m_Renderer;

		// Token: 0x040047A9 RID: 18345
		[Token(Token = "0x40047A9")]
		[FieldOffset(Offset = "0x40")]
		private float m_BlendFactor;

		// Token: 0x040047AA RID: 18346
		[Token(Token = "0x40047AA")]
		[FieldOffset(Offset = "0x48")]
		private Material m_material;
	}
}
