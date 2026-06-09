using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020015C8 RID: 5576
	[Token(Token = "0x20015C8")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EF31C", Offset = "0x10EF31C")]
	internal class UIHudADSMatchResultController : UIHudTeamBattleMatchResultController
	{
		// Token: 0x060062D1 RID: 25297 RVA: 0x0001C6E0 File Offset: 0x0001A8E0
		[Token(Token = "0x60062D1")]
		[Address(RVA = "0x1D62014", Offset = "0x1D62014", VA = "0x7BBC562014")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060062D2 RID: 25298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062D2")]
		[Address(RVA = "0x1D62064", Offset = "0x1D62064", VA = "0x7BBC562064", Slot = "42")]
		protected override EMatchResultPlayerInfoType[] GetInfoTypes()
		{
			return null;
		}

		// Token: 0x060062D3 RID: 25299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062D3")]
		[Address(RVA = "0x1D620D0", Offset = "0x1D620D0", VA = "0x7BBC5620D0")]
		public UIHudADSMatchResultController()
		{
		}
	}
}
