using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x020028E7 RID: 10471
	[Token(Token = "0x20028E7")]
	internal class Reactor : AttackableEntity
	{
		// Token: 0x0600DDC2 RID: 56770 RVA: 0x0003D5D8 File Offset: 0x0003B7D8
		[Token(Token = "0x600DDC2")]
		[Address(RVA = "0x1732D10", Offset = "0x1732D10", VA = "0x7BBBF32D10", Slot = "22")]
		protected override int GetMaxRepDataCount()
		{
			return 0;
		}

		// Token: 0x0600DDC3 RID: 56771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDC3")]
		[Address(RVA = "0x1732D18", Offset = "0x1732D18", VA = "0x7BBBF32D18")]
		internal void v~u|lmI(LevelReactor gIyvwRk)
		{
		}

		// Token: 0x0600DDC4 RID: 56772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDC4")]
		[Address(RVA = "0x1732D24", Offset = "0x1732D24", VA = "0x7BBBF32D24")]
		public void ChangeShineColor(float nXxSfxX)
		{
		}

		// Token: 0x0600DDC5 RID: 56773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDC5")]
		[Address(RVA = "0x1732DFC", Offset = "0x1732DFC", VA = "0x7BBBF32DFC", Slot = "48")]
		public override void TakeDamage(woZmHkA JkgWmeJ, [Optional] ohSG[ek \u0081{zLQ\u007FM, [Optional] List<float> `KEFVvE, uint iYO}d|F = 0U)
		{
		}

		// Token: 0x0600DDC6 RID: 56774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDC6")]
		[Address(RVA = "0x1733038", Offset = "0x1733038", VA = "0x7BBBF33038")]
		public void PlayExplodeEffect()
		{
		}

		// Token: 0x0600DDC7 RID: 56775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDC7")]
		[Address(RVA = "0x17333D4", Offset = "0x17333D4", VA = "0x7BBBF333D4")]
		public void StopExplodeEfect()
		{
		}

		// Token: 0x0600DDC8 RID: 56776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDC8")]
		[Address(RVA = "0x1733584", Offset = "0x1733584", VA = "0x7BBBF33584")]
		public Reactor()
		{
		}

		// Token: 0x0600DDC9 RID: 56777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDC9")]
		[Address(RVA = "0x173358C", Offset = "0x173358C", VA = "0x7BBBF3358C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11499D4", Offset = "0x11499D4")]
		private void ]|qlQX\u007F()
		{
		}

		// Token: 0x04010DC2 RID: 69058
		[Token(Token = "0x4010DC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GameObject nkZipjZ;

		// Token: 0x04010DC3 RID: 69059
		[Token(Token = "0x4010DC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private uint M\u0080UEW}B;

		// Token: 0x04010DC4 RID: 69060
		[Token(Token = "0x4010DC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private LevelReactor |ghfBLb;

		// Token: 0x04010DC5 RID: 69061
		[Token(Token = "0x4010DC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ParticleSystem m_Shine;
	}
}
