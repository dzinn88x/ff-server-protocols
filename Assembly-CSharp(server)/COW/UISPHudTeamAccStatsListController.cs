using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001612 RID: 5650
	[Token(Token = "0x2001612")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EF9BC", Offset = "0x10EF9BC")]
	internal class UISPHudTeamAccStatsListController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x0600654A RID: 25930 RVA: 0x0001CFB0 File Offset: 0x0001B1B0
		[Token(Token = "0x600654A")]
		[Address(RVA = "0x1EF5668", Offset = "0x1EF5668", VA = "0x7BBC6F5668")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600654B RID: 25931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600654B")]
		[Address(RVA = "0x1EF56B8", Offset = "0x1EF56B8", VA = "0x7BBC6F56B8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600654C RID: 25932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600654C")]
		[Address(RVA = "0x1EF580C", Offset = "0x1EF580C", VA = "0x7BBC6F580C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600654D RID: 25933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600654D")]
		[Address(RVA = "0x1EF58F8", Offset = "0x1EF58F8", VA = "0x7BBC6F58F8")]
		private void OnUIToggle(params object[] data)
		{
		}

		// Token: 0x0600654E RID: 25934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600654E")]
		[Address(RVA = "0x1EF595C", Offset = "0x1EF595C", VA = "0x7BBC6F595C")]
		private void RefreshUI()
		{
		}

		// Token: 0x0600654F RID: 25935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600654F")]
		[Address(RVA = "0x1EF5B9C", Offset = "0x1EF5B9C", VA = "0x7BBC6F5B9C")]
		private void RefreshLivecountUI()
		{
		}

		// Token: 0x06006550 RID: 25936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006550")]
		[Address(RVA = "0x1EF5D24", Offset = "0x1EF5D24", VA = "0x7BBC6F5D24", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06006551 RID: 25937 RVA: 0x0001CFC8 File Offset: 0x0001B1C8
		[Token(Token = "0x6006551")]
		[Address(RVA = "0x1EF5DAC", Offset = "0x1EF5DAC", VA = "0x7BBC6F5DAC", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06006552 RID: 25938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006552")]
		[Address(RVA = "0x1EF5DF4", Offset = "0x1EF5DF4", VA = "0x7BBC6F5DF4")]
		public UISPHudTeamAccStatsListController()
		{
		}

		// Token: 0x040083B2 RID: 33714
		[Token(Token = "0x40083B2")]
		[FieldOffset(Offset = "0x58")]
		private UISPHudTeamAccStatsListView m_View;

		// Token: 0x040083B3 RID: 33715
		[Token(Token = "0x40083B3")]
		[FieldOffset(Offset = "0x60")]
		private UIModelSpectator m_Model;

		// Token: 0x040083B4 RID: 33716
		[Token(Token = "0x40083B4")]
		[FieldOffset(Offset = "0x68")]
		private bool m_IsShowing;

		// Token: 0x040083B5 RID: 33717
		[Token(Token = "0x40083B5")]
		[FieldOffset(Offset = "0x70")]
		private List<UISPHudTeamAccStatsItemController> m_TeamCtrlList;
	}
}
