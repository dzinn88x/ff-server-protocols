using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200147F RID: 5247
	[Token(Token = "0x200147F")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ECF64", Offset = "0x10ECF64")]
	public class UIChampionshipLobbyController : UINavigationController
	{
		// Token: 0x06005887 RID: 22663 RVA: 0x0001A178 File Offset: 0x00018378
		[Token(Token = "0x6005887")]
		[Address(RVA = "0x1EC51DC", Offset = "0x1EC51DC", VA = "0x7BBC6C51DC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005888 RID: 22664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005888")]
		[Address(RVA = "0x1EC522C", Offset = "0x1EC522C", VA = "0x7BBC6C522C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005889 RID: 22665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005889")]
		[Address(RVA = "0x1EC5434", Offset = "0x1EC5434", VA = "0x7BBC6C5434", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600588A RID: 22666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600588A")]
		[Address(RVA = "0x1EC543C", Offset = "0x1EC543C", VA = "0x7BBC6C543C", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x0600588B RID: 22667 RVA: 0x0001A190 File Offset: 0x00018390
		[Token(Token = "0x600588B")]
		[Address(RVA = "0x1EC55A0", Offset = "0x1EC55A0", VA = "0x7BBC6C55A0", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x0600588C RID: 22668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600588C")]
		[Address(RVA = "0x1EC5370", Offset = "0x1EC5370", VA = "0x7BBC6C5370")]
		private void CreateEntrance()
		{
		}

		// Token: 0x0600588D RID: 22669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600588D")]
		[Address(RVA = "0x1EC5468", Offset = "0x1EC5468", VA = "0x7BBC6C5468")]
		private void RefreshUI()
		{
		}

		// Token: 0x0600588E RID: 22670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600588E")]
		[Address(RVA = "0x1EC55A8", Offset = "0x1EC55A8", VA = "0x7BBC6C55A8")]
		protected void OnRuleButtonClick()
		{
		}

		// Token: 0x0600588F RID: 22671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600588F")]
		[Address(RVA = "0x1EC565C", Offset = "0x1EC565C", VA = "0x7BBC6C565C")]
		public UIChampionshipLobbyController()
		{
		}

		// Token: 0x04007C66 RID: 31846
		[Token(Token = "0x4007C66")]
		[FieldOffset(Offset = "0xB0")]
		private UIChampionshipLobbyView m_View;

		// Token: 0x04007C67 RID: 31847
		[Token(Token = "0x4007C67")]
		[FieldOffset(Offset = "0xB8")]
		private UIModelChampionship m_ModelChampionship;

		// Token: 0x04007C68 RID: 31848
		[Token(Token = "0x4007C68")]
		[FieldOffset(Offset = "0xC0")]
		private UIChampionshipEntranceItemController m_EntranceItemCtrl;
	}
}
