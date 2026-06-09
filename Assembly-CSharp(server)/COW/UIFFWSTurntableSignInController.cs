using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x0200136E RID: 4974
	[Token(Token = "0x200136E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EB518", Offset = "0x10EB518")]
	internal class UIFFWSTurntableSignInController : UINaviPopController, IUIModelDataChangeObserver
	{
		// Token: 0x06004FB8 RID: 20408 RVA: 0x000183D8 File Offset: 0x000165D8
		[Token(Token = "0x6004FB8")]
		[Address(RVA = "0x1DABABC", Offset = "0x1DABABC", VA = "0x7BBC5ABABC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06004FB9 RID: 20409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FB9")]
		[Address(RVA = "0x1DABB0C", Offset = "0x1DABB0C", VA = "0x7BBC5ABB0C", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06004FBA RID: 20410 RVA: 0x000183F0 File Offset: 0x000165F0
		[Token(Token = "0x6004FBA")]
		[Address(RVA = "0x1DAC758", Offset = "0x1DAC758", VA = "0x7BBC5AC758", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06004FBB RID: 20411 RVA: 0x00018408 File Offset: 0x00016608
		[Token(Token = "0x6004FBB")]
		[Address(RVA = "0x1DAC7DC", Offset = "0x1DAC7DC", VA = "0x7BBC5AC7DC", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x06004FBC RID: 20412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FBC")]
		[Address(RVA = "0x1DAC7E4", Offset = "0x1DAC7E4", VA = "0x7BBC5AC7E4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06004FBD RID: 20413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FBD")]
		[Address(RVA = "0x1DACF44", Offset = "0x1DACF44", VA = "0x7BBC5ACF44", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06004FBE RID: 20414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FBE")]
		[Address(RVA = "0x1DAD038", Offset = "0x1DAD038", VA = "0x7BBC5AD038", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06004FBF RID: 20415 RVA: 0x00018420 File Offset: 0x00016620
		[Token(Token = "0x6004FBF")]
		[Address(RVA = "0x1DAD188", Offset = "0x1DAD188", VA = "0x7BBC5AD188", Slot = "35")]
		public override EFrontendBGMType GetBGMType()
		{
			return EFrontendBGMType.NONE;
		}

		// Token: 0x06004FC0 RID: 20416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FC0")]
		[Address(RVA = "0x1DABECC", Offset = "0x1DABECC", VA = "0x7BBC5ABECC")]
		private void RefreshView()
		{
		}

		// Token: 0x06004FC1 RID: 20417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FC1")]
		[Address(RVA = "0x1DACE44", Offset = "0x1DACE44", VA = "0x7BBC5ACE44")]
		private void RefreshNetworkBg()
		{
		}

		// Token: 0x06004FC2 RID: 20418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FC2")]
		[Address(RVA = "0x1DAD638", Offset = "0x1DAD638", VA = "0x7BBC5AD638")]
		private void RefreshAwardList()
		{
		}

		// Token: 0x06004FC3 RID: 20419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FC3")]
		[Address(RVA = "0x1DAD8C8", Offset = "0x1DAD8C8", VA = "0x7BBC5AD8C8")]
		private void RefreshSignBtn()
		{
		}

		// Token: 0x06004FC4 RID: 20420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FC4")]
		[Address(RVA = "0x1DABEFC", Offset = "0x1DABEFC", VA = "0x7BBC5ABEFC")]
		private void RefreshTreasureBox()
		{
		}

		// Token: 0x06004FC5 RID: 20421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FC5")]
		[Address(RVA = "0x1DACC8C", Offset = "0x1DACC8C", VA = "0x7BBC5ACC8C")]
		private void InitAwardContainer()
		{
		}

		// Token: 0x06004FC6 RID: 20422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FC6")]
		[Address(RVA = "0x1DAE1A0", Offset = "0x1DAE1A0", VA = "0x7BBC5AE1A0")]
		private void DelayShowReward()
		{
		}

		// Token: 0x06004FC7 RID: 20423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FC7")]
		[Address(RVA = "0x1DAC344", Offset = "0x1DAC344", VA = "0x7BBC5AC344")]
		private void ShowBoxReward()
		{
		}

		// Token: 0x06004FC8 RID: 20424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FC8")]
		[Address(RVA = "0x1DABE84", Offset = "0x1DABE84", VA = "0x7BBC5ABE84")]
		private void SetSignBtnState(bool enable)
		{
		}

		// Token: 0x06004FC9 RID: 20425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FC9")]
		[Address(RVA = "0x1DAC5FC", Offset = "0x1DAC5FC", VA = "0x7BBC5AC5FC")]
		private void RefreshTokenView()
		{
		}

		// Token: 0x06004FCA RID: 20426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FCA")]
		[Address(RVA = "0x1DAE864", Offset = "0x1DAE864", VA = "0x7BBC5AE864")]
		private void OnRuleBtnClick()
		{
		}

		// Token: 0x06004FCB RID: 20427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FCB")]
		[Address(RVA = "0x1DAEA20", Offset = "0x1DAEA20", VA = "0x7BBC5AEA20")]
		private void OnSigninBtnClick()
		{
		}

		// Token: 0x06004FCC RID: 20428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FCC")]
		[Address(RVA = "0x1DAED94", Offset = "0x1DAED94", VA = "0x7BBC5AED94")]
		private void OnInterfaceMackClick()
		{
		}

		// Token: 0x06004FCD RID: 20429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FCD")]
		[Address(RVA = "0x1DAEE50", Offset = "0x1DAEE50", VA = "0x7BBC5AEE50")]
		private void OnTokenBtnClick()
		{
		}

		// Token: 0x06004FCE RID: 20430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FCE")]
		[Address(RVA = "0x1DABE30", Offset = "0x1DABE30", VA = "0x7BBC5ABE30")]
		private void Circle()
		{
		}

		// Token: 0x06004FCF RID: 20431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FCF")]
		[Address(RVA = "0x1DAE6E0", Offset = "0x1DAE6E0", VA = "0x7BBC5AE6E0")]
		private void Reset()
		{
		}

		// Token: 0x06004FD0 RID: 20432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FD0")]
		[Address(RVA = "0x1DAF090", Offset = "0x1DAF090", VA = "0x7BBC5AF090")]
		private void GenRewardIndexList()
		{
		}

		// Token: 0x06004FD1 RID: 20433 RVA: 0x00018438 File Offset: 0x00016638
		[Token(Token = "0x6004FD1")]
		[Address(RVA = "0x1DAF684", Offset = "0x1DAF684", VA = "0x7BBC5AF684")]
		private int FindIdx()
		{
			return 0;
		}

		// Token: 0x06004FD2 RID: 20434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FD2")]
		[Address(RVA = "0x1DAF1FC", Offset = "0x1DAF1FC", VA = "0x7BBC5AF1FC")]
		private void BuildFirstLapRateCurve()
		{
		}

		// Token: 0x06004FD3 RID: 20435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FD3")]
		[Address(RVA = "0x1DAD190", Offset = "0x1DAD190", VA = "0x7BBC5AD190")]
		private void EnableInterfaceMask(bool v)
		{
		}

		// Token: 0x06004FD4 RID: 20436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FD4")]
		[Address(RVA = "0x1DAF308", Offset = "0x1DAF308", VA = "0x7BBC5AF308")]
		private void DoCircle()
		{
		}

		// Token: 0x06004FD5 RID: 20437 RVA: 0x00018450 File Offset: 0x00016650
		[Token(Token = "0x6004FD5")]
		[Address(RVA = "0x1DAF7F8", Offset = "0x1DAF7F8", VA = "0x7BBC5AF7F8")]
		private UIFFWSTurntableSignInController.CircleStage GetCircleStage(int curIterationCounter)
		{
			return UIFFWSTurntableSignInController.CircleStage.NORMAL_RUNNING;
		}

		// Token: 0x06004FD6 RID: 20438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FD6")]
		[Address(RVA = "0x1DAF868", Offset = "0x1DAF868", VA = "0x7BBC5AF868")]
		private void SetOutstand(int idx, UIFFWSTurntableSignInItemController.ViewStage stage)
		{
		}

		// Token: 0x06004FD7 RID: 20439 RVA: 0x00018468 File Offset: 0x00016668
		[Token(Token = "0x6004FD7")]
		[Address(RVA = "0x1DAF980", Offset = "0x1DAF980", VA = "0x7BBC5AF980")]
		private float RateSample(int curIterationCounter)
		{
			return 0f;
		}

		// Token: 0x06004FD8 RID: 20440 RVA: 0x00018480 File Offset: 0x00016680
		[Token(Token = "0x6004FD8")]
		[Address(RVA = "0x1DAFB24", Offset = "0x1DAFB24", VA = "0x7BBC5AFB24")]
		private bool IsInFirstCircle(int curIdx)
		{
			return default(bool);
		}

		// Token: 0x06004FD9 RID: 20441 RVA: 0x00018498 File Offset: 0x00016698
		[Token(Token = "0x6004FD9")]
		[Address(RVA = "0x1DAFB48", Offset = "0x1DAFB48", VA = "0x7BBC5AFB48")]
		private float RateCelling(float rate)
		{
			return 0f;
		}

		// Token: 0x06004FDA RID: 20442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FDA")]
		[Address(RVA = "0x1DAFA5C", Offset = "0x1DAFA5C", VA = "0x7BBC5AFA5C")]
		private void ShowResultView()
		{
		}

		// Token: 0x06004FDB RID: 20443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FDB")]
		[Address(RVA = "0x1DAEDA4", Offset = "0x1DAEDA4", VA = "0x7BBC5AEDA4")]
		private void ShowDrawResult()
		{
		}

		// Token: 0x06004FDC RID: 20444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FDC")]
		[Address(RVA = "0x1DAFB58", Offset = "0x1DAFB58", VA = "0x7BBC5AFB58")]
		public UIFFWSTurntableSignInController()
		{
		}

		// Token: 0x06004FDD RID: 20445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FDD")]
		[Address(RVA = "0x1DAFC58", Offset = "0x1DAFC58", VA = "0x7BBC5AFC58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DF9C", Offset = "0x113DF9C")]
		private void <ShowResultView>b__53_0()
		{
		}

		// Token: 0x04007659 RID: 30297
		[Token(Token = "0x4007659")]
		private const float COUNTDOWN_ALPHA = 0.8f;

		// Token: 0x0400765A RID: 30298
		[Token(Token = "0x400765A")]
		[FieldOffset(Offset = "0xB8")]
		private UIFFWSTurntableSignInView m_View;

		// Token: 0x0400765B RID: 30299
		[Token(Token = "0x400765B")]
		[FieldOffset(Offset = "0xC0")]
		private UICountDownController m_CDControler;

		// Token: 0x0400765C RID: 30300
		[Token(Token = "0x400765C")]
		[FieldOffset(Offset = "0xC8")]
		private UIModelAnnoucementReward m_ModelAnnoucement;

		// Token: 0x0400765D RID: 30301
		[Token(Token = "0x400765D")]
		[FieldOffset(Offset = "0xD0")]
		private UIModelFFWS m_ModelFFWS;

		// Token: 0x0400765E RID: 30302
		[Token(Token = "0x400765E")]
		[FieldOffset(Offset = "0xD8")]
		private List<UIFFWSTurntableSignInItemController> m_AwardCtrlList;

		// Token: 0x0400765F RID: 30303
		[Token(Token = "0x400765F")]
		[FieldOffset(Offset = "0xE0")]
		private List<Transform> m_AwardContainerList;

		// Token: 0x04007660 RID: 30304
		[Token(Token = "0x4007660")]
		[FieldOffset(Offset = "0xE8")]
		private List<uint> m_SignIDList;

		// Token: 0x04007661 RID: 30305
		[Token(Token = "0x4007661")]
		[FieldOffset(Offset = "0xF0")]
		private UIFFWSTurntableSignInController.RewardIdx m_RewardIdxList;

		// Token: 0x04007662 RID: 30306
		[Token(Token = "0x4007662")]
		[FieldOffset(Offset = "0xF8")]
		private UIFFWSTurntableSignInController.RateCurve m_Curve;

		// Token: 0x04007663 RID: 30307
		[Token(Token = "0x4007663")]
		[FieldOffset(Offset = "0x100")]
		private int m_CurRewardIdx;

		// Token: 0x04007664 RID: 30308
		[Token(Token = "0x4007664")]
		[FieldOffset(Offset = "0x104")]
		private int m_IterationCounter;

		// Token: 0x04007665 RID: 30309
		[Token(Token = "0x4007665")]
		[FieldOffset(Offset = "0x108")]
		private uint m_CircleDC;

		// Token: 0x04007666 RID: 30310
		[Token(Token = "0x4007666")]
		private const int TURNTABLE_REWARD_CNT = 7;

		// Token: 0x04007667 RID: 30311
		[Token(Token = "0x4007667")]
		private const int FAKE_CIRCLE_CNT = 2;

		// Token: 0x04007668 RID: 30312
		[Token(Token = "0x4007668")]
		private const float FAST_ROUND_CD_SECOND = 0.05f;

		// Token: 0x0200136F RID: 4975
		[Token(Token = "0x200136F")]
		private class RewardIdx
		{
			// Token: 0x06004FDE RID: 20446 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004FDE")]
			[Address(RVA = "0x1DAF7F0", Offset = "0x1DAF7F0", VA = "0x7BBC5AF7F0")]
			public RewardIdx()
			{
			}

			// Token: 0x04007669 RID: 30313
			[Token(Token = "0x4007669")]
			[FieldOffset(Offset = "0x10")]
			public int idx;

			// Token: 0x0400766A RID: 30314
			[Token(Token = "0x400766A")]
			[FieldOffset(Offset = "0x14")]
			public int iterationIdx;
		}

		// Token: 0x02001370 RID: 4976
		[Token(Token = "0x2001370")]
		private class RateCurve
		{
			// Token: 0x06004FDF RID: 20447 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004FDF")]
			[Address(RVA = "0x1DAFC44", Offset = "0x1DAFC44", VA = "0x7BBC5AFC44")]
			public RateCurve()
			{
			}

			// Token: 0x0400766B RID: 30315
			[Token(Token = "0x400766B")]
			[FieldOffset(Offset = "0x10")]
			public float a;

			// Token: 0x0400766C RID: 30316
			[Token(Token = "0x400766C")]
			[FieldOffset(Offset = "0x14")]
			public int powers;

			// Token: 0x0400766D RID: 30317
			[Token(Token = "0x400766D")]
			[FieldOffset(Offset = "0x18")]
			public float endY;
		}

		// Token: 0x02001371 RID: 4977
		[Token(Token = "0x2001371")]
		private enum CircleStage
		{
			// Token: 0x0400766F RID: 30319
			[Token(Token = "0x400766F")]
			NORMAL_RUNNING,
			// Token: 0x04007670 RID: 30320
			[Token(Token = "0x4007670")]
			GET_REWARD,
			// Token: 0x04007671 RID: 30321
			[Token(Token = "0x4007671")]
			END
		}

		// Token: 0x02001372 RID: 4978
		[Token(Token = "0x2001372")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB550", Offset = "0x10EB550")]
		private sealed class <>c__DisplayClass22_0
		{
			// Token: 0x06004FE0 RID: 20448 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004FE0")]
			[Address(RVA = "0x1DAE6D8", Offset = "0x1DAE6D8", VA = "0x7BBC5AE6D8")]
			public <>c__DisplayClass22_0()
			{
			}

			// Token: 0x06004FE1 RID: 20449 RVA: 0x000184B0 File Offset: 0x000166B0
			[Token(Token = "0x6004FE1")]
			[Address(RVA = "0x1DAFC5C", Offset = "0x1DAFC5C", VA = "0x7BBC5AFC5C")]
			internal bool <DelayShowReward>b__0(AttendanceItem award)
			{
				return default(bool);
			}

			// Token: 0x04007672 RID: 30322
			[Token(Token = "0x4007672")]
			[FieldOffset(Offset = "0x10")]
			public uint signID;
		}
	}
}
