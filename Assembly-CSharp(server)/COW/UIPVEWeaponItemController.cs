using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001634 RID: 5684
	[Token(Token = "0x2001634")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EFDC4", Offset = "0x10EFDC4")]
	public class UIPVEWeaponItemController : UIBaseController
	{
		// Token: 0x0600665F RID: 26207 RVA: 0x0001D388 File Offset: 0x0001B588
		[Token(Token = "0x600665F")]
		[Address(RVA = "0x16E7604", Offset = "0x16E7604", VA = "0x7BBBEE7604")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006660 RID: 26208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006660")]
		[Address(RVA = "0x16E7654", Offset = "0x16E7654", VA = "0x7BBBEE7654", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006661 RID: 26209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006661")]
		[Address(RVA = "0x16E798C", Offset = "0x16E798C", VA = "0x7BBBEE798C")]
		public UIToggleButton GetToggleBtn()
		{
			return null;
		}

		// Token: 0x06006662 RID: 26210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006662")]
		[Address(RVA = "0x16E79B8", Offset = "0x16E79B8", VA = "0x7BBBEE79B8", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06006663 RID: 26211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006663")]
		[Address(RVA = "0x16E79C0", Offset = "0x16E79C0", VA = "0x7BBBEE79C0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006664 RID: 26212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006664")]
		[Address(RVA = "0x16E7AE0", Offset = "0x16E7AE0", VA = "0x7BBBEE7AE0")]
		public void SetUIData(uint itemid)
		{
		}

		// Token: 0x06006665 RID: 26213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006665")]
		[Address(RVA = "0x16E7E64", Offset = "0x16E7E64", VA = "0x7BBBEE7E64")]
		private void OnItemBtnClick()
		{
		}

		// Token: 0x06006666 RID: 26214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006666")]
		[Address(RVA = "0x16E8198", Offset = "0x16E8198", VA = "0x7BBBEE8198")]
		private void GotoPurchase()
		{
		}

		// Token: 0x06006667 RID: 26215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006667")]
		[Address(RVA = "0x16E82F0", Offset = "0x16E82F0", VA = "0x7BBBEE82F0")]
		private void HighLightCurrent(params object[] data)
		{
		}

		// Token: 0x06006668 RID: 26216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006668")]
		[Address(RVA = "0x16E83E0", Offset = "0x16E83E0", VA = "0x7BBBEE83E0")]
		private void RefreshTips(params object[] data)
		{
		}

		// Token: 0x06006669 RID: 26217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006669")]
		[Address(RVA = "0x16E84C4", Offset = "0x16E84C4", VA = "0x7BBBEE84C4")]
		public UIPVEWeaponItemController()
		{
		}

		// Token: 0x04008421 RID: 33825
		[Token(Token = "0x4008421")]
		[FieldOffset(Offset = "0x58")]
		private UIPVEWeaponItemView m_View;

		// Token: 0x04008422 RID: 33826
		[Token(Token = "0x4008422")]
		[FieldOffset(Offset = "0x60")]
		private UIModelCollection m_ModelCollection;

		// Token: 0x04008423 RID: 33827
		[Token(Token = "0x4008423")]
		[FieldOffset(Offset = "0x68")]
		private CSSharedItemDataManager.CollectionSubType m_CurrentCollectionType;

		// Token: 0x04008424 RID: 33828
		[Token(Token = "0x4008424")]
		[FieldOffset(Offset = "0x6C")]
		private uint m_ItemID;

		// Token: 0x04008425 RID: 33829
		[Token(Token = "0x4008425")]
		[FieldOffset(Offset = "0x70")]
		private CSSharedItemData m_WeaponItemData;

		// Token: 0x04008426 RID: 33830
		[Token(Token = "0x4008426")]
		[FieldOffset(Offset = "0x78")]
		private WeaponSkinData m_WeaponSkinData;

		// Token: 0x04008427 RID: 33831
		[Token(Token = "0x4008427")]
		[FieldOffset(Offset = "0x80")]
		private UIModelPVE m_ModelPVE;

		// Token: 0x04008428 RID: 33832
		[Token(Token = "0x4008428")]
		[FieldOffset(Offset = "0x88")]
		private CSSharedAvatarData m_AvatarData;
	}
}
