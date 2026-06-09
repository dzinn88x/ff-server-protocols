using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001488 RID: 5256
	[Token(Token = "0x2001488")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED09C", Offset = "0x10ED09C")]
	public class UIChampionshipOtherFormController : UINavigationController
	{
		// Token: 0x060058C7 RID: 22727 RVA: 0x0001A268 File Offset: 0x00018468
		[Token(Token = "0x60058C7")]
		[Address(RVA = "0x1EC8638", Offset = "0x1EC8638", VA = "0x7BBC6C8638")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060058C8 RID: 22728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C8")]
		[Address(RVA = "0x1EC8688", Offset = "0x1EC8688", VA = "0x7BBC6C8688", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060058C9 RID: 22729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C9")]
		[Address(RVA = "0x1EC8740", Offset = "0x1EC8740", VA = "0x7BBC6C8740", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x060058CA RID: 22730 RVA: 0x0001A280 File Offset: 0x00018480
		[Token(Token = "0x60058CA")]
		[Address(RVA = "0x1EC8EB8", Offset = "0x1EC8EB8", VA = "0x7BBC6C8EB8", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x060058CB RID: 22731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058CB")]
		[Address(RVA = "0x1EC89E8", Offset = "0x1EC89E8", VA = "0x7BBC6C89E8")]
		public void CreateTab()
		{
		}

		// Token: 0x060058CC RID: 22732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058CC")]
		[Address(RVA = "0x1EC88B8", Offset = "0x1EC88B8", VA = "0x7BBC6C88B8")]
		public void CreateTeamPage()
		{
		}

		// Token: 0x060058CD RID: 22733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058CD")]
		[Address(RVA = "0x1EC8ED0", Offset = "0x1EC8ED0", VA = "0x7BBC6C8ED0")]
		private void OnBtnTeamPageClick()
		{
		}

		// Token: 0x060058CE RID: 22734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058CE")]
		[Address(RVA = "0x1EC9020", Offset = "0x1EC9020", VA = "0x7BBC6C9020")]
		public UIChampionshipOtherFormController()
		{
		}

		// Token: 0x04007C83 RID: 31875
		[Token(Token = "0x4007C83")]
		[FieldOffset(Offset = "0xAC")]
		private uint m_ChampionshipType;

		// Token: 0x04007C84 RID: 31876
		[Token(Token = "0x4007C84")]
		[FieldOffset(Offset = "0xB0")]
		private uint m_TeamID;

		// Token: 0x04007C85 RID: 31877
		[Token(Token = "0x4007C85")]
		[FieldOffset(Offset = "0xB4")]
		private uint m_TeamScale;

		// Token: 0x04007C86 RID: 31878
		[Token(Token = "0x4007C86")]
		[FieldOffset(Offset = "0xB8")]
		private UIChampionshipOtherFormView m_View;

		// Token: 0x04007C87 RID: 31879
		[Token(Token = "0x4007C87")]
		[FieldOffset(Offset = "0xC0")]
		private UIChampionshipTeamProfileOtherController m_TeamCtrl;

		// Token: 0x04007C88 RID: 31880
		[Token(Token = "0x4007C88")]
		[FieldOffset(Offset = "0xC8")]
		private UIStandardDrawerTabController m_DrawerTabCtrl;

		// Token: 0x04007C89 RID: 31881
		[Token(Token = "0x4007C89")]
		[FieldOffset(Offset = "0xD0")]
		private UIModelChampionship m_ModelChampionship;

		// Token: 0x02001489 RID: 5257
		[Token(Token = "0x2001489")]
		public class NavArgs
		{
			// Token: 0x060058CF RID: 22735 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60058CF")]
			[Address(RVA = "0x1EC9028", Offset = "0x1EC9028", VA = "0x7BBC6C9028")]
			public NavArgs()
			{
			}

			// Token: 0x04007C8A RID: 31882
			[Token(Token = "0x4007C8A")]
			[FieldOffset(Offset = "0x10")]
			public uint cpType;

			// Token: 0x04007C8B RID: 31883
			[Token(Token = "0x4007C8B")]
			[FieldOffset(Offset = "0x14")]
			public uint teamID;

			// Token: 0x04007C8C RID: 31884
			[Token(Token = "0x4007C8C")]
			[FieldOffset(Offset = "0x18")]
			public bool self;

			// Token: 0x04007C8D RID: 31885
			[Token(Token = "0x4007C8D")]
			[FieldOffset(Offset = "0x1C")]
			public uint scaleType;
		}

		// Token: 0x0200148A RID: 5258
		[Token(Token = "0x200148A")]
		private enum EPage
		{
			// Token: 0x04007C8F RID: 31887
			[Token(Token = "0x4007C8F")]
			Team
		}

		// Token: 0x0200148B RID: 5259
		[Token(Token = "0x200148B")]
		private enum ETeamSubPage
		{
			// Token: 0x04007C91 RID: 31889
			[Token(Token = "0x4007C91")]
			Info,
			// Token: 0x04007C92 RID: 31890
			[Token(Token = "0x4007C92")]
			Record
		}
	}
}
