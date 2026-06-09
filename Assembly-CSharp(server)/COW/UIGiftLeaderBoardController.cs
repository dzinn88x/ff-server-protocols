using System;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x0200156B RID: 5483
	[Token(Token = "0x200156B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE88C", Offset = "0x10EE88C")]
	public class UIGiftLeaderBoardController : UIPopupWindowController, IEasyList, IUIModelDataChangeObserver
	{
		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06005F50 RID: 24400 RVA: 0x0001B930 File Offset: 0x00019B30
		[Token(Token = "0x170008B7")]
		public EStore.GiftRankType LeaderBoardType
		{
			[Token(Token = "0x6005F50")]
			[Address(RVA = "0x200E32C", Offset = "0x200E32C", VA = "0x7BBC80E32C")]
			get
			{
				return EStore.GiftRankType.GiftRankType_NONE;
			}
		}

		// Token: 0x06005F51 RID: 24401 RVA: 0x0001B948 File Offset: 0x00019B48
		[Token(Token = "0x6005F51")]
		[Address(RVA = "0x200E334", Offset = "0x200E334", VA = "0x7BBC80E334")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005F52 RID: 24402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F52")]
		[Address(RVA = "0x200E384", Offset = "0x200E384", VA = "0x7BBC80E384", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005F53 RID: 24403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F53")]
		[Address(RVA = "0x200E704", Offset = "0x200E704", VA = "0x7BBC80E704")]
		private void OnGetGiftLeaderBoardReward(params object[] data)
		{
		}

		// Token: 0x06005F54 RID: 24404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F54")]
		[Address(RVA = "0x200E874", Offset = "0x200E874", VA = "0x7BBC80E874")]
		private void OnReceiverToggleClick()
		{
		}

		// Token: 0x06005F55 RID: 24405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F55")]
		[Address(RVA = "0x200F154", Offset = "0x200F154", VA = "0x7BBC80F154")]
		private void OnGiverToggleClick()
		{
		}

		// Token: 0x06005F56 RID: 24406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F56")]
		[Address(RVA = "0x200F180", Offset = "0x200F180", VA = "0x7BBC80F180")]
		private void OnCloseBtnClick()
		{
		}

		// Token: 0x06005F57 RID: 24407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F57")]
		[Address(RVA = "0x200F188", Offset = "0x200F188", VA = "0x7BBC80F188", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005F58 RID: 24408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F58")]
		[Address(RVA = "0x200F294", Offset = "0x200F294", VA = "0x7BBC80F294")]
		private void RefreshLeaderBoardView(int propID)
		{
		}

		// Token: 0x06005F59 RID: 24409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F59")]
		[Address(RVA = "0x200F35C", Offset = "0x200F35C", VA = "0x7BBC80F35C")]
		private void SetSelfInfo(int propID)
		{
		}

		// Token: 0x06005F5A RID: 24410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F5A")]
		[Address(RVA = "0x200E8A0", Offset = "0x200E8A0", VA = "0x7BBC80E8A0")]
		private void RefreshRankInfoView()
		{
		}

		// Token: 0x06005F5B RID: 24411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F5B")]
		[Address(RVA = "0x200EF38", Offset = "0x200EF38", VA = "0x7BBC80EF38")]
		private void RefreshRewardsListView()
		{
		}

		// Token: 0x06005F5C RID: 24412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F5C")]
		[Address(RVA = "0x200F778", Offset = "0x200F778", VA = "0x7BBC80F778", Slot = "42")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005F5D RID: 24413 RVA: 0x0001B960 File Offset: 0x00019B60
		[Token(Token = "0x6005F5D")]
		[Address(RVA = "0x200F910", Offset = "0x200F910", VA = "0x7BBC80F910", Slot = "43")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06005F5E RID: 24414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F5E")]
		[Address(RVA = "0x200F978", Offset = "0x200F978", VA = "0x7BBC80F978", Slot = "40")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06005F5F RID: 24415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F5F")]
		[Address(RVA = "0x200FAEC", Offset = "0x200FAEC", VA = "0x7BBC80FAEC", Slot = "41")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06005F60 RID: 24416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F60")]
		[Address(RVA = "0x200FB1C", Offset = "0x200FB1C", VA = "0x7BBC80FB1C")]
		public UIGiftLeaderBoardController()
		{
		}

		// Token: 0x06005F61 RID: 24417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F61")]
		[Address(RVA = "0x200FB2C", Offset = "0x200FB2C", VA = "0x7BBC80FB2C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113FC40", Offset = "0x113FC40")]
		private void <RefreshRankInfoView>b__19_0()
		{
		}

		// Token: 0x04007FF4 RID: 32756
		[Token(Token = "0x4007FF4")]
		[FieldOffset(Offset = "0x98")]
		private UIGiftLeaderBoardView m_View;

		// Token: 0x04007FF5 RID: 32757
		[Token(Token = "0x4007FF5")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelLeaderBoard m_ModelLeaderBoard;

		// Token: 0x04007FF6 RID: 32758
		[Token(Token = "0x4007FF6")]
		[FieldOffset(Offset = "0xA8")]
		private UIModelInventory m_ModelInventory;

		// Token: 0x04007FF7 RID: 32759
		[Token(Token = "0x4007FF7")]
		[FieldOffset(Offset = "0xB0")]
		private UIModelGift m_ModelGift;

		// Token: 0x04007FF8 RID: 32760
		[Token(Token = "0x4007FF8")]
		[FieldOffset(Offset = "0xB8")]
		private EStore.GiftRankType m_LeaderBoardType;

		// Token: 0x04007FF9 RID: 32761
		[Token(Token = "0x4007FF9")]
		[FieldOffset(Offset = "0xC0")]
		private UIGiftLeaderBoardItemController m_SelfRankUI;

		// Token: 0x04007FFA RID: 32762
		[Token(Token = "0x4007FFA")]
		[FieldOffset(Offset = "0xC8")]
		private uint m_NextRewardCount;

		// Token: 0x04007FFB RID: 32763
		[Token(Token = "0x4007FFB")]
		[FieldOffset(Offset = "0xCC")]
		private int m_RewardListCount;

		// Token: 0x0200156C RID: 5484
		[Token(Token = "0x200156C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EE8C4", Offset = "0x10EE8C4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005F63 RID: 24419 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005F63")]
			[Address(RVA = "0x200FC8C", Offset = "0x200FC8C", VA = "0x7BBC80FC8C")]
			public <>c()
			{
			}

			// Token: 0x06005F64 RID: 24420 RVA: 0x0001B978 File Offset: 0x00019B78
			[Token(Token = "0x6005F64")]
			[Address(RVA = "0x200FC94", Offset = "0x200FC94", VA = "0x7BBC80FC94")]
			internal int <RefreshRewardsListView>b__20_0(GiftRewardDesc a, GiftRewardDesc b)
			{
				return 0;
			}

			// Token: 0x04007FFC RID: 32764
			[Token(Token = "0x4007FFC")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIGiftLeaderBoardController.<>c <>9;

			// Token: 0x04007FFD RID: 32765
			[Token(Token = "0x4007FFD")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<GiftRewardDesc> <>9__20_0;
		}
	}
}
