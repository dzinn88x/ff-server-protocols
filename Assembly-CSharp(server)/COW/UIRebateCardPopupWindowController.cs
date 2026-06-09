using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001B48 RID: 6984
	[Token(Token = "0x2001B48")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F99C4", Offset = "0x10F99C4")]
	public class UIRebateCardPopupWindowController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x06009612 RID: 38418 RVA: 0x00027AB0 File Offset: 0x00025CB0
		[Token(Token = "0x6009612")]
		[Address(RVA = "0x1E1800C", Offset = "0x1E1800C", VA = "0x7BBC61800C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009613 RID: 38419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009613")]
		[Address(RVA = "0x1E1805C", Offset = "0x1E1805C", VA = "0x7BBC61805C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009614 RID: 38420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009614")]
		[Address(RVA = "0x1E18568", Offset = "0x1E18568", VA = "0x7BBC618568")]
		private void OnGetCDNAD(params object[] data)
		{
		}

		// Token: 0x06009615 RID: 38421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009615")]
		[Address(RVA = "0x1E18B00", Offset = "0x1E18B00", VA = "0x7BBC618B00")]
		private void UpdateRebateCards()
		{
		}

		// Token: 0x06009616 RID: 38422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009616")]
		[Address(RVA = "0x1E18F44", Offset = "0x1E18F44", VA = "0x7BBC618F44", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009617 RID: 38423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009617")]
		[Address(RVA = "0x1E19028", Offset = "0x1E19028", VA = "0x7BBC619028")]
		private void OnNotifyCheckboxChange()
		{
		}

		// Token: 0x06009618 RID: 38424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009618")]
		[Address(RVA = "0x1E18438", Offset = "0x1E18438", VA = "0x7BBC618438")]
		private void RefreshViewData()
		{
		}

		// Token: 0x06009619 RID: 38425 RVA: 0x00027AC8 File Offset: 0x00025CC8
		[Token(Token = "0x6009619")]
		[Address(RVA = "0x1E19088", Offset = "0x1E19088", VA = "0x7BBC619088", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600961A RID: 38426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600961A")]
		[Address(RVA = "0x1E190CC", Offset = "0x1E190CC", VA = "0x7BBC6190CC", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600961B RID: 38427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600961B")]
		[Address(RVA = "0x1E19120", Offset = "0x1E19120", VA = "0x7BBC619120")]
		public UIRebateCardPopupWindowController()
		{
		}

		// Token: 0x04009EDE RID: 40670
		[Token(Token = "0x4009EDE")]
		private const uint REDEEM_BTN_DEFAULT_COLOR = 4290380031U;

		// Token: 0x04009EDF RID: 40671
		[Token(Token = "0x4009EDF")]
		private const uint REDEEM_BTN_GREY_COLOR = 2155905279U;

		// Token: 0x04009EE0 RID: 40672
		[Token(Token = "0x4009EE0")]
		private const uint REDEEM_BTN_TITLE_GREY_COLOR = 757935615U;

		// Token: 0x04009EE1 RID: 40673
		[Token(Token = "0x4009EE1")]
		private const uint REDEEM_BTN_TITLE_DEFAULT_COLOR = 2000686079U;

		// Token: 0x04009EE2 RID: 40674
		[Token(Token = "0x4009EE2")]
		[FieldOffset(Offset = "0x98")]
		private UIRebateCardPopupWindowView m_View;

		// Token: 0x04009EE3 RID: 40675
		[Token(Token = "0x4009EE3")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelRebateCard m_Model;

		// Token: 0x04009EE4 RID: 40676
		[Token(Token = "0x4009EE4")]
		[FieldOffset(Offset = "0xA8")]
		private UIRebateCardItemController m_MonthCardItemController;

		// Token: 0x04009EE5 RID: 40677
		[Token(Token = "0x4009EE5")]
		[FieldOffset(Offset = "0xB0")]
		private UIRebateCardItemController m_WeekCardItemController;

		// Token: 0x02001B49 RID: 6985
		[Token(Token = "0x2001B49")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F99FC", Offset = "0x10F99FC")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600961D RID: 38429 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600961D")]
			[Address(RVA = "0x1E1918C", Offset = "0x1E1918C", VA = "0x7BBC61918C")]
			public <>c()
			{
			}

			// Token: 0x0600961E RID: 38430 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600961E")]
			[Address(RVA = "0x1E19194", Offset = "0x1E19194", VA = "0x7BBC619194")]
			internal void <OnGetCDNAD>b__10_0(Texture nt)
			{
			}

			// Token: 0x0600961F RID: 38431 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600961F")]
			[Address(RVA = "0x1E19240", Offset = "0x1E19240", VA = "0x7BBC619240")]
			internal void <OnGetCDNAD>b__10_1(Texture nt)
			{
			}

			// Token: 0x04009EE6 RID: 40678
			[Token(Token = "0x4009EE6")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIRebateCardPopupWindowController.<>c <>9;

			// Token: 0x04009EE7 RID: 40679
			[Token(Token = "0x4009EE7")]
			[FieldOffset(Offset = "0x8")]
			public static Action<Texture> <>9__10_0;

			// Token: 0x04009EE8 RID: 40680
			[Token(Token = "0x4009EE8")]
			[FieldOffset(Offset = "0x10")]
			public static Action<Texture> <>9__10_1;
		}
	}
}
