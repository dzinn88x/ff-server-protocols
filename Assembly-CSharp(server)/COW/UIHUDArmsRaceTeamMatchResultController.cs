using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001429 RID: 5161
	[Token(Token = "0x2001429")]
	internal class UIHUDArmsRaceTeamMatchResultController : UIHudTeamBattleMatchResultController
	{
		// Token: 0x06005556 RID: 21846 RVA: 0x000196F8 File Offset: 0x000178F8
		[Token(Token = "0x6005556")]
		[Address(RVA = "0x16B50F0", Offset = "0x16B50F0", VA = "0x7BBBEB50F0")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005557 RID: 21847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005557")]
		[Address(RVA = "0x16B5140", Offset = "0x16B5140", VA = "0x7BBBEB5140", Slot = "42")]
		protected override EMatchResultPlayerInfoType[] GetInfoTypes()
		{
			return null;
		}

		// Token: 0x06005558 RID: 21848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005558")]
		[Address(RVA = "0x16B51AC", Offset = "0x16B51AC", VA = "0x7BBBEB51AC", Slot = "43")]
		protected override void OnSetMatchResultInfo(MatchStats stats)
		{
		}

		// Token: 0x06005559 RID: 21849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005559")]
		[Address(RVA = "0x16B51D4", Offset = "0x16B51D4", VA = "0x7BBBEB51D4")]
		private void ShowTeamInfo()
		{
		}

		// Token: 0x0600555A RID: 21850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600555A")]
		[Address(RVA = "0x16B54B8", Offset = "0x16B54B8", VA = "0x7BBBEB54B8")]
		public UIHUDArmsRaceTeamMatchResultController()
		{
		}
	}
}
