using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001BDE RID: 7134
	[Token(Token = "0x2001BDE")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FB094", Offset = "0x10FB094")]
	public class UIWeaponSkinMenuSecondItemController : UIEasyListItemController
	{
		// Token: 0x06009A95 RID: 39573 RVA: 0x00028AE8 File Offset: 0x00026CE8
		[Token(Token = "0x6009A95")]
		[Address(RVA = "0x22191AC", Offset = "0x22191AC", VA = "0x7BBCA191AC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009A96 RID: 39574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A96")]
		[Address(RVA = "0x22191FC", Offset = "0x22191FC", VA = "0x7BBCA191FC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009A97 RID: 39575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A97")]
		[Address(RVA = "0x2219404", Offset = "0x2219404", VA = "0x7BBCA19404")]
		private void RefreshRedTips(bool flag)
		{
		}

		// Token: 0x06009A98 RID: 39576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A98")]
		[Address(RVA = "0x221944C", Offset = "0x221944C", VA = "0x7BBCA1944C")]
		private void OnRefreshRed(params object[] data)
		{
		}

		// Token: 0x06009A99 RID: 39577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A99")]
		[Address(RVA = "0x2219678", Offset = "0x2219678", VA = "0x7BBCA19678", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009A9A RID: 39578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A9A")]
		[Address(RVA = "0x2219798", Offset = "0x2219798", VA = "0x7BBCA19798")]
		private void OnRefreshIcon(params object[] data)
		{
		}

		// Token: 0x06009A9B RID: 39579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A9B")]
		[Address(RVA = "0x2219FE0", Offset = "0x2219FE0", VA = "0x7BBCA19FE0", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06009A9C RID: 39580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A9C")]
		[Address(RVA = "0x2219964", Offset = "0x2219964", VA = "0x7BBCA19964")]
		private void RefreshSecondTypeIcon(uint id)
		{
		}

		// Token: 0x06009A9D RID: 39581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A9D")]
		[Address(RVA = "0x221A248", Offset = "0x221A248", VA = "0x7BBCA1A248", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x06009A9E RID: 39582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A9E")]
		[Address(RVA = "0x221A4D4", Offset = "0x221A4D4", VA = "0x7BBCA1A4D4", Slot = "32")]
		public override void OnItemBtnUnSelect()
		{
		}

		// Token: 0x06009A9F RID: 39583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A9F")]
		[Address(RVA = "0x221A524", Offset = "0x221A524", VA = "0x7BBCA1A524")]
		public UIWeaponSkinMenuSecondItemController()
		{
		}

		// Token: 0x0400A154 RID: 41300
		[Token(Token = "0x400A154")]
		[FieldOffset(Offset = "0x70")]
		private UIWeaponSkinMenuSecondItemView m_View;

		// Token: 0x0400A155 RID: 41301
		[Token(Token = "0x400A155")]
		[FieldOffset(Offset = "0x78")]
		private object m_Data;

		// Token: 0x0400A156 RID: 41302
		[Token(Token = "0x400A156")]
		[FieldOffset(Offset = "0x80")]
		private UIModelCollection m_ModelCollection;
	}
}
