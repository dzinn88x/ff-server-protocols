using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020015CE RID: 5582
	[Token(Token = "0x20015CE")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EF434", Offset = "0x10EF434")]
	internal class UIHudTokenMatchResultController : UIHudTeamBattleMatchResultController
	{
		// Token: 0x060062E6 RID: 25318 RVA: 0x0001C7A0 File Offset: 0x0001A9A0
		[Token(Token = "0x60062E6")]
		[Address(RVA = "0x15E7624", Offset = "0x15E7624", VA = "0x7BBBDE7624")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060062E7 RID: 25319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062E7")]
		[Address(RVA = "0x15E7674", Offset = "0x15E7674", VA = "0x7BBBDE7674", Slot = "42")]
		protected override EMatchResultPlayerInfoType[] GetInfoTypes()
		{
			return null;
		}

		// Token: 0x060062E8 RID: 25320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062E8")]
		[Address(RVA = "0x15E76E0", Offset = "0x15E76E0", VA = "0x7BBBDE76E0")]
		public UIHudTokenMatchResultController()
		{
		}
	}
}
