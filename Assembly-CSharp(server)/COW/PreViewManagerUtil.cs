using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001295 RID: 4757
	[Token(Token = "0x2001295")]
	public static class PreViewManagerUtil
	{
		// Token: 0x060049A6 RID: 18854 RVA: 0x000163E0 File Offset: 0x000145E0
		[Token(Token = "0x60049A6")]
		[Address(RVA = "0x1743490", Offset = "0x1743490", VA = "0x7BBBF43490")]
		public static BoostState CheckBoostStateDelegate(uint itemID)
		{
			return BoostState.DontChange;
		}

		// Token: 0x060049A7 RID: 18855 RVA: 0x000163F8 File Offset: 0x000145F8
		[Token(Token = "0x60049A7")]
		[Address(RVA = "0x17436B4", Offset = "0x17436B4", VA = "0x7BBBF436B4")]
		public static bool IsAvatarCantWearHeadAdditive(uint avatarId, AvatarWardrobeData clothes, bool canEquipDefault = true)
		{
			return default(bool);
		}
	}
}
