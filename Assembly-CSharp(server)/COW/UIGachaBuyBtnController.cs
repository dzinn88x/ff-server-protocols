using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020017DA RID: 6106
	[Token(Token = "0x20017DA")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F2EB4", Offset = "0x10F2EB4")]
	public abstract class UIGachaBuyBtnController : UIBaseController
	{
		// Token: 0x060075B4 RID: 30132
		[Token(Token = "0x60075B4")]
		protected abstract void InitBuyBtnBaseView();

		// Token: 0x060075B5 RID: 30133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075B5")]
		[Address(RVA = "0x214F9D4", Offset = "0x214F9D4", VA = "0x7BBC94F9D4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060075B6 RID: 30134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075B6")]
		[Address(RVA = "0x214FBCC", Offset = "0x214FBCC", VA = "0x7BBC94FBCC", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060075B7 RID: 30135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075B7")]
		[Address(RVA = "0x214FBD4", Offset = "0x214FBD4", VA = "0x7BBC94FBD4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060075B8 RID: 30136 RVA: 0x00020AD8 File Offset: 0x0001ECD8
		[Token(Token = "0x60075B8")]
		[Address(RVA = "0x214FC3C", Offset = "0x214FC3C", VA = "0x7BBC94FC3C", Slot = "29")]
		public virtual bool OnBeforeSingleBuy(bool isRepurchase)
		{
			return default(bool);
		}

		// Token: 0x060075B9 RID: 30137 RVA: 0x00020AF0 File Offset: 0x0001ECF0
		[Token(Token = "0x60075B9")]
		[Address(RVA = "0x214FC44", Offset = "0x214FC44", VA = "0x7BBC94FC44", Slot = "30")]
		public virtual bool OnBeforeMultiBuy(bool isRepurchase)
		{
			return default(bool);
		}

		// Token: 0x060075BA RID: 30138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075BA")]
		[Address(RVA = "0x214FC4C", Offset = "0x214FC4C", VA = "0x7BBC94FC4C")]
		public void OnSingleBuy(bool isRepurchase)
		{
		}

		// Token: 0x060075BB RID: 30139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075BB")]
		[Address(RVA = "0x21501A8", Offset = "0x21501A8", VA = "0x7BBC9501A8")]
		public void OnMultiBuy(bool isRepurchase)
		{
		}

		// Token: 0x060075BC RID: 30140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075BC")]
		[Address(RVA = "0x21506C0", Offset = "0x21506C0", VA = "0x7BBC9506C0")]
		private void OnOneBuyClick()
		{
		}

		// Token: 0x060075BD RID: 30141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075BD")]
		[Address(RVA = "0x215090C", Offset = "0x215090C", VA = "0x7BBC95090C")]
		private void OnTenBuyClick()
		{
		}

		// Token: 0x060075BE RID: 30142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075BE")]
		[Address(RVA = "0x2150ABC", Offset = "0x2150ABC", VA = "0x7BBC950ABC")]
		public void RefreshOneBuyBtn(UIGachaBuyBtnController.BuyBtnState oneState, uint chestID)
		{
		}

		// Token: 0x060075BF RID: 30143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075BF")]
		[Address(RVA = "0x2151EEC", Offset = "0x2151EEC", VA = "0x7BBC951EEC")]
		public void RefreshTenBuyBtn(UIGachaBuyBtnController.BuyBtnState tenState, uint chestID)
		{
		}

		// Token: 0x060075C0 RID: 30144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075C0")]
		[Address(RVA = "0x2150CA8", Offset = "0x2150CA8", VA = "0x7BBC950CA8")]
		private void RefreshBuyBtnTip(GachaDesc desc, UIModelGacha.GachaDrawType type)
		{
		}

		// Token: 0x060075C1 RID: 30145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075C1")]
		[Address(RVA = "0x21514C0", Offset = "0x21514C0", VA = "0x7BBC9514C0")]
		private void ResetBuyBtnStats(UIModelGacha.GachaDrawType type)
		{
		}

		// Token: 0x060075C2 RID: 30146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075C2")]
		[Address(RVA = "0x2151868", Offset = "0x2151868", VA = "0x7BBC951868")]
		private void ShowBuyViaLimitFreeUI()
		{
		}

		// Token: 0x060075C3 RID: 30147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075C3")]
		[Address(RVA = "0x215199C", Offset = "0x215199C", VA = "0x7BBC95199C")]
		private void ShowBuyViaCouponUI(GachaDesc desc, UIModelGacha.GachaDrawType type)
		{
		}

		// Token: 0x060075C4 RID: 30148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075C4")]
		[Address(RVA = "0x2151CD0", Offset = "0x2151CD0", VA = "0x7BBC951CD0")]
		private void ShowBuyViaCurrencyUI(GachaDesc desc, UIModelGacha.GachaDrawType type, uint chestID)
		{
		}

		// Token: 0x060075C5 RID: 30149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075C5")]
		[Address(RVA = "0x2153C20", Offset = "0x2153C20", VA = "0x7BBC953C20")]
		private void ShowNormalPurchaseUI(GachaDesc desc, UIModelGacha.GachaDrawType type)
		{
		}

		// Token: 0x060075C6 RID: 30150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075C6")]
		[Address(RVA = "0x215235C", Offset = "0x215235C", VA = "0x7BBC95235C")]
		private void ShowLimitPurchaseUI(GachaDesc desc, UIModelGacha.GachaDrawType type, uint chestID)
		{
		}

		// Token: 0x060075C7 RID: 30151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075C7")]
		[Address(RVA = "0x21533B4", Offset = "0x21533B4", VA = "0x7BBC9533B4")]
		private void ShowDiscountPurchaseUI(GachaDesc desc, UIModelGacha.GachaDrawType type)
		{
		}

		// Token: 0x060075C8 RID: 30152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075C8")]
		[Address(RVA = "0x2150F80", Offset = "0x2150F80", VA = "0x7BBC950F80")]
		private void UpdateFreeCDLabel(UIGachaBuyBtnController.BuyBtnState oneState, uint chestID)
		{
		}

		// Token: 0x060075C9 RID: 30153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075C9")]
		[Address(RVA = "0x21542A0", Offset = "0x21542A0", VA = "0x7BBC9542A0")]
		public void DisableOneBtn()
		{
		}

		// Token: 0x060075CA RID: 30154 RVA: 0x00020B08 File Offset: 0x0001ED08
		[Token(Token = "0x60075CA")]
		[Address(RVA = "0x214FEE8", Offset = "0x214FEE8", VA = "0x7BBC94FEE8")]
		public UIGachaBuyBtnController.BuyBtnState CalOneBuyBtnState(uint chestID)
		{
			return UIGachaBuyBtnController.BuyBtnState.STATE_NONE;
		}

		// Token: 0x060075CB RID: 30155 RVA: 0x00020B20 File Offset: 0x0001ED20
		[Token(Token = "0x60075CB")]
		[Address(RVA = "0x2150448", Offset = "0x2150448", VA = "0x7BBC950448")]
		public UIGachaBuyBtnController.BuyBtnState CalTenBuyBtnState(uint chestID)
		{
			return UIGachaBuyBtnController.BuyBtnState.STATE_NONE;
		}

		// Token: 0x060075CC RID: 30156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075CC")]
		[Address(RVA = "0x2154380", Offset = "0x2154380", VA = "0x7BBC954380")]
		public void SetBuyBtnExitPurchaseState()
		{
		}

		// Token: 0x060075CD RID: 30157 RVA: 0x00020B38 File Offset: 0x0001ED38
		[Token(Token = "0x60075CD")]
		[Address(RVA = "0x2154388", Offset = "0x2154388", VA = "0x7BBC954388")]
		public bool GetBuyBtnPurchaseState()
		{
			return default(bool);
		}

		// Token: 0x060075CE RID: 30158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075CE")]
		[Address(RVA = "0x2154390", Offset = "0x2154390", VA = "0x7BBC954390")]
		public void RefreshBtnState(uint chestID, bool needCheckCurrentGacha = false)
		{
		}

		// Token: 0x060075CF RID: 30159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075CF")]
		[Address(RVA = "0x2154450", Offset = "0x2154450", VA = "0x7BBC954450", Slot = "31")]
		protected virtual void OnRefreshBuyBtn()
		{
		}

		// Token: 0x060075D0 RID: 30160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075D0")]
		[Address(RVA = "0x2150020", Offset = "0x2150020", VA = "0x7BBC950020")]
		public void PurchaseSingle(uint chestID, UIModelGacha.GachaDrawType type, bool isRepurchase = false)
		{
		}

		// Token: 0x060075D1 RID: 30161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075D1")]
		[Address(RVA = "0x2150538", Offset = "0x2150538", VA = "0x7BBC950538")]
		public void PurchaseMulti(uint chestID, UIModelGacha.GachaDrawType type, bool isRepurchase = false)
		{
		}

		// Token: 0x060075D2 RID: 30162 RVA: 0x00020B50 File Offset: 0x0001ED50
		[Token(Token = "0x60075D2")]
		[Address(RVA = "0x2154454", Offset = "0x2154454", VA = "0x7BBC954454")]
		private UIGachaBuyBtnController.BuyBtnState GetBuyBtnStateByType(UIModelGacha.GachaDrawType type, uint chestID)
		{
			return UIGachaBuyBtnController.BuyBtnState.STATE_NONE;
		}

		// Token: 0x060075D3 RID: 30163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075D3")]
		[Address(RVA = "0x2150870", Offset = "0x2150870", VA = "0x7BBC950870")]
		private void PlayPurchaseSound()
		{
		}

		// Token: 0x060075D4 RID: 30164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075D4")]
		[Address(RVA = "0x215448C", Offset = "0x215448C", VA = "0x7BBC95448C")]
		protected UIGachaBuyBtnController()
		{
		}

		// Token: 0x04008D05 RID: 36101
		[Token(Token = "0x4008D05")]
		[FieldOffset(Offset = "0x58")]
		protected UIGachaBuyBtnBaseView m_View;

		// Token: 0x04008D06 RID: 36102
		[Token(Token = "0x4008D06")]
		[FieldOffset(Offset = "0x60")]
		protected uint m_CurrentGachaID;

		// Token: 0x04008D07 RID: 36103
		[Token(Token = "0x4008D07")]
		[FieldOffset(Offset = "0x68")]
		protected UIModelGacha m_ModelGacha;

		// Token: 0x04008D08 RID: 36104
		[Token(Token = "0x4008D08")]
		[FieldOffset(Offset = "0x70")]
		protected bool m_OnEnterPurchase;

		// Token: 0x020017DB RID: 6107
		[Token(Token = "0x20017DB")]
		public enum BuyBtnState
		{
			// Token: 0x04008D0A RID: 36106
			[Token(Token = "0x4008D0A")]
			STATE_NONE,
			// Token: 0x04008D0B RID: 36107
			[Token(Token = "0x4008D0B")]
			STATE_BUY_VIA_LIMITFREE,
			// Token: 0x04008D0C RID: 36108
			[Token(Token = "0x4008D0C")]
			STATE_BUY_VIA_COUPON,
			// Token: 0x04008D0D RID: 36109
			[Token(Token = "0x4008D0D")]
			STATE_BUY_VIA_CURRENCY
		}

		// Token: 0x020017DC RID: 6108
		[Token(Token = "0x20017DC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F2EEC", Offset = "0x10F2EEC")]
		private sealed class <>c__DisplayClass25_0
		{
			// Token: 0x060075D5 RID: 30165 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60075D5")]
			[Address(RVA = "0x2154298", Offset = "0x2154298", VA = "0x7BBC954298")]
			public <>c__DisplayClass25_0()
			{
			}

			// Token: 0x060075D6 RID: 30166 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60075D6")]
			[Address(RVA = "0x215459C", Offset = "0x215459C", VA = "0x7BBC95459C")]
			internal void <UpdateFreeCDLabel>b__1()
			{
			}

			// Token: 0x04008D0E RID: 36110
			[Token(Token = "0x4008D0E")]
			[FieldOffset(Offset = "0x10")]
			public UIGachaBuyBtnController <>4__this;

			// Token: 0x04008D0F RID: 36111
			[Token(Token = "0x4008D0F")]
			[FieldOffset(Offset = "0x18")]
			public uint chestID;
		}

		// Token: 0x020017DD RID: 6109
		[Token(Token = "0x20017DD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F2EFC", Offset = "0x10F2EFC")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060075D8 RID: 30168 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60075D8")]
			[Address(RVA = "0x21544F8", Offset = "0x21544F8", VA = "0x7BBC9544F8")]
			public <>c()
			{
			}

			// Token: 0x060075D9 RID: 30169 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60075D9")]
			[Address(RVA = "0x2154500", Offset = "0x2154500", VA = "0x7BBC954500")]
			internal void <UpdateFreeCDLabel>b__25_0()
			{
			}

			// Token: 0x04008D10 RID: 36112
			[Token(Token = "0x4008D10")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIGachaBuyBtnController.<>c <>9;

			// Token: 0x04008D11 RID: 36113
			[Token(Token = "0x4008D11")]
			[FieldOffset(Offset = "0x8")]
			public static Action <>9__25_0;
		}
	}
}
