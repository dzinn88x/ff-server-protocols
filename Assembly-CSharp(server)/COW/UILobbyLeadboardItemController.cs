using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001A03 RID: 6659
	[Token(Token = "0x2001A03")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F768C", Offset = "0x10F768C")]
	internal class UILobbyLeadboardItemController : UIBaseController
	{
		// Token: 0x06008A90 RID: 35472 RVA: 0x000252A8 File Offset: 0x000234A8
		[Token(Token = "0x6008A90")]
		[Address(RVA = "0x143F924", Offset = "0x143F924", VA = "0x7BBBC3F924")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008A91 RID: 35473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A91")]
		[Address(RVA = "0x143F974", Offset = "0x143F974", VA = "0x7BBBC3F974", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008A92 RID: 35474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A92")]
		[Address(RVA = "0x143FA60", Offset = "0x143FA60", VA = "0x7BBBC3FA60")]
		public void SetTop3Rank(int rankNum)
		{
		}

		// Token: 0x06008A93 RID: 35475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A93")]
		[Address(RVA = "0x143FAFC", Offset = "0x143FAFC", VA = "0x7BBBC3FAFC")]
		public void SetData(LeaderBoardInfo info)
		{
		}

		// Token: 0x06008A94 RID: 35476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A94")]
		[Address(RVA = "0x143FB8C", Offset = "0x143FB8C", VA = "0x7BBBC3FB8C")]
		public UILobbyLeadboardItemController()
		{
		}

		// Token: 0x04009801 RID: 38913
		[Token(Token = "0x4009801")]
		[FieldOffset(Offset = "0x58")]
		private UILobbyLeaderBoardItemView m_View;
	}
}
