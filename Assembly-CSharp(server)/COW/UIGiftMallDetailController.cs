using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001572 RID: 5490
	[Token(Token = "0x2001572")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE944", Offset = "0x10EE944")]
	public class UIGiftMallDetailController : UIMallDetailBaseController, IEasyList
	{
		// Token: 0x06005F79 RID: 24441 RVA: 0x0001B9C0 File Offset: 0x00019BC0
		[Token(Token = "0x6005F79")]
		[Address(RVA = "0x2012A68", Offset = "0x2012A68", VA = "0x7BBC812A68")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005F7A RID: 24442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F7A")]
		[Address(RVA = "0x2012AB8", Offset = "0x2012AB8", VA = "0x7BBC812AB8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005F7B RID: 24443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F7B")]
		[Address(RVA = "0x20135BC", Offset = "0x20135BC", VA = "0x7BBC8135BC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005F7C RID: 24444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F7C")]
		[Address(RVA = "0x2013688", Offset = "0x2013688", VA = "0x7BBC813688", Slot = "50")]
		public override void HideItemEffect()
		{
		}

		// Token: 0x06005F7D RID: 24445 RVA: 0x0001B9D8 File Offset: 0x00019BD8
		[Token(Token = "0x6005F7D")]
		[Address(RVA = "0x20137BC", Offset = "0x20137BC", VA = "0x7BBC8137BC", Slot = "56")]
		protected override bool CanChangeCDNBG()
		{
			return default(bool);
		}

		// Token: 0x06005F7E RID: 24446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F7E")]
		[Address(RVA = "0x20131E0", Offset = "0x20131E0", VA = "0x7BBC8131E0")]
		private void InitMallTypeHandle()
		{
		}

		// Token: 0x06005F7F RID: 24447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F7F")]
		[Address(RVA = "0x20134F8", Offset = "0x20134F8", VA = "0x7BBC8134F8")]
		private void InitSpecialViewHandle()
		{
		}

		// Token: 0x06005F80 RID: 24448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F80")]
		[Address(RVA = "0x2013838", Offset = "0x2013838", VA = "0x7BBC813838")]
		private void OnGiftPanelClose(params object[] data)
		{
		}

		// Token: 0x06005F81 RID: 24449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F81")]
		[Address(RVA = "0x2014008", Offset = "0x2014008", VA = "0x7BBC814008")]
		private void OnGiftRankBtnClick()
		{
		}

		// Token: 0x06005F82 RID: 24450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F82")]
		[Address(RVA = "0x20143D4", Offset = "0x20143D4", VA = "0x7BBC8143D4")]
		private void OpenGiftLeaderBoardWnd()
		{
		}

		// Token: 0x06005F83 RID: 24451 RVA: 0x0001B9F0 File Offset: 0x00019BF0
		[Token(Token = "0x6005F83")]
		[Address(RVA = "0x201430C", Offset = "0x201430C", VA = "0x7BBC81430C")]
		private bool IsGiftLeaderBoardOver()
		{
			return default(bool);
		}

		// Token: 0x06005F84 RID: 24452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F84")]
		[Address(RVA = "0x2014474", Offset = "0x2014474", VA = "0x7BBC814474", Slot = "28")]
		protected override void InitBuyBtnStyle()
		{
		}

		// Token: 0x06005F85 RID: 24453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F85")]
		[Address(RVA = "0x20145EC", Offset = "0x20145EC", VA = "0x7BBC8145EC")]
		private void SendGift()
		{
		}

		// Token: 0x06005F86 RID: 24454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F86")]
		[Address(RVA = "0x2014958", Offset = "0x2014958", VA = "0x7BBC814958", Slot = "52")]
		protected override void OnSubToggleClick()
		{
		}

		// Token: 0x06005F87 RID: 24455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F87")]
		[Address(RVA = "0x20151C4", Offset = "0x20151C4", VA = "0x7BBC8151C4", Slot = "55")]
		public override void OnItemSelected(params object[] data)
		{
		}

		// Token: 0x06005F88 RID: 24456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F88")]
		[Address(RVA = "0x20152A0", Offset = "0x20152A0", VA = "0x7BBC8152A0")]
		private void RefreshItemView(uint commodityID)
		{
		}

		// Token: 0x06005F89 RID: 24457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F89")]
		[Address(RVA = "0x2013C30", Offset = "0x2013C30", VA = "0x7BBC813C30")]
		private void SetGiftRewardDesc(uint commodityID)
		{
		}

		// Token: 0x06005F8A RID: 24458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F8A")]
		[Address(RVA = "0x2015400", Offset = "0x2015400", VA = "0x7BBC815400")]
		private void SetMoneyBtnData(GiftItem giftItem)
		{
		}

		// Token: 0x06005F8B RID: 24459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F8B")]
		[Address(RVA = "0x20150CC", Offset = "0x20150CC", VA = "0x7BBC8150CC")]
		private void RefreshViewData(List<GiftItem> dataList, bool needResort = true)
		{
		}

		// Token: 0x06005F8C RID: 24460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F8C")]
		[Address(RVA = "0x2015410", Offset = "0x2015410", VA = "0x7BBC815410", Slot = "57")]
		public override void InitMallView()
		{
		}

		// Token: 0x06005F8D RID: 24461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F8D")]
		[Address(RVA = "0x20156A4", Offset = "0x20156A4", VA = "0x7BBC8156A4", Slot = "58")]
		public override void RefreshMallView()
		{
		}

		// Token: 0x06005F8E RID: 24462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F8E")]
		[Address(RVA = "0x20156CC", Offset = "0x20156CC", VA = "0x7BBC8156CC", Slot = "62")]
		public override void HighLightSelectedItem()
		{
		}

		// Token: 0x06005F8F RID: 24463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F8F")]
		[Address(RVA = "0x2015444", Offset = "0x2015444", VA = "0x7BBC815444")]
		private void UpdateTabs()
		{
		}

		// Token: 0x06005F90 RID: 24464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F90")]
		[Address(RVA = "0x20157A0", Offset = "0x20157A0", VA = "0x7BBC8157A0", Slot = "67")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06005F91 RID: 24465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F91")]
		[Address(RVA = "0x2015834", Offset = "0x2015834", VA = "0x7BBC815834", Slot = "68")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06005F92 RID: 24466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F92")]
		[Address(RVA = "0x2015864", Offset = "0x2015864", VA = "0x7BBC815864", Slot = "41")]
		protected override void OnCustomizeToggleSelected()
		{
		}

		// Token: 0x06005F93 RID: 24467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F93")]
		[Address(RVA = "0x2015908", Offset = "0x2015908", VA = "0x7BBC815908", Slot = "53")]
		protected override void ResetUIStateOnToggleSelected()
		{
		}

		// Token: 0x06005F94 RID: 24468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F94")]
		[Address(RVA = "0x2015A90", Offset = "0x2015A90", VA = "0x7BBC815A90", Slot = "60")]
		public override void NavigationToItem(uint mallTabType, uint mallSubType, uint storeID)
		{
		}

		// Token: 0x06005F95 RID: 24469 RVA: 0x0001BA08 File Offset: 0x00019C08
		[Token(Token = "0x6005F95")]
		[Address(RVA = "0x2016088", Offset = "0x2016088", VA = "0x7BBC816088", Slot = "35")]
		public override bool OverwriteBackButtonLogic()
		{
			return default(bool);
		}

		// Token: 0x06005F96 RID: 24470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F96")]
		[Address(RVA = "0x2016134", Offset = "0x2016134", VA = "0x7BBC816134")]
		private void OnAllClothToggleClick()
		{
		}

		// Token: 0x06005F97 RID: 24471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F97")]
		[Address(RVA = "0x2016308", Offset = "0x2016308", VA = "0x7BBC816308")]
		private void OnCommomClothToggleClick()
		{
		}

		// Token: 0x06005F98 RID: 24472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F98")]
		[Address(RVA = "0x2016524", Offset = "0x2016524", VA = "0x7BBC816524")]
		private void OnMaleClothToggleClick()
		{
		}

		// Token: 0x06005F99 RID: 24473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F99")]
		[Address(RVA = "0x2016654", Offset = "0x2016654", VA = "0x7BBC816654")]
		private void OnFemaleClothToggleClick()
		{
		}

		// Token: 0x06005F9A RID: 24474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F9A")]
		[Address(RVA = "0x2016438", Offset = "0x2016438", VA = "0x7BBC816438")]
		private void RefreshClothViewByGender(EClothGenderType genderType)
		{
		}

		// Token: 0x06005F9B RID: 24475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F9B")]
		[Address(RVA = "0x2016784", Offset = "0x2016784", VA = "0x7BBC816784")]
		private List<GiftItem> GenderSelectionList(EClothGenderType genderType)
		{
			return null;
		}

		// Token: 0x06005F9C RID: 24476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F9C")]
		[Address(RVA = "0x20168D0", Offset = "0x20168D0", VA = "0x7BBC8168D0", Slot = "49")]
		protected override void RefreshCurrentTabView(UINavigationUtil.UINavigationMallTabType mallTabType)
		{
		}

		// Token: 0x06005F9D RID: 24477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F9D")]
		[Address(RVA = "0x20169FC", Offset = "0x20169FC", VA = "0x7BBC8169FC", Slot = "61")]
		public override void RefreshCurrentMallView(bool clickItem)
		{
		}

		// Token: 0x06005F9E RID: 24478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F9E")]
		[Address(RVA = "0x2016A58", Offset = "0x2016A58", VA = "0x7BBC816A58", Slot = "34")]
		public override void ResetCurrentMall()
		{
		}

		// Token: 0x06005F9F RID: 24479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F9F")]
		[Address(RVA = "0x2016B0C", Offset = "0x2016B0C", VA = "0x7BBC816B0C", Slot = "33")]
		public override void HighlightCurrent()
		{
		}

		// Token: 0x06005FA0 RID: 24480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FA0")]
		[Address(RVA = "0x2016C8C", Offset = "0x2016C8C", VA = "0x7BBC816C8C")]
		public UIGiftMallDetailController()
		{
		}

		// Token: 0x06005FA1 RID: 24481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FA1")]
		[Address(RVA = "0x2016D1C", Offset = "0x2016D1C", VA = "0x7BBC816D1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113FC50", Offset = "0x113FC50")]
		private void <OnUIInit>b__5_0()
		{
		}

		// Token: 0x06005FA2 RID: 24482 RVA: 0x0001BA20 File Offset: 0x00019C20
		[Token(Token = "0x6005FA2")]
		[Address(RVA = "0x2016E18", Offset = "0x2016E18", VA = "0x7BBC816E18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113FC60", Offset = "0x113FC60")]
		private bool <HighlightCurrent>b__42_0(GiftItem item)
		{
			return default(bool);
		}

		// Token: 0x06005FA3 RID: 24483 RVA: 0x0001BA38 File Offset: 0x00019C38
		[Token(Token = "0x6005FA3")]
		[Address(RVA = "0x2016E54", Offset = "0x2016E54", VA = "0x7BBC816E54")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113FC70", Offset = "0x113FC70")]
		private bool <HighlightCurrent>b__42_1(GiftItem item)
		{
			return default(bool);
		}

		// Token: 0x0400801D RID: 32797
		[Token(Token = "0x400801D")]
		[FieldOffset(Offset = "0x148")]
		public UIMallGiftController m_GiftCtrl;

		// Token: 0x0400801E RID: 32798
		[Token(Token = "0x400801E")]
		[FieldOffset(Offset = "0x150")]
		private List<GiftItem> m_CurrentDataList;

		// Token: 0x0400801F RID: 32799
		[Token(Token = "0x400801F")]
		private const uint COINDIAMONDRATIO = 50U;

		// Token: 0x04008020 RID: 32800
		[Token(Token = "0x4008020")]
		private const string GIFTRANKLASTCRECORDRANKID = "MALL_GIFTRANK_RANKID";

		// Token: 0x02001573 RID: 5491
		[Token(Token = "0x2001573")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EE97C", Offset = "0x10EE97C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005FA5 RID: 24485 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005FA5")]
			[Address(RVA = "0x1A6CED0", Offset = "0x1A6CED0", VA = "0x7BBC26CED0")]
			public <>c()
			{
			}

			// Token: 0x06005FA6 RID: 24486 RVA: 0x0001BA50 File Offset: 0x00019C50
			[Token(Token = "0x6005FA6")]
			[Address(RVA = "0x1A6CED8", Offset = "0x1A6CED8", VA = "0x7BBC26CED8")]
			internal bool <OnSubToggleClick>b__17_0(SubTabInfo temp)
			{
				return default(bool);
			}

			// Token: 0x06005FA7 RID: 24487 RVA: 0x0001BA68 File Offset: 0x00019C68
			[Token(Token = "0x6005FA7")]
			[Address(RVA = "0x1A6CF18", Offset = "0x1A6CF18", VA = "0x7BBC26CF18")]
			internal uint <UpdateTabs>b__26_0(UINavigationUtil.UINavigationMallTabType type)
			{
				return 0U;
			}

			// Token: 0x04008021 RID: 32801
			[Token(Token = "0x4008021")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIGiftMallDetailController.<>c <>9;

			// Token: 0x04008022 RID: 32802
			[Token(Token = "0x4008022")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<SubTabInfo> <>9__17_0;

			// Token: 0x04008023 RID: 32803
			[Token(Token = "0x4008023")]
			[FieldOffset(Offset = "0x10")]
			public static Converter<UINavigationUtil.UINavigationMallTabType, uint> <>9__26_0;
		}

		// Token: 0x02001574 RID: 5492
		[Token(Token = "0x2001574")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EE98C", Offset = "0x10EE98C")]
		private sealed class <>c__DisplayClass31_0
		{
			// Token: 0x06005FA8 RID: 24488 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005FA8")]
			[Address(RVA = "0x1A6CF20", Offset = "0x1A6CF20", VA = "0x7BBC26CF20")]
			public <>c__DisplayClass31_0()
			{
			}

			// Token: 0x06005FA9 RID: 24489 RVA: 0x0001BA80 File Offset: 0x00019C80
			[Token(Token = "0x6005FA9")]
			[Address(RVA = "0x1A6CF28", Offset = "0x1A6CF28", VA = "0x7BBC26CF28")]
			internal bool <NavigationToItem>b__0(SubTabInfo temp)
			{
				return default(bool);
			}

			// Token: 0x06005FAA RID: 24490 RVA: 0x0001BA98 File Offset: 0x00019C98
			[Token(Token = "0x6005FAA")]
			[Address(RVA = "0x1A6CF64", Offset = "0x1A6CF64", VA = "0x7BBC26CF64")]
			internal bool <NavigationToItem>b__1(GiftItem item)
			{
				return default(bool);
			}

			// Token: 0x06005FAB RID: 24491 RVA: 0x0001BAB0 File Offset: 0x00019CB0
			[Token(Token = "0x6005FAB")]
			[Address(RVA = "0x1A6CFA0", Offset = "0x1A6CFA0", VA = "0x7BBC26CFA0")]
			internal bool <NavigationToItem>b__2(GiftItem item)
			{
				return default(bool);
			}

			// Token: 0x04008024 RID: 32804
			[Token(Token = "0x4008024")]
			[FieldOffset(Offset = "0x10")]
			public uint mallSubType;

			// Token: 0x04008025 RID: 32805
			[Token(Token = "0x4008025")]
			[FieldOffset(Offset = "0x14")]
			public uint storeID;
		}

		// Token: 0x02001575 RID: 5493
		[Token(Token = "0x2001575")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EE99C", Offset = "0x10EE99C")]
		private sealed class <>c__DisplayClass38_0
		{
			// Token: 0x06005FAC RID: 24492 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005FAC")]
			[Address(RVA = "0x1A6CFDC", Offset = "0x1A6CFDC", VA = "0x7BBC26CFDC")]
			public <>c__DisplayClass38_0()
			{
			}

			// Token: 0x06005FAD RID: 24493 RVA: 0x0001BAC8 File Offset: 0x00019CC8
			[Token(Token = "0x6005FAD")]
			[Address(RVA = "0x1A6CFE4", Offset = "0x1A6CFE4", VA = "0x7BBC26CFE4")]
			internal bool <GenderSelectionList>b__0(GiftItem giftItem)
			{
				return default(bool);
			}

			// Token: 0x04008026 RID: 32806
			[Token(Token = "0x4008026")]
			[FieldOffset(Offset = "0x10")]
			public UIGiftMallDetailController <>4__this;

			// Token: 0x04008027 RID: 32807
			[Token(Token = "0x4008027")]
			[FieldOffset(Offset = "0x18")]
			public EClothGenderType genderType;
		}
	}
}
