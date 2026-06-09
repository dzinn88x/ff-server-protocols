using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001AB7 RID: 6839
	[Token(Token = "0x2001AB7")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F898C", Offset = "0x10F898C")]
	public class UIPaymentBundleItemController : UIEasyListItemController, IUIModelDataChangeObserver
	{
		// Token: 0x06009053 RID: 36947 RVA: 0x00026748 File Offset: 0x00024948
		[Token(Token = "0x6009053")]
		[Address(RVA = "0x16F3FE8", Offset = "0x16F3FE8", VA = "0x7BBBEF3FE8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009054 RID: 36948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009054")]
		[Address(RVA = "0x16F4038", Offset = "0x16F4038", VA = "0x7BBBEF4038", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009055 RID: 36949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009055")]
		[Address(RVA = "0x16F4208", Offset = "0x16F4208", VA = "0x7BBBEF4208", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009056 RID: 36950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009056")]
		[Address(RVA = "0x16F3C5C", Offset = "0x16F3C5C", VA = "0x7BBBEF3C5C")]
		public void SetData(PayBundleWindowDesc data)
		{
		}

		// Token: 0x06009057 RID: 36951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009057")]
		[Address(RVA = "0x16F4340", Offset = "0x16F4340", VA = "0x7BBBEF4340", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06009058 RID: 36952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009058")]
		[Address(RVA = "0x16F4424", Offset = "0x16F4424", VA = "0x7BBBEF4424", Slot = "36")]
		protected virtual void UpdateContents()
		{
		}

		// Token: 0x06009059 RID: 36953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009059")]
		[Address(RVA = "0x16F6810", Offset = "0x16F6810", VA = "0x7BBBEF6810")]
		private void OnPurchaseButtonClick()
		{
		}

		// Token: 0x0600905A RID: 36954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600905A")]
		[Address(RVA = "0x16F6FE8", Offset = "0x16F6FE8", VA = "0x7BBBEF6FE8")]
		private void OnPaidFailed(params object[] data)
		{
		}

		// Token: 0x0600905B RID: 36955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600905B")]
		[Address(RVA = "0x16F70BC", Offset = "0x16F70BC", VA = "0x7BBBEF70BC", Slot = "34")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600905C RID: 36956 RVA: 0x00026760 File Offset: 0x00024960
		[Token(Token = "0x600905C")]
		[Address(RVA = "0x16F71D8", Offset = "0x16F71D8", VA = "0x7BBBEF71D8", Slot = "35")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600905D RID: 36957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600905D")]
		[Address(RVA = "0x16F71E0", Offset = "0x16F71E0", VA = "0x7BBBEF71E0")]
		public UIPaymentBundleItemController()
		{
		}

		// Token: 0x0600905E RID: 36958 RVA: 0x00026778 File Offset: 0x00024978
		[Token(Token = "0x600905E")]
		[Address(RVA = "0x16F7324", Offset = "0x16F7324", VA = "0x7BBBEF7324")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144868", Offset = "0x1144868")]
		private bool <OnPurchaseButtonClick>b__11_1(SpecialStoreDesc x)
		{
			return default(bool);
		}

		// Token: 0x04009C0C RID: 39948
		[Token(Token = "0x4009C0C")]
		[FieldOffset(Offset = "0x70")]
		private UIPaymentBundleItemView m_View;

		// Token: 0x04009C0D RID: 39949
		[Token(Token = "0x4009C0D")]
		[FieldOffset(Offset = "0x78")]
		protected PayBundleWindowDesc m_Data;

		// Token: 0x04009C0E RID: 39950
		[Token(Token = "0x4009C0E")]
		[FieldOffset(Offset = "0x80")]
		protected UICountDownController m_Countdown;

		// Token: 0x04009C0F RID: 39951
		[Token(Token = "0x4009C0F")]
		[FieldOffset(Offset = "0x88")]
		protected readonly Dictionary<bool, Color> BUTTON_LABEL_COLOR;

		// Token: 0x04009C10 RID: 39952
		[Token(Token = "0x4009C10")]
		[FieldOffset(Offset = "0x90")]
		private List<UIStandardItemMiniController> m_ContentItems;

		// Token: 0x02001AB8 RID: 6840
		[Token(Token = "0x2001AB8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F89C4", Offset = "0x10F89C4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06009060 RID: 36960 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009060")]
			[Address(RVA = "0x16F73D4", Offset = "0x16F73D4", VA = "0x7BBBEF73D4")]
			public <>c()
			{
			}

			// Token: 0x06009061 RID: 36961 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009061")]
			[Address(RVA = "0x16F73DC", Offset = "0x16F73DC", VA = "0x7BBBEF73DC")]
			internal void <OnPurchaseButtonClick>b__11_0()
			{
			}

			// Token: 0x04009C11 RID: 39953
			[Token(Token = "0x4009C11")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIPaymentBundleItemController.<>c <>9;

			// Token: 0x04009C12 RID: 39954
			[Token(Token = "0x4009C12")]
			[FieldOffset(Offset = "0x8")]
			public static Action <>9__11_0;
		}
	}
}
