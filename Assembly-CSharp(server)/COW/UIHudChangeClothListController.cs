using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200167B RID: 5755
	[Token(Token = "0x200167B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F032C", Offset = "0x10F032C")]
	public class UIHudChangeClothListController : UIPopupWindowController
	{
		// Token: 0x06006875 RID: 26741 RVA: 0x0001D9E8 File Offset: 0x0001BBE8
		[Token(Token = "0x6006875")]
		[Address(RVA = "0x19D22F8", Offset = "0x19D22F8", VA = "0x7BBC1D22F8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006876 RID: 26742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006876")]
		[Address(RVA = "0x19D2348", Offset = "0x19D2348", VA = "0x7BBC1D2348", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006877 RID: 26743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006877")]
		[Address(RVA = "0x19D1EBC", Offset = "0x19D1EBC", VA = "0x7BBC1D1EBC")]
		public void InitClothesData()
		{
		}

		// Token: 0x06006878 RID: 26744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006878")]
		[Address(RVA = "0x19D25E8", Offset = "0x19D25E8", VA = "0x7BBC1D25E8")]
		private void OnCloseClick()
		{
		}

		// Token: 0x06006879 RID: 26745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006879")]
		[Address(RVA = "0x19D2620", Offset = "0x19D2620", VA = "0x7BBC1D2620")]
		private void On1PShowClick()
		{
		}

		// Token: 0x0600687A RID: 26746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600687A")]
		[Address(RVA = "0x19D2624", Offset = "0x19D2624", VA = "0x7BBC1D2624")]
		private void On3PShowClick()
		{
		}

		// Token: 0x0600687B RID: 26747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600687B")]
		[Address(RVA = "0x19D2628", Offset = "0x19D2628", VA = "0x7BBC1D2628")]
		private void OnSearchInputChange()
		{
		}

		// Token: 0x0600687C RID: 26748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600687C")]
		[Address(RVA = "0x19D2740", Offset = "0x19D2740", VA = "0x7BBC1D2740")]
		public UIHudChangeClothListController()
		{
		}

		// Token: 0x04008543 RID: 34115
		[Token(Token = "0x4008543")]
		[FieldOffset(Offset = "0x98")]
		private UIHudChangeClothListView m_View;

		// Token: 0x04008544 RID: 34116
		[Token(Token = "0x4008544")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelInventory m_InventoryModel;

		// Token: 0x04008545 RID: 34117
		[Token(Token = "0x4008545")]
		[FieldOffset(Offset = "0xA8")]
		private UIModelAvatar m_ModelAvatar;

		// Token: 0x04008546 RID: 34118
		[Token(Token = "0x4008546")]
		[FieldOffset(Offset = "0xB0")]
		private AvatarManager m_amManager;
	}
}
