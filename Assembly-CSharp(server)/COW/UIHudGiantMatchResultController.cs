using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020015CD RID: 5581
	[Token(Token = "0x20015CD")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EF3FC", Offset = "0x10EF3FC")]
	internal class UIHudGiantMatchResultController : UIHudTeamBattleMatchResultController
	{
		// Token: 0x060062E3 RID: 25315 RVA: 0x0001C788 File Offset: 0x0001A988
		[Token(Token = "0x60062E3")]
		[Address(RVA = "0x197463C", Offset = "0x197463C", VA = "0x7BBC17463C")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060062E4 RID: 25316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062E4")]
		[Address(RVA = "0x197468C", Offset = "0x197468C", VA = "0x7BBC17468C", Slot = "42")]
		protected override EMatchResultPlayerInfoType[] GetInfoTypes()
		{
			return null;
		}

		// Token: 0x060062E5 RID: 25317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062E5")]
		[Address(RVA = "0x19746F8", Offset = "0x19746F8", VA = "0x7BBC1746F8")]
		public UIHudGiantMatchResultController()
		{
		}
	}
}
