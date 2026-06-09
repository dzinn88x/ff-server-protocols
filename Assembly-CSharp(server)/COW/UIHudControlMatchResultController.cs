using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020015CB RID: 5579
	[Token(Token = "0x20015CB")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EF3C4", Offset = "0x10EF3C4")]
	internal class UIHudControlMatchResultController : UIHudTeamBattleMatchResultController
	{
		// Token: 0x060062DB RID: 25307 RVA: 0x0001C728 File Offset: 0x0001A928
		[Token(Token = "0x60062DB")]
		[Address(RVA = "0x1A93B20", Offset = "0x1A93B20", VA = "0x7BBC293B20")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060062DC RID: 25308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062DC")]
		[Address(RVA = "0x1A93B70", Offset = "0x1A93B70", VA = "0x7BBC293B70", Slot = "42")]
		protected override EMatchResultPlayerInfoType[] GetInfoTypes()
		{
			return null;
		}

		// Token: 0x060062DD RID: 25309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062DD")]
		[Address(RVA = "0x1A93BDC", Offset = "0x1A93BDC", VA = "0x7BBC293BDC")]
		public UIHudControlMatchResultController()
		{
		}
	}
}
