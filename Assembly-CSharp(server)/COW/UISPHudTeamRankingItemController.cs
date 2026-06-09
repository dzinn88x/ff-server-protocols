using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B9D RID: 7069
	[Token(Token = "0x2001B9D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA83C", Offset = "0x10FA83C")]
	internal class UISPHudTeamRankingItemController : UIEasyListItemController
	{
		// Token: 0x0600988D RID: 39053 RVA: 0x000282C0 File Offset: 0x000264C0
		[Token(Token = "0x600988D")]
		[Address(RVA = "0x1EF97A0", Offset = "0x1EF97A0", VA = "0x7BBC6F97A0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600988E RID: 39054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600988E")]
		[Address(RVA = "0x1EF97F0", Offset = "0x1EF97F0", VA = "0x7BBC6F97F0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600988F RID: 39055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600988F")]
		[Address(RVA = "0x1EF9C4C", Offset = "0x1EF9C4C", VA = "0x7BBC6F9C4C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009890 RID: 39056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009890")]
		[Address(RVA = "0x1EF9C54", Offset = "0x1EF9C54", VA = "0x7BBC6F9C54")]
		public void SetParentCtrl(UISPHudTeamRankingListController ctrl)
		{
		}

		// Token: 0x06009891 RID: 39057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009891")]
		[Address(RVA = "0x1EF9C5C", Offset = "0x1EF9C5C", VA = "0x7BBC6F9C5C", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06009892 RID: 39058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009892")]
		[Address(RVA = "0x1EFA3EC", Offset = "0x1EFA3EC", VA = "0x7BBC6FA3EC")]
		private void OnToggleTeamNum(object[] data)
		{
		}

		// Token: 0x06009893 RID: 39059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009893")]
		[Address(RVA = "0x1EFA514", Offset = "0x1EFA514", VA = "0x7BBC6FA514")]
		public UISPHudTeamRankingItemController()
		{
		}

		// Token: 0x0400A03B RID: 41019
		[Token(Token = "0x400A03B")]
		[FieldOffset(Offset = "0x70")]
		private UISPHudTeamRankingItemView m_View;

		// Token: 0x0400A03C RID: 41020
		[Token(Token = "0x400A03C")]
		[FieldOffset(Offset = "0x78")]
		private UISPHudTeamRankingListController m_ParentCtrl;

		// Token: 0x0400A03D RID: 41021
		[Token(Token = "0x400A03D")]
		[FieldOffset(Offset = "0x80")]
		private bool m_showTeamNum;

		// Token: 0x0400A03E RID: 41022
		[Token(Token = "0x400A03E")]
		[FieldOffset(Offset = "0x88")]
		private List<UISprite> m_PlayIconList;
	}
}
