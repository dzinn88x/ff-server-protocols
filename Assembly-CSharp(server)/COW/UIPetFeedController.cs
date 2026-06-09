using System;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001AEC RID: 6892
	[Token(Token = "0x2001AEC")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F8EB4", Offset = "0x10F8EB4")]
	public class UIPetFeedController : UIPopupWindowController
	{
		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x0600921C RID: 37404 RVA: 0x00026E20 File Offset: 0x00025020
		// (set) Token: 0x0600921D RID: 37405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A36")]
		protected virtual int ItemCount
		{
			[Token(Token = "0x600921C")]
			[Address(RVA = "0x20D527C", Offset = "0x20D527C", VA = "0x7BBC8D527C", Slot = "40")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600921D")]
			[Address(RVA = "0x20D5284", Offset = "0x20D5284", VA = "0x7BBC8D5284", Slot = "41")]
			set
			{
			}
		}

		// Token: 0x0600921E RID: 37406 RVA: 0x00026E38 File Offset: 0x00025038
		[Token(Token = "0x600921E")]
		[Address(RVA = "0x20D52FC", Offset = "0x20D52FC", VA = "0x7BBC8D52FC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600921F RID: 37407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600921F")]
		[Address(RVA = "0x20D534C", Offset = "0x20D534C", VA = "0x7BBC8D534C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009220 RID: 37408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009220")]
		[Address(RVA = "0x20D5640", Offset = "0x20D5640", VA = "0x7BBC8D5640", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009221 RID: 37409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009221")]
		[Address(RVA = "0x20D5648", Offset = "0x20D5648", VA = "0x7BBC8D5648")]
		private void OnPurchaseBtnClick()
		{
		}

		// Token: 0x06009222 RID: 37410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009222")]
		[Address(RVA = "0x20D5734", Offset = "0x20D5734", VA = "0x7BBC8D5734")]
		protected void OnPlusBtnClick()
		{
		}

		// Token: 0x06009223 RID: 37411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009223")]
		[Address(RVA = "0x20D5904", Offset = "0x20D5904", VA = "0x7BBC8D5904")]
		protected void OnMinsBtnClick()
		{
		}

		// Token: 0x06009224 RID: 37412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009224")]
		[Address(RVA = "0x20D596C", Offset = "0x20D596C", VA = "0x7BBC8D596C")]
		protected void OnMaxBtnClick()
		{
		}

		// Token: 0x06009225 RID: 37413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009225")]
		[Address(RVA = "0x20D5980", Offset = "0x20D5980", VA = "0x7BBC8D5980")]
		protected void OnCancelClick()
		{
		}

		// Token: 0x06009226 RID: 37414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009226")]
		[Address(RVA = "0x20D5988", Offset = "0x20D5988", VA = "0x7BBC8D5988")]
		public void SetUIData(uint pet_feed_id, uint pet_id, uint max_count)
		{
		}

		// Token: 0x06009227 RID: 37415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009227")]
		[Address(RVA = "0x20D5C88", Offset = "0x20D5C88", VA = "0x7BBC8D5C88")]
		protected void SetMaxPurchaseCount(uint limited_purchase_times, uint purchase_times)
		{
		}

		// Token: 0x06009228 RID: 37416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009228")]
		[Address(RVA = "0x20D55C8", Offset = "0x20D55C8", VA = "0x7BBC8D55C8")]
		private void ShowModifyCountContainer()
		{
		}

		// Token: 0x06009229 RID: 37417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009229")]
		[Address(RVA = "0x20D5D20", Offset = "0x20D5D20", VA = "0x7BBC8D5D20")]
		public UIPetFeedController()
		{
		}

		// Token: 0x04009CCC RID: 40140
		[Token(Token = "0x4009CCC")]
		[FieldOffset(Offset = "0x98")]
		protected CSSharedItemData m_ItemData;

		// Token: 0x04009CCD RID: 40141
		[Token(Token = "0x4009CCD")]
		[FieldOffset(Offset = "0xA0")]
		private uint m_pet_food_id;

		// Token: 0x04009CCE RID: 40142
		[Token(Token = "0x4009CCE")]
		[FieldOffset(Offset = "0xA4")]
		private uint m_pet_id;

		// Token: 0x04009CCF RID: 40143
		[Token(Token = "0x4009CCF")]
		[FieldOffset(Offset = "0xA8")]
		private UIFeedPetView m_View;

		// Token: 0x04009CD0 RID: 40144
		[Token(Token = "0x4009CD0")]
		[FieldOffset(Offset = "0xB0")]
		protected EInventory.CurrencyType m_CurrencyType;

		// Token: 0x04009CD1 RID: 40145
		[Token(Token = "0x4009CD1")]
		[FieldOffset(Offset = "0xB4")]
		protected uint m_Price;

		// Token: 0x04009CD2 RID: 40146
		[Token(Token = "0x4009CD2")]
		[FieldOffset(Offset = "0x0")]
		protected static Color GemBgColor;

		// Token: 0x04009CD3 RID: 40147
		[Token(Token = "0x4009CD3")]
		[FieldOffset(Offset = "0x10")]
		protected static Color GemTextColor;

		// Token: 0x04009CD4 RID: 40148
		[Token(Token = "0x4009CD4")]
		[FieldOffset(Offset = "0x20")]
		protected static Color CoinBgColor;

		// Token: 0x04009CD5 RID: 40149
		[Token(Token = "0x4009CD5")]
		[FieldOffset(Offset = "0x30")]
		protected static Color CoinTextColor;

		// Token: 0x04009CD6 RID: 40150
		[Token(Token = "0x4009CD6")]
		private const uint OUTLINE_BLUE = 192872447U;

		// Token: 0x04009CD7 RID: 40151
		[Token(Token = "0x4009CD7")]
		[FieldOffset(Offset = "0xB8")]
		protected int m_Count;

		// Token: 0x04009CD8 RID: 40152
		[Token(Token = "0x4009CD8")]
		[FieldOffset(Offset = "0xBC")]
		protected int m_MaxCount;

		// Token: 0x04009CD9 RID: 40153
		[Token(Token = "0x4009CD9")]
		[FieldOffset(Offset = "0xC0")]
		protected int m_TotalFeed_Num;
	}
}
