using System;
using GCommon;
using Il2CppDummyDll;

namespace COW.GamePlay
{
	// Token: 0x020028A0 RID: 10400
	[Token(Token = "0x20028A0")]
	public class LevelShootingTarget : LevelBaseDrum
	{
		// Token: 0x0600DC6E RID: 56430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC6E")]
		[Address(RVA = "0x1D3C574", Offset = "0x1D3C574", VA = "0x7BBC53C574", Slot = "11")]
		protected override void OnAwake()
		{
		}

		// Token: 0x0600DC6F RID: 56431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC6F")]
		[Address(RVA = "0x1D3C57C", Offset = "0x1D3C57C", VA = "0x7BBC53C57C", Slot = "20")]
		protected override void OnUserDefineReplicationInfo()
		{
		}

		// Token: 0x0600DC70 RID: 56432 RVA: 0x0003CFD8 File Offset: 0x0003B1D8
		[Token(Token = "0x600DC70")]
		[Address(RVA = "0x1D3C584", Offset = "0x1D3C584", VA = "0x7BBC53C584", Slot = "40")]
		public override LevelBaseDrum.|smcIav OilDrumType()
		{
			return LevelBaseDrum.|smcIav.None;
		}

		// Token: 0x0600DC71 RID: 56433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DC71")]
		[Address(RVA = "0x1D3C58C", Offset = "0x1D3C58C", VA = "0x7BBC53C58C", Slot = "32")]
		protected override string GetObjectTag()
		{
			return null;
		}

		// Token: 0x0600DC72 RID: 56434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC72")]
		[Address(RVA = "0x1D3C5D4", Offset = "0x1D3C5D4", VA = "0x7BBC53C5D4", Slot = "13")]
		protected override void OnOnDestroy()
		{
		}

		// Token: 0x0600DC73 RID: 56435 RVA: 0x0003CFF0 File Offset: 0x0003B1F0
		[Token(Token = "0x600DC73")]
		[Address(RVA = "0x1D3C5DC", Offset = "0x1D3C5DC", VA = "0x7BBC53C5DC", Slot = "36")]
		public override ResourceID GetModelResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600DC74 RID: 56436 RVA: 0x0003D008 File Offset: 0x0003B208
		[Token(Token = "0x600DC74")]
		[Address(RVA = "0x1D3C64C", Offset = "0x1D3C64C", VA = "0x7BBC53C64C", Slot = "35")]
		public override int GetMaxDurability()
		{
			return 0;
		}

		// Token: 0x0600DC75 RID: 56437 RVA: 0x0003D020 File Offset: 0x0003B220
		[Token(Token = "0x600DC75")]
		[Address(RVA = "0x1D3C6B4", Offset = "0x1D3C6B4", VA = "0x7BBC53C6B4", Slot = "39")]
		public override ResourceID GetExplodeSound()
		{
			return default(ResourceID);
		}

		// Token: 0x0600DC76 RID: 56438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC76")]
		[Address(RVA = "0x1D3C704", Offset = "0x1D3C704", VA = "0x7BBC53C704", Slot = "43")]
		protected override void zyfWDnr(byte l]jgxbG, byte TzzPYjI)
		{
		}

		// Token: 0x0600DC77 RID: 56439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC77")]
		[Address(RVA = "0x1D3C76C", Offset = "0x1D3C76C", VA = "0x7BBC53C76C")]
		public LevelShootingTarget()
		{
		}

		// Token: 0x04010BA8 RID: 68520
		[Token(Token = "0x4010BA8")]
		[FieldOffset(Offset = "0x78")]
		public LevelShootingTarget.\u0080uYI\u0080\u007FF ModelType;

		// Token: 0x020028A1 RID: 10401
		[Token(Token = "0x20028A1")]
		public enum \u0080uYI\u0080\u007FF
		{
			// Token: 0x04010BAA RID: 68522
			[Token(Token = "0x4010BAA")]
			typeA,
			// Token: 0x04010BAB RID: 68523
			[Token(Token = "0x4010BAB")]
			typeB
		}
	}
}
