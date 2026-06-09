using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001800 RID: 6144
	[Token(Token = "0x2001800")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F33A4", Offset = "0x10F33A4")]
	internal class UIGachaLimitContent : UIGachaContentBase, IUIModelDataChangeObserver
	{
		// Token: 0x06007758 RID: 30552 RVA: 0x00020FE8 File Offset: 0x0001F1E8
		[Token(Token = "0x6007758")]
		[Address(RVA = "0x205D798", Offset = "0x205D798", VA = "0x7BBC85D798")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007759 RID: 30553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007759")]
		[Address(RVA = "0x205D7E8", Offset = "0x205D7E8", VA = "0x7BBC85D7E8", Slot = "50")]
		public override string GetTutorialWndTitleKey()
		{
			return null;
		}

		// Token: 0x0600775A RID: 30554 RVA: 0x00021000 File Offset: 0x0001F200
		[Token(Token = "0x600775A")]
		[Address(RVA = "0x205D830", Offset = "0x205D830", VA = "0x7BBC85D830", Slot = "47")]
		public override uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600775B RID: 30555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600775B")]
		[Address(RVA = "0x205D874", Offset = "0x205D874", VA = "0x7BBC85D874", Slot = "46")]
		public override void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600775C RID: 30556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600775C")]
		[Address(RVA = "0x205DE0C", Offset = "0x205DE0C", VA = "0x7BBC85DE0C", Slot = "44")]
		public override void GetPreviewSceneBorder(uint gachaID, out Vector3 left, out Vector3 right)
		{
		}

		// Token: 0x0600775D RID: 30557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600775D")]
		[Address(RVA = "0x205DF28", Offset = "0x205DF28", VA = "0x7BBC85DF28", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600775E RID: 30558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600775E")]
		[Address(RVA = "0x205E7F0", Offset = "0x205E7F0", VA = "0x7BBC85E7F0", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x0600775F RID: 30559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600775F")]
		[Address(RVA = "0x205E7F8", Offset = "0x205E7F8", VA = "0x7BBC85E7F8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007760 RID: 30560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007760")]
		[Address(RVA = "0x205EA60", Offset = "0x205EA60", VA = "0x7BBC85EA60", Slot = "38")]
		public override void OnSkipAnim()
		{
		}

		// Token: 0x06007761 RID: 30561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007761")]
		[Address(RVA = "0x205EC70", Offset = "0x205EC70", VA = "0x7BBC85EC70")]
		private void OnDrawResultShowFinish(params object[] data)
		{
		}

		// Token: 0x06007762 RID: 30562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007762")]
		[Address(RVA = "0x205E6E8", Offset = "0x205E6E8", VA = "0x7BBC85E6E8")]
		private void InitExtraAwardList()
		{
		}

		// Token: 0x06007763 RID: 30563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007763")]
		[Address(RVA = "0x205ED84", Offset = "0x205ED84", VA = "0x7BBC85ED84")]
		private void ShowExtraPreviewWnd(params object[] data)
		{
		}

		// Token: 0x06007764 RID: 30564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007764")]
		[Address(RVA = "0x205EF4C", Offset = "0x205EF4C", VA = "0x7BBC85EF4C")]
		private void ShowExchangeResultWnd(params object[] data)
		{
		}

		// Token: 0x06007765 RID: 30565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007765")]
		[Address(RVA = "0x205F2F8", Offset = "0x205F2F8", VA = "0x7BBC85F2F8")]
		public void RefreshExtraRewardList(uint chestID)
		{
		}

		// Token: 0x06007766 RID: 30566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007766")]
		[Address(RVA = "0x205F504", Offset = "0x205F504", VA = "0x7BBC85F504")]
		private void SetextraAwardActive(bool enable)
		{
		}

		// Token: 0x06007767 RID: 30567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007767")]
		[Address(RVA = "0x205F560", Offset = "0x205F560", VA = "0x7BBC85F560")]
		private void ShowRareProbabilityTips(params object[] param)
		{
		}

		// Token: 0x06007768 RID: 30568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007768")]
		[Address(RVA = "0x205E388", Offset = "0x205E388", VA = "0x7BBC85E388")]
		private void AssembleTurntable()
		{
		}

		// Token: 0x06007769 RID: 30569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007769")]
		[Address(RVA = "0x205FB48", Offset = "0x205FB48", VA = "0x7BBC85FB48", Slot = "30")]
		protected override void InitGachaContentBuyBtn()
		{
		}

		// Token: 0x0600776A RID: 30570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600776A")]
		[Address(RVA = "0x205FC0C", Offset = "0x205FC0C", VA = "0x7BBC85FC0C")]
		private void RefreshAllBtnState(bool finishRemove)
		{
		}

		// Token: 0x0600776B RID: 30571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600776B")]
		[Address(RVA = "0x2060108", Offset = "0x2060108", VA = "0x7BBC860108", Slot = "45")]
		protected override void OnPreviewSceneShowTypeChange()
		{
		}

		// Token: 0x0600776C RID: 30572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600776C")]
		[Address(RVA = "0x2060164", Offset = "0x2060164", VA = "0x7BBC860164", Slot = "31")]
		protected override void OnRefreshUIView()
		{
		}

		// Token: 0x0600776D RID: 30573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600776D")]
		[Address(RVA = "0x205D900", Offset = "0x205D900", VA = "0x7BBC85D900")]
		private void RefreshRewardPool(bool needResetState = true)
		{
		}

		// Token: 0x0600776E RID: 30574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600776E")]
		[Address(RVA = "0x2060368", Offset = "0x2060368", VA = "0x7BBC860368")]
		private void RefreshCountDownLabel()
		{
		}

		// Token: 0x0600776F RID: 30575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600776F")]
		[Address(RVA = "0x2060F98", Offset = "0x2060F98", VA = "0x7BBC860F98", Slot = "35")]
		public override void OnShowContent()
		{
		}

		// Token: 0x06007770 RID: 30576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007770")]
		[Address(RVA = "0x206109C", Offset = "0x206109C", VA = "0x7BBC86109C", Slot = "37")]
		public override void OnPurchaseResult(bool isSuccess)
		{
		}

		// Token: 0x06007771 RID: 30577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007771")]
		[Address(RVA = "0x2061424", Offset = "0x2061424", VA = "0x7BBC861424")]
		private void OnRemoveClick()
		{
		}

		// Token: 0x06007772 RID: 30578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007772")]
		[Address(RVA = "0x2061944", Offset = "0x2061944", VA = "0x7BBC861944")]
		private void OnRareProbabilityClick()
		{
		}

		// Token: 0x06007773 RID: 30579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007773")]
		[Address(RVA = "0x20611E8", Offset = "0x20611E8", VA = "0x7BBC8611E8")]
		public void Circle(GachaResultInfo info)
		{
		}

		// Token: 0x06007774 RID: 30580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007774")]
		[Address(RVA = "0x206227C", Offset = "0x206227C", VA = "0x7BBC86227C", Slot = "34")]
		public override void OnHideContent()
		{
		}

		// Token: 0x06007775 RID: 30581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007775")]
		[Address(RVA = "0x20620BC", Offset = "0x20620BC", VA = "0x7BBC8620BC")]
		private void DoCircle()
		{
		}

		// Token: 0x06007776 RID: 30582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007776")]
		[Address(RVA = "0x20624B8", Offset = "0x20624B8", VA = "0x7BBC8624B8")]
		private void SetOutstand(int idx, UIGachaLimitItemController.ViewStage stage)
		{
		}

		// Token: 0x06007777 RID: 30583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007777")]
		[Address(RVA = "0x20626C0", Offset = "0x20626C0", VA = "0x7BBC8626C0")]
		private void ShowResultView()
		{
		}

		// Token: 0x06007778 RID: 30584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007778")]
		[Address(RVA = "0x205EB40", Offset = "0x205EB40", VA = "0x7BBC85EB40")]
		private void ShowDrawResult(UIModelGacha.GachaDrawType dType, bool enableAnim = true)
		{
		}

		// Token: 0x06007779 RID: 30585 RVA: 0x00021018 File Offset: 0x0001F218
		[Token(Token = "0x6007779")]
		[Address(RVA = "0x20622F8", Offset = "0x20622F8", VA = "0x7BBC8622F8")]
		private UIGachaLimitContent.CircleStage GetCircleStage(int curIterationCounter)
		{
			return UIGachaLimitContent.CircleStage.NORMAL_RUNNING;
		}

		// Token: 0x0600777A RID: 30586 RVA: 0x00021030 File Offset: 0x0001F230
		[Token(Token = "0x600777A")]
		[Address(RVA = "0x2062788", Offset = "0x2062788", VA = "0x7BBC862788")]
		private int RandomFindIdx(ExchangedAward award)
		{
			return 0;
		}

		// Token: 0x0600777B RID: 30587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600777B")]
		[Address(RVA = "0x2061AC4", Offset = "0x2061AC4", VA = "0x7BBC861AC4")]
		private void Reset()
		{
		}

		// Token: 0x0600777C RID: 30588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600777C")]
		[Address(RVA = "0x206129C", Offset = "0x206129C", VA = "0x7BBC86129C")]
		private void EnableInterfaceMask(bool v)
		{
		}

		// Token: 0x0600777D RID: 30589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600777D")]
		[Address(RVA = "0x2061C74", Offset = "0x2061C74", VA = "0x7BBC861C74")]
		private void GenRewardIndexList(GachaResultInfo info)
		{
		}

		// Token: 0x0600777E RID: 30590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600777E")]
		[Address(RVA = "0x2061F7C", Offset = "0x2061F7C", VA = "0x7BBC861F7C")]
		private void BuildFirstLapRateCurve()
		{
		}

		// Token: 0x0600777F RID: 30591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600777F")]
		[Address(RVA = "0x2062A78", Offset = "0x2062A78", VA = "0x7BBC862A78")]
		public void SetItemPreviewState(BaseItemInfo info, int index = 0)
		{
		}

		// Token: 0x06007780 RID: 30592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007780")]
		[Address(RVA = "0x2062FD4", Offset = "0x2062FD4", VA = "0x7BBC862FD4", Slot = "49")]
		public override UIGachaPreviewController OpenPreviewPanel(Transform parent)
		{
			return null;
		}

		// Token: 0x06007781 RID: 30593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007781")]
		[Address(RVA = "0x2063068", Offset = "0x2063068", VA = "0x7BBC863068", Slot = "42")]
		public override void OnRewardPoolOpen()
		{
		}

		// Token: 0x06007782 RID: 30594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007782")]
		[Address(RVA = "0x20631B8", Offset = "0x20631B8", VA = "0x7BBC8631B8", Slot = "41")]
		public override void OnRewardPoolClose()
		{
		}

		// Token: 0x06007783 RID: 30595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007783")]
		[Address(RVA = "0x2063424", Offset = "0x2063424", VA = "0x7BBC863424")]
		private void OnClosePreviewClick()
		{
		}

		// Token: 0x06007784 RID: 30596 RVA: 0x00021048 File Offset: 0x0001F248
		[Token(Token = "0x6007784")]
		[Address(RVA = "0x20625E4", Offset = "0x20625E4", VA = "0x7BBC8625E4")]
		private float RateSample(int curIterationCounter)
		{
			return 0f;
		}

		// Token: 0x06007785 RID: 30597 RVA: 0x00021060 File Offset: 0x0001F260
		[Token(Token = "0x6007785")]
		[Address(RVA = "0x20634C0", Offset = "0x20634C0", VA = "0x7BBC8634C0")]
		private bool IsInFirstCircle(int curIdx)
		{
			return default(bool);
		}

		// Token: 0x06007786 RID: 30598 RVA: 0x00021078 File Offset: 0x0001F278
		[Token(Token = "0x6007786")]
		[Address(RVA = "0x2063584", Offset = "0x2063584", VA = "0x7BBC863584")]
		private float RateCelling(float rate)
		{
			return 0f;
		}

		// Token: 0x06007787 RID: 30599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007787")]
		[Address(RVA = "0x2063594", Offset = "0x2063594", VA = "0x7BBC863594")]
		public UIGachaLimitContent()
		{
		}

		// Token: 0x06007788 RID: 30600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007788")]
		[Address(RVA = "0x2063694", Offset = "0x2063694", VA = "0x7BBC863694")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1141CF0", Offset = "0x1141CF0")]
		private void <ShowResultView>b__52_0()
		{
		}

		// Token: 0x04008DC4 RID: 36292
		[Token(Token = "0x4008DC4")]
		[FieldOffset(Offset = "0x75")]
		private bool isInPreview;

		// Token: 0x04008DC5 RID: 36293
		[Token(Token = "0x4008DC5")]
		[FieldOffset(Offset = "0x78")]
		private UIGachaLimitContentView m_View;

		// Token: 0x04008DC6 RID: 36294
		[Token(Token = "0x4008DC6")]
		[FieldOffset(Offset = "0x80")]
		private List<GameObject> m_ItemPosList;

		// Token: 0x04008DC7 RID: 36295
		[Token(Token = "0x4008DC7")]
		[FieldOffset(Offset = "0x88")]
		private List<UIGachaLimitItemController> m_ItemCtrlList;

		// Token: 0x04008DC8 RID: 36296
		[Token(Token = "0x4008DC8")]
		[FieldOffset(Offset = "0x90")]
		private List<UIGachaLimitExtraListItemController> m_ExtraList;

		// Token: 0x04008DC9 RID: 36297
		[Token(Token = "0x4008DC9")]
		[FieldOffset(Offset = "0x98")]
		private UIModelGacha m_ModelGacha;

		// Token: 0x04008DCA RID: 36298
		[Token(Token = "0x4008DCA")]
		[FieldOffset(Offset = "0xA0")]
		private GachaLimitInfoData m_GachaInfo;

		// Token: 0x04008DCB RID: 36299
		[Token(Token = "0x4008DCB")]
		[FieldOffset(Offset = "0xA8")]
		private UIGachaLimitContent.RateCurve m_Curve;

		// Token: 0x04008DCC RID: 36300
		[Token(Token = "0x4008DCC")]
		[FieldOffset(Offset = "0xB0")]
		private List<UIGachaLimitContent.RewardIdx> m_RewardIdxList;

		// Token: 0x04008DCD RID: 36301
		[Token(Token = "0x4008DCD")]
		[FieldOffset(Offset = "0xB8")]
		private int m_CurRewardIdx;

		// Token: 0x04008DCE RID: 36302
		[Token(Token = "0x4008DCE")]
		[FieldOffset(Offset = "0xBC")]
		private int m_IterationCounter;

		// Token: 0x04008DCF RID: 36303
		[Token(Token = "0x4008DCF")]
		[FieldOffset(Offset = "0xC0")]
		private uint m_CircleDC;

		// Token: 0x04008DD0 RID: 36304
		[Token(Token = "0x4008DD0")]
		[FieldOffset(Offset = "0xC4")]
		private bool m_IsSingleCircle;

		// Token: 0x04008DD1 RID: 36305
		[Token(Token = "0x4008DD1")]
		[FieldOffset(Offset = "0xC5")]
		private bool m_IsSkip;

		// Token: 0x04008DD2 RID: 36306
		[Token(Token = "0x4008DD2")]
		private const int FAKE_CIRCLE_CNT = 2;

		// Token: 0x04008DD3 RID: 36307
		[Token(Token = "0x4008DD3")]
		private const int TURNTABLE_REWARD_CNT = 10;

		// Token: 0x04008DD4 RID: 36308
		[Token(Token = "0x4008DD4")]
		private const float GET_REWARD_SHOW_SECOND = 1f;

		// Token: 0x04008DD5 RID: 36309
		[Token(Token = "0x4008DD5")]
		private const float FAST_ROUND_CD_SECOND = 0.05f;

		// Token: 0x02001801 RID: 6145
		[Token(Token = "0x2001801")]
		private enum CircleStage
		{
			// Token: 0x04008DD7 RID: 36311
			[Token(Token = "0x4008DD7")]
			NORMAL_RUNNING,
			// Token: 0x04008DD8 RID: 36312
			[Token(Token = "0x4008DD8")]
			GET_REWARD,
			// Token: 0x04008DD9 RID: 36313
			[Token(Token = "0x4008DD9")]
			END
		}

		// Token: 0x02001802 RID: 6146
		[Token(Token = "0x2001802")]
		private class RewardIdx
		{
			// Token: 0x06007789 RID: 30601 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007789")]
			[Address(RVA = "0x2062A70", Offset = "0x2062A70", VA = "0x7BBC862A70")]
			public RewardIdx()
			{
			}

			// Token: 0x04008DDA RID: 36314
			[Token(Token = "0x4008DDA")]
			[FieldOffset(Offset = "0x10")]
			public int idx;

			// Token: 0x04008DDB RID: 36315
			[Token(Token = "0x4008DDB")]
			[FieldOffset(Offset = "0x14")]
			public int iterationIdx;
		}

		// Token: 0x02001803 RID: 6147
		[Token(Token = "0x2001803")]
		private class RateCurve
		{
			// Token: 0x0600778A RID: 30602 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600778A")]
			[Address(RVA = "0x2063680", Offset = "0x2063680", VA = "0x7BBC863680")]
			public RateCurve()
			{
			}

			// Token: 0x04008DDC RID: 36316
			[Token(Token = "0x4008DDC")]
			[FieldOffset(Offset = "0x10")]
			public float a;

			// Token: 0x04008DDD RID: 36317
			[Token(Token = "0x4008DDD")]
			[FieldOffset(Offset = "0x14")]
			public int powers;

			// Token: 0x04008DDE RID: 36318
			[Token(Token = "0x4008DDE")]
			[FieldOffset(Offset = "0x18")]
			public float endY;
		}

		// Token: 0x02001804 RID: 6148
		[Token(Token = "0x2001804")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F33DC", Offset = "0x10F33DC")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600778C RID: 30604 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600778C")]
			[Address(RVA = "0x2063724", Offset = "0x2063724", VA = "0x7BBC863724")]
			public <>c()
			{
			}

			// Token: 0x0600778D RID: 30605 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600778D")]
			[Address(RVA = "0x206372C", Offset = "0x206372C", VA = "0x7BBC86372C")]
			internal CommonRewardItemInfo <ShowExchangeResultWnd>b__19_0(ExchangedAward item)
			{
				return null;
			}

			// Token: 0x0600778E RID: 30606 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600778E")]
			[Address(RVA = "0x2063738", Offset = "0x2063738", VA = "0x7BBC863738")]
			internal void <ShowExchangeResultWnd>b__19_1()
			{
			}

			// Token: 0x04008DDF RID: 36319
			[Token(Token = "0x4008DDF")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIGachaLimitContent.<>c <>9;

			// Token: 0x04008DE0 RID: 36320
			[Token(Token = "0x4008DE0")]
			[FieldOffset(Offset = "0x8")]
			public static Converter<ExchangedAward, CommonRewardItemInfo> <>9__19_0;

			// Token: 0x04008DE1 RID: 36321
			[Token(Token = "0x4008DE1")]
			[FieldOffset(Offset = "0x10")]
			public static Action <>9__19_1;
		}
	}
}
