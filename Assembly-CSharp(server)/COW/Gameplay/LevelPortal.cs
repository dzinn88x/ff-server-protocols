using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x0200288D RID: 10381
	[Token(Token = "0x200288D")]
	public class LevelPortal : BaseLevelObject
	{
		// Token: 0x0600DBED RID: 56301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DBED")]
		[Address(RVA = "0x1D32228", Offset = "0x1D32228", VA = "0x7BBC532228", Slot = "32")]
		protected override string GetObjectTag()
		{
			return null;
		}

		// Token: 0x0600DBEE RID: 56302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DBEE")]
		[Address(RVA = "0x1D32270", Offset = "0x1D32270", VA = "0x7BBC532270", Slot = "12")]
		protected override void OnStart()
		{
		}

		// Token: 0x0600DBEF RID: 56303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DBEF")]
		[Address(RVA = "0x1D326EC", Offset = "0x1D326EC", VA = "0x7BBC5326EC", Slot = "13")]
		protected override void OnOnDestroy()
		{
		}

		// Token: 0x0600DBF0 RID: 56304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DBF0")]
		[Address(RVA = "0x1D3284C", Offset = "0x1D3284C", VA = "0x7BBC53284C")]
		public void OnLocalPlayerEnterTrigger()
		{
		}

		// Token: 0x0600DBF1 RID: 56305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DBF1")]
		[Address(RVA = "0x1D329B0", Offset = "0x1D329B0", VA = "0x7BBC5329B0")]
		public void OnLocalPlayerExitTrigger()
		{
		}

		// Token: 0x0600DBF2 RID: 56306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DBF2")]
		[Address(RVA = "0x1D32434", Offset = "0x1D32434", VA = "0x7BBC532434")]
		private void cbRuNgM(\u0082IyX~ui \u0082Ujwl\u0080f)
		{
		}

		// Token: 0x0600DBF3 RID: 56307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DBF3")]
		[Address(RVA = "0x1D32A58", Offset = "0x1D32A58", VA = "0x7BBC532A58")]
		private void WATxXA~(params object[] QmG~NaB)
		{
		}

		// Token: 0x0600DBF4 RID: 56308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DBF4")]
		[Address(RVA = "0x1D32A6C", Offset = "0x1D32A6C", VA = "0x7BBC532A6C")]
		private void ]\u007FrWly~(params object[] QmG~NaB)
		{
		}

		// Token: 0x0600DBF5 RID: 56309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DBF5")]
		[Address(RVA = "0x1D32A80", Offset = "0x1D32A80", VA = "0x7BBC532A80")]
		public LevelPortal()
		{
		}

		// Token: 0x04010B2E RID: 68398
		[Token(Token = "0x4010B2E")]
		[FieldOffset(Offset = "0x68")]
		public qYYUr[M PortalType;

		// Token: 0x04010B2F RID: 68399
		[Token(Token = "0x4010B2F")]
		[FieldOffset(Offset = "0x6C")]
		public float Radius;

		// Token: 0x04010B30 RID: 68400
		[Token(Token = "0x4010B30")]
		[FieldOffset(Offset = "0x70")]
		public Transform[] SpawnPoints;

		// Token: 0x04010B31 RID: 68401
		[Token(Token = "0x4010B31")]
		[FieldOffset(Offset = "0x78")]
		private uint M\u0080UEW}B;

		// Token: 0x04010B32 RID: 68402
		[Token(Token = "0x4010B32")]
		[FieldOffset(Offset = "0x80")]
		public ParticleSystem SocialZoneNormalEffect;

		// Token: 0x04010B33 RID: 68403
		[Token(Token = "0x4010B33")]
		[FieldOffset(Offset = "0x88")]
		public ParticleSystem BattleZoneNormalEffect;

		// Token: 0x04010B34 RID: 68404
		[Token(Token = "0x4010B34")]
		[FieldOffset(Offset = "0x90")]
		public ParticleSystem SocialZoneEnterEffect;

		// Token: 0x04010B35 RID: 68405
		[Token(Token = "0x4010B35")]
		[FieldOffset(Offset = "0x98")]
		public ParticleSystem BattleZoneEnterEffect;

		// Token: 0x04010B36 RID: 68406
		[Token(Token = "0x4010B36")]
		[FieldOffset(Offset = "0xA0")]
		public ParticleSystem SocialTeleportEffect;

		// Token: 0x04010B37 RID: 68407
		[Token(Token = "0x4010B37")]
		[FieldOffset(Offset = "0xA8")]
		public ParticleSystem BattleTeleportEffect;

		// Token: 0x04010B38 RID: 68408
		[Token(Token = "0x4010B38")]
		[FieldOffset(Offset = "0xB0")]
		private ParticleSystem dvSv\u007FVo;

		// Token: 0x04010B39 RID: 68409
		[Token(Token = "0x4010B39")]
		[FieldOffset(Offset = "0xB8")]
		private ParticleSystem JJ\u0082|gDO;

		// Token: 0x04010B3A RID: 68410
		[Token(Token = "0x4010B3A")]
		[FieldOffset(Offset = "0xC0")]
		private ParticleSystem xdLJBK{;

		// Token: 0x0200288E RID: 10382
		[Token(Token = "0x200288E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FEB8C", Offset = "0x10FEB8C")]
		private sealed class T|bzrxZ
		{
			// Token: 0x0600DBF6 RID: 56310 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DBF6")]
			[Address(RVA = "0x1D329A8", Offset = "0x1D329A8", VA = "0x7BBC5329A8")]
			public T|bzrxZ()
			{
			}

			// Token: 0x0600DBF7 RID: 56311 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DBF7")]
			[Address(RVA = "0x1D32A88", Offset = "0x1D32A88", VA = "0x7BBC532A88")]
			internal void bJ()
			{
			}

			// Token: 0x0600DBF8 RID: 56312 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DBF8")]
			[Address(RVA = "0x1D32C1C", Offset = "0x1D32C1C", VA = "0x7BBC532C1C")]
			internal void Soj\u0081Ins()
			{
			}

			// Token: 0x04010B3B RID: 68411
			[Token(Token = "0x4010B3B")]
			[FieldOffset(Offset = "0x10")]
			public LevelPortal poIzdvJ;

			// Token: 0x04010B3C RID: 68412
			[Token(Token = "0x4010B3C")]
			[FieldOffset(Offset = "0x18")]
			public Action aKGkDcR;
		}
	}
}
