using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001826 RID: 6182
	[Token(Token = "0x2001826")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F37B4", Offset = "0x10F37B4")]
	public class UIGachaTurntableContent : UIGachaContentBase
	{
		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x060078CD RID: 30925 RVA: 0x00021420 File Offset: 0x0001F620
		// (set) Token: 0x060078CC RID: 30924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700096B")]
		public bool IsSkip
		{
			[Token(Token = "0x60078CD")]
			[Address(RVA = "0x1FA9E88", Offset = "0x1FA9E88", VA = "0x7BBC7A9E88")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60078CC")]
			[Address(RVA = "0x1FA9E7C", Offset = "0x1FA9E7C", VA = "0x7BBC7A9E7C")]
			set
			{
			}
		}

		// Token: 0x060078CE RID: 30926 RVA: 0x00021438 File Offset: 0x0001F638
		[Token(Token = "0x60078CE")]
		[Address(RVA = "0x1FA9E90", Offset = "0x1FA9E90", VA = "0x7BBC7A9E90")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060078CF RID: 30927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60078CF")]
		[Address(RVA = "0x1FA9EE0", Offset = "0x1FA9EE0", VA = "0x7BBC7A9EE0", Slot = "50")]
		public override string GetTutorialWndTitleKey()
		{
			return null;
		}

		// Token: 0x060078D0 RID: 30928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078D0")]
		[Address(RVA = "0x1FA9F28", Offset = "0x1FA9F28", VA = "0x7BBC7A9F28", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060078D1 RID: 30929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078D1")]
		[Address(RVA = "0x1FAA710", Offset = "0x1FAA710", VA = "0x7BBC7AA710", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060078D2 RID: 30930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078D2")]
		[Address(RVA = "0x1FAA718", Offset = "0x1FAA718", VA = "0x7BBC7AA718", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060078D3 RID: 30931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078D3")]
		[Address(RVA = "0x1FAA864", Offset = "0x1FAA864", VA = "0x7BBC7AA864", Slot = "35")]
		public override void OnShowContent()
		{
		}

		// Token: 0x060078D4 RID: 30932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078D4")]
		[Address(RVA = "0x1FAA968", Offset = "0x1FAA968", VA = "0x7BBC7AA968")]
		private void Update()
		{
		}

		// Token: 0x060078D5 RID: 30933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078D5")]
		[Address(RVA = "0x1FAABE4", Offset = "0x1FAABE4", VA = "0x7BBC7AABE4")]
		private void ResetItemAnim()
		{
		}

		// Token: 0x060078D6 RID: 30934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078D6")]
		[Address(RVA = "0x1FAAE24", Offset = "0x1FAAE24", VA = "0x7BBC7AAE24", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x060078D7 RID: 30935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078D7")]
		[Address(RVA = "0x1FAAE70", Offset = "0x1FAAE70", VA = "0x7BBC7AAE70", Slot = "30")]
		protected override void InitGachaContentBuyBtn()
		{
		}

		// Token: 0x060078D8 RID: 30936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078D8")]
		[Address(RVA = "0x1FAAF34", Offset = "0x1FAAF34", VA = "0x7BBC7AAF34")]
		private void ProcessAnimEvt(params object[] data)
		{
		}

		// Token: 0x060078D9 RID: 30937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078D9")]
		[Address(RVA = "0x1FAB088", Offset = "0x1FAB088", VA = "0x7BBC7AB088", Slot = "31")]
		protected override void OnRefreshUIView()
		{
		}

		// Token: 0x060078DA RID: 30938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078DA")]
		[Address(RVA = "0x1FAC17C", Offset = "0x1FAC17C", VA = "0x7BBC7AC17C")]
		private void RefreshCountDownLabel()
		{
		}

		// Token: 0x060078DB RID: 30939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078DB")]
		[Address(RVA = "0x1FAC558", Offset = "0x1FAC558", VA = "0x7BBC7AC558", Slot = "37")]
		public override void OnPurchaseResult(bool isSuccess)
		{
		}

		// Token: 0x060078DC RID: 30940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078DC")]
		[Address(RVA = "0x1FAC7C8", Offset = "0x1FAC7C8", VA = "0x7BBC7AC7C8", Slot = "44")]
		public override void GetPreviewSceneBorder(uint gachaID, out Vector3 left, out Vector3 right)
		{
		}

		// Token: 0x060078DD RID: 30941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078DD")]
		[Address(RVA = "0x1FAC88C", Offset = "0x1FAC88C", VA = "0x7BBC7AC88C", Slot = "38")]
		public override void OnSkipAnim()
		{
		}

		// Token: 0x060078DE RID: 30942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078DE")]
		[Address(RVA = "0x1FAC714", Offset = "0x1FAC714", VA = "0x7BBC7AC714")]
		public void Circle(GachaResultInfo info)
		{
		}

		// Token: 0x060078DF RID: 30943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078DF")]
		[Address(RVA = "0x1FAA32C", Offset = "0x1FAA32C", VA = "0x7BBC7AA32C")]
		private void AssembleTurntable()
		{
		}

		// Token: 0x060078E0 RID: 30944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078E0")]
		[Address(RVA = "0x1FACCA8", Offset = "0x1FACCA8", VA = "0x7BBC7ACCA8")]
		private void GenRewardIndexList(GachaResultInfo info)
		{
		}

		// Token: 0x060078E1 RID: 30945 RVA: 0x00021450 File Offset: 0x0001F650
		[Token(Token = "0x60078E1")]
		[Address(RVA = "0x1FAD3DC", Offset = "0x1FAD3DC", VA = "0x7BBC7AD3DC")]
		private int RandomFindIdx(ExchangedAward award)
		{
			return 0;
		}

		// Token: 0x060078E2 RID: 30946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078E2")]
		[Address(RVA = "0x1FACF58", Offset = "0x1FACF58", VA = "0x7BBC7ACF58")]
		private void BuildFirstLapRateCurve()
		{
		}

		// Token: 0x060078E3 RID: 30947 RVA: 0x00021468 File Offset: 0x0001F668
		[Token(Token = "0x60078E3")]
		[Address(RVA = "0x1FAD69C", Offset = "0x1FAD69C", VA = "0x7BBC7AD69C")]
		private float RateSample(int curIterationCounter)
		{
			return 0f;
		}

		// Token: 0x060078E4 RID: 30948 RVA: 0x00021480 File Offset: 0x0001F680
		[Token(Token = "0x60078E4")]
		[Address(RVA = "0x1FAD83C", Offset = "0x1FAD83C", VA = "0x7BBC7AD83C")]
		private float RateCelling(float rate)
		{
			return 0f;
		}

		// Token: 0x060078E5 RID: 30949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078E5")]
		[Address(RVA = "0x1FAD1DC", Offset = "0x1FAD1DC", VA = "0x7BBC7AD1DC")]
		private void DoCircle()
		{
		}

		// Token: 0x060078E6 RID: 30950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078E6")]
		[Address(RVA = "0x1FADA0C", Offset = "0x1FADA0C", VA = "0x7BBC7ADA0C")]
		private void SetOutstand(int idx, UIGachaTurntableItemController.ViewStage stage)
		{
		}

		// Token: 0x060078E7 RID: 30951 RVA: 0x00021498 File Offset: 0x0001F698
		[Token(Token = "0x60078E7")]
		[Address(RVA = "0x1FAD84C", Offset = "0x1FAD84C", VA = "0x7BBC7AD84C")]
		private UIGachaTurntableContent.CircleStage GetCircleStage(int curIterationCounter)
		{
			return UIGachaTurntableContent.CircleStage.NORMAL_RUNNING;
		}

		// Token: 0x060078E8 RID: 30952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078E8")]
		[Address(RVA = "0x1FACAF8", Offset = "0x1FACAF8", VA = "0x7BBC7ACAF8")]
		private void Reset()
		{
		}

		// Token: 0x060078E9 RID: 30953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078E9")]
		[Address(RVA = "0x1FADC40", Offset = "0x1FADC40", VA = "0x7BBC7ADC40")]
		private void ShowResultView()
		{
		}

		// Token: 0x060078EA RID: 30954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078EA")]
		[Address(RVA = "0x1FAC96C", Offset = "0x1FAC96C", VA = "0x7BBC7AC96C")]
		private void ShowDrawResult(UIModelGacha.GachaDrawType dType, bool enableAnim = true)
		{
		}

		// Token: 0x060078EB RID: 30955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078EB")]
		[Address(RVA = "0x1FADD08", Offset = "0x1FADD08", VA = "0x7BBC7ADD08")]
		private void OnHatchingDoorClick()
		{
		}

		// Token: 0x060078EC RID: 30956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078EC")]
		[Address(RVA = "0x1FADFC4", Offset = "0x1FADFC4", VA = "0x7BBC7ADFC4")]
		private void OnRareProbabilityClick()
		{
		}

		// Token: 0x060078ED RID: 30957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078ED")]
		[Address(RVA = "0x1FAE074", Offset = "0x1FAE074", VA = "0x7BBC7AE074")]
		private void ShowRareProbabilityTips(params object[] param)
		{
		}

		// Token: 0x060078EE RID: 30958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078EE")]
		[Address(RVA = "0x1FAD054", Offset = "0x1FAD054", VA = "0x7BBC7AD054")]
		private void EnableInterfaceMask(bool v)
		{
		}

		// Token: 0x060078EF RID: 30959 RVA: 0x000214B0 File Offset: 0x0001F6B0
		[Token(Token = "0x60078EF")]
		[Address(RVA = "0x1FAD778", Offset = "0x1FAD778", VA = "0x7BBC7AD778")]
		private bool IsInFirstCircle(int curIdx)
		{
			return default(bool);
		}

		// Token: 0x060078F0 RID: 30960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078F0")]
		[Address(RVA = "0x1FAAFEC", Offset = "0x1FAAFEC", VA = "0x7BBC7AAFEC")]
		private void PlayTurntableShowSound()
		{
		}

		// Token: 0x060078F1 RID: 30961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078F1")]
		[Address(RVA = "0x1FAE30C", Offset = "0x1FAE30C", VA = "0x7BBC7AE30C")]
		private void DEBUG_ID(GachaResultInfo info)
		{
		}

		// Token: 0x060078F2 RID: 30962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078F2")]
		[Address(RVA = "0x1FAE788", Offset = "0x1FAE788", VA = "0x7BBC7AE788")]
		private void DEBUG_IDX()
		{
		}

		// Token: 0x060078F3 RID: 30963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078F3")]
		[Address(RVA = "0x1FAEA54", Offset = "0x1FAEA54", VA = "0x7BBC7AEA54")]
		public UIGachaTurntableContent()
		{
		}

		// Token: 0x060078F4 RID: 30964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078F4")]
		[Address(RVA = "0x1FAEB68", Offset = "0x1FAEB68", VA = "0x7BBC7AEB68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1141FF0", Offset = "0x1141FF0")]
		private void <ShowResultView>b__54_0()
		{
		}

		// Token: 0x04008E66 RID: 36454
		[Token(Token = "0x4008E66")]
		[FieldOffset(Offset = "0x78")]
		private UIGachaTurntableContentView m_View;

		// Token: 0x04008E67 RID: 36455
		[Token(Token = "0x4008E67")]
		[FieldOffset(Offset = "0x80")]
		private List<UIGachaTurntableContent.RewardIdx> m_RewardIdxList;

		// Token: 0x04008E68 RID: 36456
		[Token(Token = "0x4008E68")]
		[FieldOffset(Offset = "0x88")]
		private List<GameObject> m_ItemPosList;

		// Token: 0x04008E69 RID: 36457
		[Token(Token = "0x4008E69")]
		[FieldOffset(Offset = "0x90")]
		private List<UIGachaTurntableItemController> m_ItemCtrlList;

		// Token: 0x04008E6A RID: 36458
		[Token(Token = "0x4008E6A")]
		[FieldOffset(Offset = "0x98")]
		private int m_CurRewardIdx;

		// Token: 0x04008E6B RID: 36459
		[Token(Token = "0x4008E6B")]
		[FieldOffset(Offset = "0x9C")]
		private int m_IterationCounter;

		// Token: 0x04008E6C RID: 36460
		[Token(Token = "0x4008E6C")]
		[FieldOffset(Offset = "0xA0")]
		private uint m_CircleDC;

		// Token: 0x04008E6D RID: 36461
		[Token(Token = "0x4008E6D")]
		[FieldOffset(Offset = "0xA4")]
		private bool m_IsSingleCircle;

		// Token: 0x04008E6E RID: 36462
		[Token(Token = "0x4008E6E")]
		[FieldOffset(Offset = "0xA5")]
		private bool m_IsSkip;

		// Token: 0x04008E6F RID: 36463
		[Token(Token = "0x4008E6F")]
		private const int FAKE_CIRCLE_CNT = 3;

		// Token: 0x04008E70 RID: 36464
		[Token(Token = "0x4008E70")]
		private const int TURNTABLE_REWARD_CNT = 12;

		// Token: 0x04008E71 RID: 36465
		[Token(Token = "0x4008E71")]
		private const float GET_REWARD_SHOW_SECOND = 1f;

		// Token: 0x04008E72 RID: 36466
		[Token(Token = "0x4008E72")]
		private const float FAST_ROUND_CD_SECOND = 0.05f;

		// Token: 0x04008E73 RID: 36467
		[Token(Token = "0x4008E73")]
		[FieldOffset(Offset = "0xA8")]
		private UICountDownController m_CountDownCtrl;

		// Token: 0x04008E74 RID: 36468
		[Token(Token = "0x4008E74")]
		[FieldOffset(Offset = "0xB0")]
		private UIGachaTurntableContent.RateCurve m_Curve;

		// Token: 0x04008E75 RID: 36469
		[Token(Token = "0x4008E75")]
		[FieldOffset(Offset = "0xB8")]
		private List<UIGachaTurntableContent.PropsUI> m_PropsUIs;

		// Token: 0x04008E76 RID: 36470
		[Token(Token = "0x4008E76")]
		[FieldOffset(Offset = "0xC0")]
		private float m_ItemAnimCheckTime;

		// Token: 0x04008E77 RID: 36471
		[Token(Token = "0x4008E77")]
		[FieldOffset(Offset = "0xC4")]
		private int m_NextItemIndex;

		// Token: 0x04008E78 RID: 36472
		[Token(Token = "0x4008E78")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_CanPlayItemAnim;

		// Token: 0x04008E79 RID: 36473
		[Token(Token = "0x4008E79")]
		[FieldOffset(Offset = "0xCC")]
		private int m_ItemAnimInterval;

		// Token: 0x02001827 RID: 6183
		[Token(Token = "0x2001827")]
		private enum CircleStage
		{
			// Token: 0x04008E7B RID: 36475
			[Token(Token = "0x4008E7B")]
			NORMAL_RUNNING,
			// Token: 0x04008E7C RID: 36476
			[Token(Token = "0x4008E7C")]
			GET_REWARD,
			// Token: 0x04008E7D RID: 36477
			[Token(Token = "0x4008E7D")]
			END
		}

		// Token: 0x02001828 RID: 6184
		[Token(Token = "0x2001828")]
		private class RewardIdx
		{
			// Token: 0x060078F5 RID: 30965 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078F5")]
			[Address(RVA = "0x1FAD684", Offset = "0x1FAD684", VA = "0x7BBC7AD684")]
			public RewardIdx()
			{
			}

			// Token: 0x04008E7E RID: 36478
			[Token(Token = "0x4008E7E")]
			[FieldOffset(Offset = "0x10")]
			public int idx;

			// Token: 0x04008E7F RID: 36479
			[Token(Token = "0x4008E7F")]
			[FieldOffset(Offset = "0x14")]
			public int iterationIdx;
		}

		// Token: 0x02001829 RID: 6185
		[Token(Token = "0x2001829")]
		private class RateCurve
		{
			// Token: 0x060078F6 RID: 30966 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078F6")]
			[Address(RVA = "0x1FAEB50", Offset = "0x1FAEB50", VA = "0x7BBC7AEB50")]
			public RateCurve()
			{
			}

			// Token: 0x04008E80 RID: 36480
			[Token(Token = "0x4008E80")]
			[FieldOffset(Offset = "0x10")]
			public float a;

			// Token: 0x04008E81 RID: 36481
			[Token(Token = "0x4008E81")]
			[FieldOffset(Offset = "0x14")]
			public int powers;

			// Token: 0x04008E82 RID: 36482
			[Token(Token = "0x4008E82")]
			[FieldOffset(Offset = "0x18")]
			public float endY;
		}

		// Token: 0x0200182A RID: 6186
		[Token(Token = "0x200182A")]
		private class PropsUI
		{
			// Token: 0x060078F7 RID: 30967 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078F7")]
			[Address(RVA = "0x1FAC484", Offset = "0x1FAC484", VA = "0x7BBC7AC484")]
			public void SetActive(bool value)
			{
			}

			// Token: 0x060078F8 RID: 30968 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078F8")]
			[Address(RVA = "0x1FAA324", Offset = "0x1FAA324", VA = "0x7BBC7AA324")]
			public PropsUI()
			{
			}

			// Token: 0x04008E83 RID: 36483
			[Token(Token = "0x4008E83")]
			[FieldOffset(Offset = "0x10")]
			public UIEventListener eventListener;

			// Token: 0x04008E84 RID: 36484
			[Token(Token = "0x4008E84")]
			[FieldOffset(Offset = "0x18")]
			public UISprite icon;

			// Token: 0x04008E85 RID: 36485
			[Token(Token = "0x4008E85")]
			[FieldOffset(Offset = "0x20")]
			public UILabel count;
		}

		// Token: 0x0200182B RID: 6187
		[Token(Token = "0x200182B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F37EC", Offset = "0x10F37EC")]
		private sealed class <>c__DisplayClass38_0
		{
			// Token: 0x060078F9 RID: 30969 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078F9")]
			[Address(RVA = "0x1FAC550", Offset = "0x1FAC550", VA = "0x7BBC7AC550")]
			public <>c__DisplayClass38_0()
			{
			}

			// Token: 0x060078FA RID: 30970 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078FA")]
			[Address(RVA = "0x1FAEC34", Offset = "0x1FAEC34", VA = "0x7BBC7AEC34")]
			internal void <OnRefreshUIView>b__1(GameObject e)
			{
			}

			// Token: 0x04008E86 RID: 36486
			[Token(Token = "0x4008E86")]
			[FieldOffset(Offset = "0x10")]
			public CSSharedItemData itemData;
		}

		// Token: 0x0200182C RID: 6188
		[Token(Token = "0x200182C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F37FC", Offset = "0x10F37FC")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060078FC RID: 30972 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078FC")]
			[Address(RVA = "0x1FAEBF8", Offset = "0x1FAEBF8", VA = "0x7BBC7AEBF8")]
			public <>c()
			{
			}

			// Token: 0x060078FD RID: 30973 RVA: 0x000214C8 File Offset: 0x0001F6C8
			[Token(Token = "0x60078FD")]
			[Address(RVA = "0x1FAEC00", Offset = "0x1FAEC00", VA = "0x7BBC7AEC00")]
			internal bool <OnRefreshUIView>b__38_0(GachaShowItem e)
			{
				return default(bool);
			}

			// Token: 0x04008E87 RID: 36487
			[Token(Token = "0x4008E87")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIGachaTurntableContent.<>c <>9;

			// Token: 0x04008E88 RID: 36488
			[Token(Token = "0x4008E88")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<GachaShowItem> <>9__38_0;
		}
	}
}
