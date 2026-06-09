using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using message;

namespace COW.GamePlay
{
	// Token: 0x020028E8 RID: 10472
	[Token(Token = "0x20028E8")]
	internal class Shield : AttackableEntity
	{
		// Token: 0x0600DDCA RID: 56778 RVA: 0x0003D5F0 File Offset: 0x0003B7F0
		[Token(Token = "0x600DDCA")]
		[Address(RVA = "0x16BF984", Offset = "0x16BF984", VA = "0x7BBBEBF984")]
		public uint GetOwnerVehicleID()
		{
			return 0U;
		}

		// Token: 0x0600DDCB RID: 56779 RVA: 0x0003D608 File Offset: 0x0003B808
		[Token(Token = "0x600DDCB")]
		[Address(RVA = "0x16BF98C", Offset = "0x16BF98C", VA = "0x7BBBEBF98C", Slot = "22")]
		protected override int GetMaxRepDataCount()
		{
			return 0;
		}

		// Token: 0x0600DDCC RID: 56780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDCC")]
		[Address(RVA = "0x16BF994", Offset = "0x16BF994", VA = "0x7BBBEBF994")]
		internal void v~u|lmI(LevelShield iZR^E}T)
		{
		}

		// Token: 0x0600DDCD RID: 56781 RVA: 0x0003D620 File Offset: 0x0003B820
		[Token(Token = "0x600DDCD")]
		[Address(RVA = "0x16BFA00", Offset = "0x16BFA00", VA = "0x7BBBEBFA00")]
		public bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x0600DDCE RID: 56782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DDCE")]
		[Address(RVA = "0x16BFAA4", Offset = "0x16BFAA4", VA = "0x7BBBEBFAA4")]
		protected uTpWlPV byBGuvx()
		{
			return null;
		}

		// Token: 0x0600DDCF RID: 56783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDCF")]
		[Address(RVA = "0x16BFB84", Offset = "0x16BFB84", VA = "0x7BBBEBFB84", Slot = "55")]
		public virtual void TakeDamageByVehicle(int |moXXXV, {QAb\u0082~u KE`SW[H, TNugLVg |~^O\u0080Iy, int dwdYABP)
		{
		}

		// Token: 0x0600DDD0 RID: 56784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDD0")]
		[Address(RVA = "0x16BFC94", Offset = "0x16BFC94", VA = "0x7BBBEBFC94", Slot = "48")]
		public override void TakeDamage(woZmHkA JkgWmeJ, [Optional] ohSG[ek \u0081{zLQ\u007FM, [Optional] List<float> `KEFVvE, uint iYO}d|F = 0U)
		{
		}

		// Token: 0x0600DDD1 RID: 56785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDD1")]
		[Address(RVA = "0x16BFDF0", Offset = "0x16BFDF0", VA = "0x7BBBEBFDF0")]
		public Shield()
		{
		}

		// Token: 0x04010DC6 RID: 69062
		[Token(Token = "0x4010DC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private LevelShield qVgSoJL;

		// Token: 0x04010DC7 RID: 69063
		[Token(Token = "0x4010DC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private uint MsiGdOe;

		// Token: 0x04010DC8 RID: 69064
		[Token(Token = "0x4010DC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private uint v|^F\u0082Ua;
	}
}
