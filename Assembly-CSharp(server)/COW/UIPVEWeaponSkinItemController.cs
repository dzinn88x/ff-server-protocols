using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001639 RID: 5689
	[Token(Token = "0x2001639")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EFE6C", Offset = "0x10EFE6C")]
	internal class UIPVEWeaponSkinItemController : UIEasyListItemController
	{
		// Token: 0x06006681 RID: 26241 RVA: 0x0001D418 File Offset: 0x0001B618
		[Token(Token = "0x6006681")]
		[Address(RVA = "0x16EAB04", Offset = "0x16EAB04", VA = "0x7BBBEEAB04")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006682 RID: 26242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006682")]
		[Address(RVA = "0x16EAB54", Offset = "0x16EAB54", VA = "0x7BBBEEAB54", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006683 RID: 26243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006683")]
		[Address(RVA = "0x16EADAC", Offset = "0x16EADAC", VA = "0x7BBBEEADAC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006684 RID: 26244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006684")]
		[Address(RVA = "0x16EADB4", Offset = "0x16EADB4", VA = "0x7BBBEEADB4", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x06006685 RID: 26245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006685")]
		[Address(RVA = "0x16EB00C", Offset = "0x16EB00C", VA = "0x7BBBEEB00C", Slot = "32")]
		public override void OnItemBtnUnSelect()
		{
		}

		// Token: 0x06006686 RID: 26246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006686")]
		[Address(RVA = "0x16EB05C", Offset = "0x16EB05C", VA = "0x7BBBEEB05C", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06006687 RID: 26247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006687")]
		[Address(RVA = "0x16EB81C", Offset = "0x16EB81C", VA = "0x7BBBEEB81C")]
		public UIPVEWeaponSkinItemController()
		{
		}

		// Token: 0x0400843C RID: 33852
		[Token(Token = "0x400843C")]
		[FieldOffset(Offset = "0x70")]
		private UIPVEWeaponSkinItemView m_View;

		// Token: 0x0400843D RID: 33853
		[Token(Token = "0x400843D")]
		[FieldOffset(Offset = "0x78")]
		private WeaponSkinBaseInfo m_WeaponSkinInfo;

		// Token: 0x0400843E RID: 33854
		[Token(Token = "0x400843E")]
		[FieldOffset(Offset = "0x80")]
		private UIModelCollection m_ModelCollection;

		// Token: 0x0400843F RID: 33855
		[Token(Token = "0x400843F")]
		[FieldOffset(Offset = "0x88")]
		private CSSharedItemDataManager.CollectionSubType m_CurrentCollectionType;

		// Token: 0x04008440 RID: 33856
		[Token(Token = "0x4008440")]
		[FieldOffset(Offset = "0x8C")]
		private uint m_DefaultWeaponSkinId;

		// Token: 0x04008441 RID: 33857
		[Token(Token = "0x4008441")]
		[FieldOffset(Offset = "0x90")]
		private uint m_ItemIconGrey;
	}
}
