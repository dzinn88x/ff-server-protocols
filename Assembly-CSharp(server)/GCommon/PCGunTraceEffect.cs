using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000EAD RID: 3757
	[Token(Token = "0x2000EAD")]
	internal class PCGunTraceEffect : ReusableObject
	{
		// Token: 0x06003372 RID: 13170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003372")]
		[Address(RVA = "0x246C91C", Offset = "0x246C91C", VA = "0x7BBCC6C91C")]
		private void Start()
		{
		}

		// Token: 0x06003373 RID: 13171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003373")]
		[Address(RVA = "0x246CA7C", Offset = "0x246CA7C", VA = "0x7BBCC6CA7C", Slot = "4")]
		public override void Prepare()
		{
		}

		// Token: 0x06003374 RID: 13172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003374")]
		[Address(RVA = "0x246CC98", Offset = "0x246CC98", VA = "0x7BBCC6CC98")]
		public void StartSimulate(Vector3 start, Vector3 end, bool isSniper, bool mobile1P)
		{
		}

		// Token: 0x06003375 RID: 13173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003375")]
		[Address(RVA = "0x246CF6C", Offset = "0x246CF6C", VA = "0x7BBCC6CF6C")]
		private void Update()
		{
		}

		// Token: 0x06003376 RID: 13174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003376")]
		[Address(RVA = "0x246D488", Offset = "0x246D488", VA = "0x7BBCC6D488")]
		public PCGunTraceEffect()
		{
		}

		// Token: 0x04004785 RID: 18309
		[Token(Token = "0x4004785")]
		[FieldOffset(Offset = "0x2C")]
		public float GunTraceLength;

		// Token: 0x04004786 RID: 18310
		[Token(Token = "0x4004786")]
		[FieldOffset(Offset = "0x30")]
		public float GunTraceSpeed;

		// Token: 0x04004787 RID: 18311
		[Token(Token = "0x4004787")]
		[FieldOffset(Offset = "0x34")]
		public float SniperGunTraceSpeed;

		// Token: 0x04004788 RID: 18312
		[Token(Token = "0x4004788")]
		[FieldOffset(Offset = "0x38")]
		public float GunSmokeFadeTime;

		// Token: 0x04004789 RID: 18313
		[Token(Token = "0x4004789")]
		[FieldOffset(Offset = "0x3C")]
		public float SniperGunSmokeFadeTime;

		// Token: 0x0400478A RID: 18314
		[Token(Token = "0x400478A")]
		[FieldOffset(Offset = "0x40")]
		public float Mobile1PSniperGunSmokeFadeTime;

		// Token: 0x0400478B RID: 18315
		[Token(Token = "0x400478B")]
		[FieldOffset(Offset = "0x48")]
		public LineRenderer TraceRenderer;

		// Token: 0x0400478C RID: 18316
		[Token(Token = "0x400478C")]
		[FieldOffset(Offset = "0x50")]
		public LineRenderer SmokeRender;

		// Token: 0x0400478D RID: 18317
		[Token(Token = "0x400478D")]
		[FieldOffset(Offset = "0x58")]
		private float m_TraceFlyTime;

		// Token: 0x0400478E RID: 18318
		[Token(Token = "0x400478E")]
		[FieldOffset(Offset = "0x5C")]
		private float m_StartTime;

		// Token: 0x0400478F RID: 18319
		[Token(Token = "0x400478F")]
		[FieldOffset(Offset = "0x60")]
		private float m_BlendFactor;

		// Token: 0x04004790 RID: 18320
		[Token(Token = "0x4004790")]
		[FieldOffset(Offset = "0x68")]
		private Material m_TraceMat;

		// Token: 0x04004791 RID: 18321
		[Token(Token = "0x4004791")]
		[FieldOffset(Offset = "0x70")]
		private Material m_SmokeMat;

		// Token: 0x04004792 RID: 18322
		[Token(Token = "0x4004792")]
		[FieldOffset(Offset = "0x78")]
		private Color m_SmokeStartColor;

		// Token: 0x04004793 RID: 18323
		[Token(Token = "0x4004793")]
		[FieldOffset(Offset = "0x88")]
		private Vector3 m_StartPos;

		// Token: 0x04004794 RID: 18324
		[Token(Token = "0x4004794")]
		[FieldOffset(Offset = "0x94")]
		private Vector3 m_Speed;

		// Token: 0x04004795 RID: 18325
		[Token(Token = "0x4004795")]
		[FieldOffset(Offset = "0xA0")]
		private float m_GunTraceAllShowTime;

		// Token: 0x04004796 RID: 18326
		[Token(Token = "0x4004796")]
		[FieldOffset(Offset = "0xA4")]
		private float m_GunSmokeFadeTime;

		// Token: 0x04004797 RID: 18327
		[Token(Token = "0x4004797")]
		[FieldOffset(Offset = "0xA8")]
		private float m_GunTraceSpeed;
	}
}
