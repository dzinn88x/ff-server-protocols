using System;
using GCommon;
using Il2CppDummyDll;

namespace COW.GamePlay
{
	// Token: 0x02002888 RID: 10376
	[Token(Token = "0x2002888")]
	public class LevelOilDrums : LevelBaseDrum
	{
		// Token: 0x0600DBD5 RID: 56277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DBD5")]
		[Address(RVA = "0x1D30C4C", Offset = "0x1D30C4C", VA = "0x7BBC530C4C", Slot = "32")]
		protected override string GetObjectTag()
		{
			return null;
		}

		// Token: 0x0600DBD6 RID: 56278 RVA: 0x0003CCA8 File Offset: 0x0003AEA8
		[Token(Token = "0x600DBD6")]
		[Address(RVA = "0x1D30C94", Offset = "0x1D30C94", VA = "0x7BBC530C94", Slot = "36")]
		public override ResourceID GetModelResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600DBD7 RID: 56279 RVA: 0x0003CCC0 File Offset: 0x0003AEC0
		[Token(Token = "0x600DBD7")]
		[Address(RVA = "0x1D30CE4", Offset = "0x1D30CE4", VA = "0x7BBC530CE4", Slot = "37")]
		public override ResourceID GetDamagedEffect()
		{
			return default(ResourceID);
		}

		// Token: 0x0600DBD8 RID: 56280 RVA: 0x0003CCD8 File Offset: 0x0003AED8
		[Token(Token = "0x600DBD8")]
		[Address(RVA = "0x1D30D34", Offset = "0x1D30D34", VA = "0x7BBC530D34", Slot = "38")]
		public override ResourceID GetExplodeEffect()
		{
			return default(ResourceID);
		}

		// Token: 0x0600DBD9 RID: 56281 RVA: 0x0003CCF0 File Offset: 0x0003AEF0
		[Token(Token = "0x600DBD9")]
		[Address(RVA = "0x1D30D84", Offset = "0x1D30D84", VA = "0x7BBC530D84", Slot = "39")]
		public override ResourceID GetExplodeSound()
		{
			return default(ResourceID);
		}

		// Token: 0x0600DBDA RID: 56282 RVA: 0x0003CD08 File Offset: 0x0003AF08
		[Token(Token = "0x600DBDA")]
		[Address(RVA = "0x1D30DD4", Offset = "0x1D30DD4", VA = "0x7BBC530DD4", Slot = "40")]
		public override LevelBaseDrum.|smcIav OilDrumType()
		{
			return LevelBaseDrum.|smcIav.None;
		}

		// Token: 0x0600DBDB RID: 56283 RVA: 0x0003CD20 File Offset: 0x0003AF20
		[Token(Token = "0x600DBDB")]
		[Address(RVA = "0x1D30DDC", Offset = "0x1D30DDC", VA = "0x7BBC530DDC", Slot = "41")]
		public override float GetEffectTime()
		{
			return 0f;
		}

		// Token: 0x0600DBDC RID: 56284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DBDC")]
		[Address(RVA = "0x1D30DE4", Offset = "0x1D30DE4", VA = "0x7BBC530DE4")]
		public LevelOilDrums()
		{
		}
	}
}
