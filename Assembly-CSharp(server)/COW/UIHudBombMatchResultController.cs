using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020015CA RID: 5578
	[Token(Token = "0x20015CA")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EF38C", Offset = "0x10EF38C")]
	internal class UIHudBombMatchResultController : UIHudTeamBattleMatchResultController
	{
		// Token: 0x060062D8 RID: 25304 RVA: 0x0001C710 File Offset: 0x0001A910
		[Token(Token = "0x60062D8")]
		[Address(RVA = "0x189C4A0", Offset = "0x189C4A0", VA = "0x7BBC09C4A0")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060062D9 RID: 25305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062D9")]
		[Address(RVA = "0x189C4F0", Offset = "0x189C4F0", VA = "0x7BBC09C4F0", Slot = "42")]
		protected override EMatchResultPlayerInfoType[] GetInfoTypes()
		{
			return null;
		}

		// Token: 0x060062DA RID: 25306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062DA")]
		[Address(RVA = "0x189C55C", Offset = "0x189C55C", VA = "0x7BBC09C55C")]
		public UIHudBombMatchResultController()
		{
		}
	}
}
