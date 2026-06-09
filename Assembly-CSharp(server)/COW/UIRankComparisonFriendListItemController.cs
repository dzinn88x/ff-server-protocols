using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B3A RID: 6970
	[Token(Token = "0x2001B3A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F985C", Offset = "0x10F985C")]
	public class UIRankComparisonFriendListItemController : UIBaseController
	{
		// Token: 0x060095AD RID: 38317 RVA: 0x00027930 File Offset: 0x00025B30
		[Token(Token = "0x60095AD")]
		[Address(RVA = "0x1E0B6DC", Offset = "0x1E0B6DC", VA = "0x7BBC60B6DC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060095AE RID: 38318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095AE")]
		[Address(RVA = "0x1E0B72C", Offset = "0x1E0B72C", VA = "0x7BBC60B72C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060095AF RID: 38319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095AF")]
		[Address(RVA = "0x1E0B15C", Offset = "0x1E0B15C", VA = "0x7BBC60B15C")]
		public void SetViewData(object data, bool show)
		{
		}

		// Token: 0x060095B0 RID: 38320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095B0")]
		[Address(RVA = "0x1E0B810", Offset = "0x1E0B810", VA = "0x7BBC60B810", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x060095B1 RID: 38321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095B1")]
		[Address(RVA = "0x1E0B818", Offset = "0x1E0B818", VA = "0x7BBC60B818")]
		public UIRankComparisonFriendListItemController()
		{
		}

		// Token: 0x04009EB8 RID: 40632
		[Token(Token = "0x4009EB8")]
		[FieldOffset(Offset = "0x58")]
		private UIRankComparisonFriendListItemView m_View;

		// Token: 0x04009EB9 RID: 40633
		[Token(Token = "0x4009EB9")]
		[FieldOffset(Offset = "0x60")]
		private UILadderMatchLeaderboardItemController ctrl;
	}
}
