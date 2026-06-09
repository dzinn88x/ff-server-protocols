using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020014A6 RID: 5286
	[Token(Token = "0x20014A6")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED45C", Offset = "0x10ED45C")]
	public class UIChampionshipTeamRecordItemController : UIEasyListItemController
	{
		// Token: 0x060059A2 RID: 22946 RVA: 0x0001A5C8 File Offset: 0x000187C8
		[Token(Token = "0x60059A2")]
		[Address(RVA = "0x1EDB614", Offset = "0x1EDB614", VA = "0x7BBC6DB614")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060059A3 RID: 22947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059A3")]
		[Address(RVA = "0x1EDB664", Offset = "0x1EDB664", VA = "0x7BBC6DB664", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060059A4 RID: 22948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059A4")]
		[Address(RVA = "0x1EDB6C8", Offset = "0x1EDB6C8", VA = "0x7BBC6DB6C8", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x060059A5 RID: 22949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059A5")]
		[Address(RVA = "0x1EDBAB4", Offset = "0x1EDBAB4", VA = "0x7BBC6DBAB4")]
		public UIChampionshipTeamRecordItemController()
		{
		}

		// Token: 0x04007D10 RID: 32016
		[Token(Token = "0x4007D10")]
		[FieldOffset(Offset = "0x70")]
		private UIChampionshipTeamRecordItemView m_View;

		// Token: 0x04007D11 RID: 32017
		[Token(Token = "0x4007D11")]
		[FieldOffset(Offset = "0x78")]
		private TeamChampionshipMatchData m_MatchData;

		// Token: 0x04007D12 RID: 32018
		[Token(Token = "0x4007D12")]
		[FieldOffset(Offset = "0x80")]
		private TeamChampionshipMatchStats m_MatchStats;
	}
}
