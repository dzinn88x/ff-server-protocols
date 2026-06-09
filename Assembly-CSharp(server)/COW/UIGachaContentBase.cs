using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x020017DE RID: 6110
	[Token(Token = "0x20017DE")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F2F0C", Offset = "0x10F2F0C")]
	public abstract class UIGachaContentBase : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x060075DA RID: 30170
		[Token(Token = "0x60075DA")]
		protected abstract void InitGachaContentBuyBtn();

		// Token: 0x060075DB RID: 30171
		[Token(Token = "0x60075DB")]
		protected abstract void OnRefreshUIView();

		// Token: 0x060075DC RID: 30172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075DC")]
		[Address(RVA = "0x21548D0", Offset = "0x21548D0", VA = "0x7BBC9548D0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060075DD RID: 30173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075DD")]
		[Address(RVA = "0x2154B6C", Offset = "0x2154B6C", VA = "0x7BBC954B6C", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060075DE RID: 30174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075DE")]
		[Address(RVA = "0x2154B74", Offset = "0x2154B74", VA = "0x7BBC954B74", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060075DF RID: 30175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075DF")]
		[Address(RVA = "0x2154CAC", Offset = "0x2154CAC", VA = "0x7BBC954CAC")]
		public void RefreshUIView(uint chestID)
		{
		}

		// Token: 0x060075E0 RID: 30176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075E0")]
		[Address(RVA = "0x2154CEC", Offset = "0x2154CEC", VA = "0x7BBC954CEC")]
		public void SetDefaultShowType(UIGachaSceneShowType curType)
		{
		}

		// Token: 0x060075E1 RID: 30177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075E1")]
		[Address(RVA = "0x2154CF4", Offset = "0x2154CF4", VA = "0x7BBC954CF4")]
		public UIGachaContentViewSetting GetGameViewSettig()
		{
			return null;
		}

		// Token: 0x060075E2 RID: 30178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075E2")]
		[Address(RVA = "0x2154CFC", Offset = "0x2154CFC", VA = "0x7BBC954CFC", Slot = "32")]
		public virtual void OnReplayFullScreenAnim()
		{
		}

		// Token: 0x060075E3 RID: 30179 RVA: 0x00020B68 File Offset: 0x0001ED68
		[Token(Token = "0x60075E3")]
		[Address(RVA = "0x2154D00", Offset = "0x2154D00", VA = "0x7BBC954D00", Slot = "33")]
		public virtual uint GetCurrentExchangeItemID()
		{
			return 0U;
		}

		// Token: 0x060075E4 RID: 30180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075E4")]
		[Address(RVA = "0x2154D08", Offset = "0x2154D08", VA = "0x7BBC954D08", Slot = "34")]
		public virtual void OnHideContent()
		{
		}

		// Token: 0x060075E5 RID: 30181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075E5")]
		[Address(RVA = "0x2154D0C", Offset = "0x2154D0C", VA = "0x7BBC954D0C", Slot = "35")]
		public virtual void OnShowContent()
		{
		}

		// Token: 0x060075E6 RID: 30182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075E6")]
		[Address(RVA = "0x2154D10", Offset = "0x2154D10", VA = "0x7BBC954D10", Slot = "36")]
		public virtual void RefreshBuyBtnState()
		{
		}

		// Token: 0x060075E7 RID: 30183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075E7")]
		[Address(RVA = "0x2154DB4", Offset = "0x2154DB4", VA = "0x7BBC954DB4", Slot = "37")]
		public virtual void OnPurchaseResult(bool isSuccess)
		{
		}

		// Token: 0x060075E8 RID: 30184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075E8")]
		[Address(RVA = "0x2154DB8", Offset = "0x2154DB8", VA = "0x7BBC954DB8", Slot = "38")]
		public virtual void OnSkipAnim()
		{
		}

		// Token: 0x060075E9 RID: 30185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075E9")]
		[Address(RVA = "0x2154DBC", Offset = "0x2154DBC", VA = "0x7BBC954DBC", Slot = "39")]
		public virtual void OnSkipFullScreenAnim()
		{
		}

		// Token: 0x060075EA RID: 30186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075EA")]
		[Address(RVA = "0x2154DC0", Offset = "0x2154DC0", VA = "0x7BBC954DC0", Slot = "40")]
		public virtual void OnFullScreenAnimOver()
		{
		}

		// Token: 0x060075EB RID: 30187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075EB")]
		[Address(RVA = "0x2154DC4", Offset = "0x2154DC4", VA = "0x7BBC954DC4", Slot = "41")]
		public virtual void OnRewardPoolClose()
		{
		}

		// Token: 0x060075EC RID: 30188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075EC")]
		[Address(RVA = "0x2154DC8", Offset = "0x2154DC8", VA = "0x7BBC954DC8", Slot = "42")]
		public virtual void OnRewardPoolOpen()
		{
		}

		// Token: 0x060075ED RID: 30189 RVA: 0x00020B80 File Offset: 0x0001ED80
		[Token(Token = "0x60075ED")]
		[Address(RVA = "0x2154DCC", Offset = "0x2154DCC", VA = "0x7BBC954DCC", Slot = "43")]
		public virtual Vector3 GetAvatarPos()
		{
			return default(Vector3);
		}

		// Token: 0x060075EE RID: 30190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075EE")]
		[Address(RVA = "0x2154E18", Offset = "0x2154E18", VA = "0x7BBC954E18", Slot = "44")]
		public virtual void GetPreviewSceneBorder(uint gachaID, out Vector3 left, out Vector3 right)
		{
		}

		// Token: 0x060075EF RID: 30191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075EF")]
		[Address(RVA = "0x2154EA4", Offset = "0x2154EA4", VA = "0x7BBC954EA4")]
		protected void AdjustWidgtDimFullScreen(UIWidget widget)
		{
		}

		// Token: 0x060075F0 RID: 30192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075F0")]
		[Address(RVA = "0x2154F4C", Offset = "0x2154F4C", VA = "0x7BBC954F4C")]
		protected void OpenCommonRewardWnd(UICommonRewardWndController.WndStyleEnum style, UIModelGacha.GachaDrawType dType, UIGachaBuyBtnController.BuyBtnState state, bool enableAnim, uint constrepurchaseNum = 0U, string desc = "", bool useNewItem = false)
		{
		}

		// Token: 0x060075F1 RID: 30193 RVA: 0x00020B98 File Offset: 0x0001ED98
		[Token(Token = "0x60075F1")]
		[Address(RVA = "0x2156204", Offset = "0x2156204", VA = "0x7BBC956204")]
		private uint GetSecondGooldAwardID(List<ExchangedAward> allAwards)
		{
			return 0U;
		}

		// Token: 0x060075F2 RID: 30194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075F2")]
		[Address(RVA = "0x2156424", Offset = "0x2156424", VA = "0x7BBC956424")]
		private void OnPreviewSceneShowTypeChange(params object[] data)
		{
		}

		// Token: 0x060075F3 RID: 30195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075F3")]
		[Address(RVA = "0x21564C0", Offset = "0x21564C0", VA = "0x7BBC9564C0", Slot = "45")]
		protected virtual void OnPreviewSceneShowTypeChange()
		{
		}

		// Token: 0x060075F4 RID: 30196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075F4")]
		[Address(RVA = "0x2156168", Offset = "0x2156168", VA = "0x7BBC956168")]
		private void PlayPopResultSound()
		{
		}

		// Token: 0x060075F5 RID: 30197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075F5")]
		[Address(RVA = "0x21564C4", Offset = "0x21564C4", VA = "0x7BBC9564C4", Slot = "46")]
		public virtual void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060075F6 RID: 30198 RVA: 0x00020BB0 File Offset: 0x0001EDB0
		[Token(Token = "0x60075F6")]
		[Address(RVA = "0x2156568", Offset = "0x2156568", VA = "0x7BBC956568", Slot = "47")]
		public virtual uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060075F7 RID: 30199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075F7")]
		[Address(RVA = "0x21565AC", Offset = "0x21565AC", VA = "0x7BBC9565AC", Slot = "48")]
		protected virtual void OnCloseRewardPanel()
		{
		}

		// Token: 0x060075F8 RID: 30200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075F8")]
		[Address(RVA = "0x21565B0", Offset = "0x21565B0", VA = "0x7BBC9565B0", Slot = "49")]
		public virtual UIGachaPreviewController OpenPreviewPanel(Transform parent)
		{
			return null;
		}

		// Token: 0x060075F9 RID: 30201
		[Token(Token = "0x60075F9")]
		public abstract string GetTutorialWndTitleKey();

		// Token: 0x060075FA RID: 30202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075FA")]
		[Address(RVA = "0x2156644", Offset = "0x2156644", VA = "0x7BBC956644")]
		protected UIGachaContentBase()
		{
		}

		// Token: 0x060075FB RID: 30203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075FB")]
		[Address(RVA = "0x215664C", Offset = "0x215664C", VA = "0x7BBC95664C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11419E0", Offset = "0x11419E0")]
		private GachaShowItem <GetSecondGooldAwardID>b__28_0(ExchangedAward item)
		{
			return null;
		}

		// Token: 0x04008D12 RID: 36114
		[Token(Token = "0x4008D12")]
		[FieldOffset(Offset = "0x58")]
		protected uint m_GachaID;

		// Token: 0x04008D13 RID: 36115
		[Token(Token = "0x4008D13")]
		[FieldOffset(Offset = "0x60")]
		protected UIGachaBuyBtnController m_GachaBuyBtnCtrl;

		// Token: 0x04008D14 RID: 36116
		[Token(Token = "0x4008D14")]
		[FieldOffset(Offset = "0x68")]
		protected UIGachaContentViewSetting m_ContentViewSetting;

		// Token: 0x04008D15 RID: 36117
		[Token(Token = "0x4008D15")]
		[FieldOffset(Offset = "0x70")]
		protected UIGachaSceneShowType m_CurrentShowType;

		// Token: 0x04008D16 RID: 36118
		[Token(Token = "0x4008D16")]
		[FieldOffset(Offset = "0x74")]
		protected bool IsFirstEnter;

		// Token: 0x020017DF RID: 6111
		[Token(Token = "0x20017DF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F2F44", Offset = "0x10F2F44")]
		private sealed class <>c__DisplayClass27_0
		{
			// Token: 0x060075FC RID: 30204 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60075FC")]
			[Address(RVA = "0x2156160", Offset = "0x2156160", VA = "0x7BBC956160")]
			public <>c__DisplayClass27_0()
			{
			}

			// Token: 0x060075FD RID: 30205 RVA: 0x00020BC8 File Offset: 0x0001EDC8
			[Token(Token = "0x60075FD")]
			[Address(RVA = "0x21567B4", Offset = "0x21567B4", VA = "0x7BBC9567B4")]
			internal bool <OpenCommonRewardWnd>b__2(ExchangedAward item)
			{
				return default(bool);
			}

			// Token: 0x060075FE RID: 30206 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60075FE")]
			[Address(RVA = "0x2156814", Offset = "0x2156814", VA = "0x7BBC956814")]
			internal void <OpenCommonRewardWnd>b__1()
			{
			}

			// Token: 0x04008D17 RID: 36119
			[Token(Token = "0x4008D17")]
			[FieldOffset(Offset = "0x10")]
			public UIGachaContentBase <>4__this;

			// Token: 0x04008D18 RID: 36120
			[Token(Token = "0x4008D18")]
			[FieldOffset(Offset = "0x18")]
			public List<ExchangedAward> allRewardList;
		}

		// Token: 0x020017E0 RID: 6112
		[Token(Token = "0x20017E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F2F54", Offset = "0x10F2F54")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06007600 RID: 30208 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007600")]
			[Address(RVA = "0x21567A0", Offset = "0x21567A0", VA = "0x7BBC9567A0")]
			public <>c()
			{
			}

			// Token: 0x06007601 RID: 30209 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007601")]
			[Address(RVA = "0x21567A8", Offset = "0x21567A8", VA = "0x7BBC9567A8")]
			internal CommonRewardItemInfo <OpenCommonRewardWnd>b__27_0(ExchangedAward item)
			{
				return null;
			}

			// Token: 0x04008D19 RID: 36121
			[Token(Token = "0x4008D19")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIGachaContentBase.<>c <>9;

			// Token: 0x04008D1A RID: 36122
			[Token(Token = "0x4008D1A")]
			[FieldOffset(Offset = "0x8")]
			public static Converter<ExchangedAward, CommonRewardItemInfo> <>9__27_0;
		}
	}
}
