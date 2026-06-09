using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200172C RID: 5932
	[Token(Token = "0x200172C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F1A2C", Offset = "0x10F1A2C")]
	public class UIClanSearchController : UINavigationController, IUIModelDataChangeObserver, IEasyList
	{
		// Token: 0x06006EDB RID: 28379 RVA: 0x0001F2F0 File Offset: 0x0001D4F0
		[Token(Token = "0x6006EDB")]
		[Address(RVA = "0x1CFF8D4", Offset = "0x1CFF8D4", VA = "0x7BBC4FF8D4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006EDC RID: 28380 RVA: 0x0001F308 File Offset: 0x0001D508
		[Token(Token = "0x6006EDC")]
		[Address(RVA = "0x1CFF924", Offset = "0x1CFF924", VA = "0x7BBC4FF924", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x06006EDD RID: 28381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EDD")]
		[Address(RVA = "0x1CFF92C", Offset = "0x1CFF92C", VA = "0x7BBC4FF92C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006EDE RID: 28382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EDE")]
		[Address(RVA = "0x1D004A0", Offset = "0x1D004A0", VA = "0x7BBC5004A0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006EDF RID: 28383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EDF")]
		[Address(RVA = "0x1D005AC", Offset = "0x1D005AC", VA = "0x7BBC5005AC")]
		private void OnClickSwitchLeft()
		{
		}

		// Token: 0x06006EE0 RID: 28384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EE0")]
		[Address(RVA = "0x1D005C4", Offset = "0x1D005C4", VA = "0x7BBC5005C4")]
		private void OnClickSwitchRight()
		{
		}

		// Token: 0x06006EE1 RID: 28385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EE1")]
		[Address(RVA = "0x1D001B8", Offset = "0x1D001B8", VA = "0x7BBC5001B8")]
		private void OnChangeLabelType()
		{
		}

		// Token: 0x06006EE2 RID: 28386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EE2")]
		[Address(RVA = "0x1D0062C", Offset = "0x1D0062C", VA = "0x7BBC50062C")]
		private void OnClickFilter()
		{
		}

		// Token: 0x06006EE3 RID: 28387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EE3")]
		[Address(RVA = "0x1D008E4", Offset = "0x1D008E4", VA = "0x7BBC5008E4")]
		private void OnChoose(List<string> contents)
		{
		}

		// Token: 0x06006EE4 RID: 28388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EE4")]
		[Address(RVA = "0x1CFFFA4", Offset = "0x1CFFFA4", VA = "0x7BBC4FFFA4")]
		private void FilterCountDown()
		{
		}

		// Token: 0x06006EE5 RID: 28389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EE5")]
		[Address(RVA = "0x1CFFEB8", Offset = "0x1CFFEB8", VA = "0x7BBC4FFEB8")]
		private void InFilterCDTime(bool isInTime)
		{
		}

		// Token: 0x06006EE6 RID: 28390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EE6")]
		[Address(RVA = "0x1D00B78", Offset = "0x1D00B78", VA = "0x7BBC500B78")]
		private void OnFilterClanList(string[] contents)
		{
		}

		// Token: 0x06006EE7 RID: 28391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EE7")]
		[Address(RVA = "0x1D00E88", Offset = "0x1D00E88", VA = "0x7BBC500E88", Slot = "39")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06006EE8 RID: 28392 RVA: 0x0001F320 File Offset: 0x0001D520
		[Token(Token = "0x6006EE8")]
		[Address(RVA = "0x1D012D8", Offset = "0x1D012D8", VA = "0x7BBC5012D8", Slot = "40")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06006EE9 RID: 28393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EE9")]
		private void RefreshClanList<DataType>(List<DataType> clanList)
		{
		}

		// Token: 0x06006EEA RID: 28394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EEA")]
		[Address(RVA = "0x1D010D8", Offset = "0x1D010D8", VA = "0x7BBC5010D8")]
		private void ShowApplyReply()
		{
		}

		// Token: 0x06006EEB RID: 28395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EEB")]
		[Address(RVA = "0x1D01320", Offset = "0x1D01320", VA = "0x7BBC501320")]
		private void OnBtnClanCreated()
		{
		}

		// Token: 0x06006EEC RID: 28396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EEC")]
		[Address(RVA = "0x1D01560", Offset = "0x1D01560", VA = "0x7BBC501560")]
		private void OnBtnClanRefresh()
		{
		}

		// Token: 0x06006EED RID: 28397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EED")]
		[Address(RVA = "0x1D0184C", Offset = "0x1D0184C", VA = "0x7BBC50184C")]
		private void OnCountDownStarted()
		{
		}

		// Token: 0x06006EEE RID: 28398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EEE")]
		[Address(RVA = "0x1D01894", Offset = "0x1D01894", VA = "0x7BBC501894")]
		private void OnCountDownFinished()
		{
		}

		// Token: 0x06006EEF RID: 28399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EEF")]
		[Address(RVA = "0x1D019C4", Offset = "0x1D019C4", VA = "0x7BBC5019C4")]
		private void OnBtnClanSearch()
		{
		}

		// Token: 0x06006EF0 RID: 28400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EF0")]
		[Address(RVA = "0x1D01CB8", Offset = "0x1D01CB8", VA = "0x7BBC501CB8")]
		public void SearchClanById(string clanId)
		{
		}

		// Token: 0x06006EF1 RID: 28401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EF1")]
		[Address(RVA = "0x1D01D14", Offset = "0x1D01D14", VA = "0x7BBC501D14")]
		private void OnInputChanged()
		{
		}

		// Token: 0x06006EF2 RID: 28402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EF2")]
		[Address(RVA = "0x1D01DC4", Offset = "0x1D01DC4", VA = "0x7BBC501DC4")]
		private void OnBtnInputClear()
		{
		}

		// Token: 0x06006EF3 RID: 28403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EF3")]
		[Address(RVA = "0x1D01E38", Offset = "0x1D01E38", VA = "0x7BBC501E38", Slot = "41")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06006EF4 RID: 28404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EF4")]
		[Address(RVA = "0x1D01F00", Offset = "0x1D01F00", VA = "0x7BBC501F00", Slot = "42")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06006EF5 RID: 28405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EF5")]
		[Address(RVA = "0x1D02028", Offset = "0x1D02028", VA = "0x7BBC502028")]
		public UIClanSearchController()
		{
		}

		// Token: 0x0400893E RID: 35134
		[Token(Token = "0x400893E")]
		[FieldOffset(Offset = "0xB0")]
		private UIClanSearchView m_View;

		// Token: 0x0400893F RID: 35135
		[Token(Token = "0x400893F")]
		private const int COOLDOWN_SECONDS = 30;

		// Token: 0x04008940 RID: 35136
		[Token(Token = "0x4008940")]
		[FieldOffset(Offset = "0xB8")]
		private CountDownConfig config;

		// Token: 0x04008941 RID: 35137
		[Token(Token = "0x4008941")]
		[FieldOffset(Offset = "0xC0")]
		private int CLAN_ID_LENGTH_MIN;

		// Token: 0x04008942 RID: 35138
		[Token(Token = "0x4008942")]
		[FieldOffset(Offset = "0xC4")]
		private int CLNA_APPLY_TIME_LIMIT;

		// Token: 0x04008943 RID: 35139
		[Token(Token = "0x4008943")]
		private const int FILTER_COUNTDOWN_SECONDS = 30;

		// Token: 0x04008944 RID: 35140
		[Token(Token = "0x4008944")]
		[FieldOffset(Offset = "0xC8")]
		private uint m_FilterCallID;

		// Token: 0x04008945 RID: 35141
		[Token(Token = "0x4008945")]
		[FieldOffset(Offset = "0xD0")]
		private string[] m_FilterIDs;

		// Token: 0x04008946 RID: 35142
		[Token(Token = "0x4008946")]
		[FieldOffset(Offset = "0xD8")]
		private string[] m_SloganLabels;

		// Token: 0x04008947 RID: 35143
		[Token(Token = "0x4008947")]
		[FieldOffset(Offset = "0xE0")]
		private int m_CurSloganIndex;

		// Token: 0x04008948 RID: 35144
		[Token(Token = "0x4008948")]
		[FieldOffset(Offset = "0xE8")]
		private List<UIClanListItemController> m_Items;

		// Token: 0x0200172D RID: 5933
		[Token(Token = "0x200172D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F1A64", Offset = "0x10F1A64")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006EF7 RID: 28407 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006EF7")]
			[Address(RVA = "0x1D02248", Offset = "0x1D02248", VA = "0x7BBC502248")]
			public <>c()
			{
			}

			// Token: 0x06006EF8 RID: 28408 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006EF8")]
			[Address(RVA = "0x1D02250", Offset = "0x1D02250", VA = "0x7BBC502250")]
			internal void <OnBtnClanCreated>b__27_0()
			{
			}

			// Token: 0x04008949 RID: 35145
			[Token(Token = "0x4008949")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIClanSearchController.<>c <>9;

			// Token: 0x0400894A RID: 35146
			[Token(Token = "0x400894A")]
			[FieldOffset(Offset = "0x8")]
			public static EventDelegate.Callback <>9__27_0;
		}
	}
}
