using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020015C9 RID: 5577
	[Token(Token = "0x20015C9")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EF354", Offset = "0x10EF354")]
	internal class UIHudBanknoteMatchResultController : UIHudTeamBattleMatchResultController
	{
		// Token: 0x060062D4 RID: 25300 RVA: 0x0001C6F8 File Offset: 0x0001A8F8
		[Token(Token = "0x60062D4")]
		[Address(RVA = "0x188E6CC", Offset = "0x188E6CC", VA = "0x7BBC08E6CC")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060062D5 RID: 25301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062D5")]
		[Address(RVA = "0x188E71C", Offset = "0x188E71C", VA = "0x7BBC08E71C", Slot = "42")]
		protected override EMatchResultPlayerInfoType[] GetInfoTypes()
		{
			return null;
		}

		// Token: 0x060062D6 RID: 25302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062D6")]
		[Address(RVA = "0x188E788", Offset = "0x188E788", VA = "0x7BBC08E788", Slot = "43")]
		protected override void OnSetMatchResultInfo(MatchStats stats)
		{
		}

		// Token: 0x060062D7 RID: 25303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062D7")]
		[Address(RVA = "0x188E7B4", Offset = "0x188E7B4", VA = "0x7BBC08E7B4")]
		public UIHudBanknoteMatchResultController()
		{
		}
	}
}
