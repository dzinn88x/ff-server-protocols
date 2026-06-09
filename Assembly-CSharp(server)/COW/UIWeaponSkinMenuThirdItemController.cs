using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001BDF RID: 7135
	[Token(Token = "0x2001BDF")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FB0CC", Offset = "0x10FB0CC")]
	public class UIWeaponSkinMenuThirdItemController : UIEasyListItemController, IUIModelDataChangeObserver
	{
		// Token: 0x06009AA0 RID: 39584 RVA: 0x00028B00 File Offset: 0x00026D00
		[Token(Token = "0x6009AA0")]
		[Address(RVA = "0x221A74C", Offset = "0x221A74C", VA = "0x7BBCA1A74C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009AA1 RID: 39585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AA1")]
		[Address(RVA = "0x221A79C", Offset = "0x221A79C", VA = "0x7BBCA1A79C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009AA2 RID: 39586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AA2")]
		[Address(RVA = "0x221AB10", Offset = "0x221AB10", VA = "0x7BBCA1AB10", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009AA3 RID: 39587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AA3")]
		[Address(RVA = "0x221AC48", Offset = "0x221AC48", VA = "0x7BBCA1AC48")]
		private void RefreshRedTips(bool flag)
		{
		}

		// Token: 0x06009AA4 RID: 39588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AA4")]
		[Address(RVA = "0x221AC90", Offset = "0x221AC90", VA = "0x7BBCA1AC90", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06009AA5 RID: 39589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AA5")]
		[Address(RVA = "0x221BF28", Offset = "0x221BF28", VA = "0x7BBCA1BF28")]
		private void OnItemUpdate(object[] param)
		{
		}

		// Token: 0x06009AA6 RID: 39590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AA6")]
		[Address(RVA = "0x221C0F0", Offset = "0x221C0F0", VA = "0x7BBCA1C0F0", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x06009AA7 RID: 39591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AA7")]
		[Address(RVA = "0x221C5A0", Offset = "0x221C5A0", VA = "0x7BBCA1C5A0", Slot = "32")]
		public override void OnItemBtnUnSelect()
		{
		}

		// Token: 0x06009AA8 RID: 39592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AA8")]
		[Address(RVA = "0x221C5F0", Offset = "0x221C5F0", VA = "0x7BBCA1C5F0", Slot = "34")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06009AA9 RID: 39593 RVA: 0x00028B18 File Offset: 0x00026D18
		[Token(Token = "0x6009AA9")]
		[Address(RVA = "0x221C6AC", Offset = "0x221C6AC", VA = "0x7BBCA1C6AC", Slot = "35")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06009AAA RID: 39594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AAA")]
		[Address(RVA = "0x221C6F0", Offset = "0x221C6F0", VA = "0x7BBCA1C6F0")]
		private void OnClickGoToMallWeapon()
		{
		}

		// Token: 0x06009AAB RID: 39595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AAB")]
		[Address(RVA = "0x221C8D4", Offset = "0x221C8D4", VA = "0x7BBCA1C8D4")]
		public UIWeaponSkinMenuThirdItemController()
		{
		}

		// Token: 0x0400A157 RID: 41303
		[Token(Token = "0x400A157")]
		[FieldOffset(Offset = "0x70")]
		private UIWeaponSkinMenuThirdItemView m_View;

		// Token: 0x0400A158 RID: 41304
		[Token(Token = "0x400A158")]
		[FieldOffset(Offset = "0x78")]
		private UIModelCollection m_ModelCollection;

		// Token: 0x0400A159 RID: 41305
		[Token(Token = "0x400A159")]
		[FieldOffset(Offset = "0x80")]
		private CollectionBaseInfo m_CollectionInfo;

		// Token: 0x0400A15A RID: 41306
		[Token(Token = "0x400A15A")]
		[FieldOffset(Offset = "0x88")]
		private bool m_CollectionABReady;

		// Token: 0x0400A15B RID: 41307
		[Token(Token = "0x400A15B")]
		[FieldOffset(Offset = "0x8C")]
		private uint m_ItemIconGrey;

		// Token: 0x0400A15C RID: 41308
		[Token(Token = "0x400A15C")]
		[FieldOffset(Offset = "0x90")]
		private object m_Data;
	}
}
