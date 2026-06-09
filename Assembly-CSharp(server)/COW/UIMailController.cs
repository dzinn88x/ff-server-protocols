using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001A2F RID: 6703
	[Token(Token = "0x2001A2F")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F7B24", Offset = "0x10F7B24")]
	internal class UIMailController : UINavigationController, IUIModelDataChangeObserver, IEasyList
	{
		// Token: 0x06008CA6 RID: 36006 RVA: 0x00025848 File Offset: 0x00023A48
		[Token(Token = "0x6008CA6")]
		[Address(RVA = "0x1CDE394", Offset = "0x1CDE394", VA = "0x7BBC4DE394")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008CA7 RID: 36007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CA7")]
		[Address(RVA = "0x1CDE3E4", Offset = "0x1CDE3E4", VA = "0x7BBC4DE3E4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008CA8 RID: 36008 RVA: 0x00025860 File Offset: 0x00023A60
		[Token(Token = "0x6008CA8")]
		[Address(RVA = "0x1CDECC4", Offset = "0x1CDECC4", VA = "0x7BBC4DECC4", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x06008CA9 RID: 36009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CA9")]
		[Address(RVA = "0x1CDECCC", Offset = "0x1CDECCC", VA = "0x7BBC4DECCC")]
		private void OnReceiveAllBtnClick()
		{
		}

		// Token: 0x06008CAA RID: 36010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CAA")]
		[Address(RVA = "0x1CDF268", Offset = "0x1CDF268", VA = "0x7BBC4DF268")]
		private void OnDeleteAllBtnClick()
		{
		}

		// Token: 0x06008CAB RID: 36011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CAB")]
		[Address(RVA = "0x1CDF548", Offset = "0x1CDF548", VA = "0x7BBC4DF548")]
		private void OnRejectBtnClick()
		{
		}

		// Token: 0x06008CAC RID: 36012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CAC")]
		[Address(RVA = "0x1CDF74C", Offset = "0x1CDF74C", VA = "0x7BBC4DF74C")]
		public void SelectMail(uint type)
		{
		}

		// Token: 0x06008CAD RID: 36013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CAD")]
		[Address(RVA = "0x1CDF88C", Offset = "0x1CDF88C", VA = "0x7BBC4DF88C")]
		private void OnAcceptBtnClick()
		{
		}

		// Token: 0x06008CAE RID: 36014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CAE")]
		[Address(RVA = "0x1CDF990", Offset = "0x1CDF990", VA = "0x7BBC4DF990")]
		private void OnReceiveBtnClick()
		{
		}

		// Token: 0x06008CAF RID: 36015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CAF")]
		[Address(RVA = "0x1CDF9E8", Offset = "0x1CDF9E8", VA = "0x7BBC4DF9E8")]
		private void OnOpenBtnClick()
		{
		}

		// Token: 0x06008CB0 RID: 36016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CB0")]
		[Address(RVA = "0x1CDFA34", Offset = "0x1CDFA34", VA = "0x7BBC4DFA34")]
		public void ShowGetGiftPanel(MailInfo mailInfo)
		{
		}

		// Token: 0x06008CB1 RID: 36017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CB1")]
		[Address(RVA = "0x1CDFC94", Offset = "0x1CDFC94", VA = "0x7BBC4DFC94")]
		private void OnDeleteBtnClick()
		{
		}

		// Token: 0x06008CB2 RID: 36018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CB2")]
		[Address(RVA = "0x1CDF658", Offset = "0x1CDF658", VA = "0x7BBC4DF658")]
		public void SetMailStatus(EMail.Status status)
		{
		}

		// Token: 0x06008CB3 RID: 36019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CB3")]
		[Address(RVA = "0x1CDEB28", Offset = "0x1CDEB28", VA = "0x7BBC4DEB28")]
		private void SetMailContentBtnStatus(bool del = true, bool rec = false, bool acc = false, bool rej = false, bool open = false)
		{
		}

		// Token: 0x06008CB4 RID: 36020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CB4")]
		[Address(RVA = "0x1CDFCEC", Offset = "0x1CDFCEC", VA = "0x7BBC4DFCEC")]
		private void UpdateMailView(object[] data)
		{
		}

		// Token: 0x06008CB5 RID: 36021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CB5")]
		[Address(RVA = "0x1CE1E90", Offset = "0x1CE1E90", VA = "0x7BBC4E1E90")]
		private void SetButtonStateByMailType()
		{
		}

		// Token: 0x06008CB6 RID: 36022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CB6")]
		[Address(RVA = "0x1CE1BF0", Offset = "0x1CE1BF0", VA = "0x7BBC4E1BF0")]
		private void RefreshBatchOperationBtns()
		{
		}

		// Token: 0x06008CB7 RID: 36023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CB7")]
		[Address(RVA = "0x1CE16E4", Offset = "0x1CE16E4", VA = "0x7BBC4E16E4")]
		private void RefreshRewardData()
		{
		}

		// Token: 0x06008CB8 RID: 36024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CB8")]
		[Address(RVA = "0x1CE20D8", Offset = "0x1CE20D8", VA = "0x7BBC4E20D8")]
		private void SetMailGrid(UIGrid grid)
		{
		}

		// Token: 0x06008CB9 RID: 36025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CB9")]
		[Address(RVA = "0x1CE2598", Offset = "0x1CE2598", VA = "0x7BBC4E2598", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008CBA RID: 36026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CBA")]
		[Address(RVA = "0x1CE2768", Offset = "0x1CE2768", VA = "0x7BBC4E2768", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06008CBB RID: 36027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CBB")]
		[Address(RVA = "0x1CE27A8", Offset = "0x1CE27A8", VA = "0x7BBC4E27A8", Slot = "39")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06008CBC RID: 36028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CBC")]
		[Address(RVA = "0x1CE3130", Offset = "0x1CE3130", VA = "0x7BBC4E3130")]
		private void CheckIfPopupRewards(object[] objects)
		{
		}

		// Token: 0x06008CBD RID: 36029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CBD")]
		[Address(RVA = "0x1CE2DAC", Offset = "0x1CE2DAC", VA = "0x7BBC4E2DAC")]
		private void GetMailRefreshUIData()
		{
		}

		// Token: 0x06008CBE RID: 36030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008CBE")]
		[Address(RVA = "0x1CE3B0C", Offset = "0x1CE3B0C", VA = "0x7BBC4E3B0C")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1144378", Offset = "0x1144378")]
		private IEnumerator CoResetScrollView()
		{
			return null;
		}

		// Token: 0x06008CBF RID: 36031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008CBF")]
		[Address(RVA = "0x1CE3BAC", Offset = "0x1CE3BAC", VA = "0x7BBC4E3BAC")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x11443DC", Offset = "0x11443DC")]
		private IEnumerator CoReposRewardScroll()
		{
			return null;
		}

		// Token: 0x06008CC0 RID: 36032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CC0")]
		[Address(RVA = "0x1CE32B4", Offset = "0x1CE32B4", VA = "0x7BBC4E32B4")]
		private void ReadMailRefreshUIData(object[] objects)
		{
		}

		// Token: 0x06008CC1 RID: 36033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CC1")]
		[Address(RVA = "0x1CE3C4C", Offset = "0x1CE3C4C", VA = "0x7BBC4E3C4C")]
		private void SelectMailItem(int index)
		{
		}

		// Token: 0x06008CC2 RID: 36034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CC2")]
		[Address(RVA = "0x1CE3988", Offset = "0x1CE3988", VA = "0x7BBC4E3988")]
		private void RefreshMailUI(bool show)
		{
		}

		// Token: 0x06008CC3 RID: 36035 RVA: 0x00025878 File Offset: 0x00023A78
		[Token(Token = "0x6008CC3")]
		[Address(RVA = "0x1CE3D38", Offset = "0x1CE3D38", VA = "0x7BBC4E3D38", Slot = "40")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06008CC4 RID: 36036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008CC4")]
		[Address(RVA = "0x1CE3D94", Offset = "0x1CE3D94", VA = "0x7BBC4E3D94", Slot = "41")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06008CC5 RID: 36037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CC5")]
		[Address(RVA = "0x1CE3E28", Offset = "0x1CE3E28", VA = "0x7BBC4E3E28", Slot = "42")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06008CC6 RID: 36038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CC6")]
		[Address(RVA = "0x1CE373C", Offset = "0x1CE373C", VA = "0x7BBC4E373C")]
		private void SendLog()
		{
		}

		// Token: 0x06008CC7 RID: 36039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CC7")]
		[Address(RVA = "0x1CDEF10", Offset = "0x1CDEF10", VA = "0x7BBC4DEF10")]
		private void ShowGiftMail(object[] data)
		{
		}

		// Token: 0x06008CC8 RID: 36040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CC8")]
		[Address(RVA = "0x1CE1D94", Offset = "0x1CE1D94", VA = "0x7BBC4E1D94")]
		private void SetMailContentText(string text)
		{
		}

		// Token: 0x06008CC9 RID: 36041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CC9")]
		[Address(RVA = "0x1CE1DE8", Offset = "0x1CE1DE8", VA = "0x7BBC4E1DE8")]
		private void SetGiftMailContentText(string text)
		{
		}

		// Token: 0x06008CCA RID: 36042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CCA")]
		[Address(RVA = "0x1CE1E3C", Offset = "0x1CE1E3C", VA = "0x7BBC4E1E3C")]
		private void SetGiftMailMessageText(string text)
		{
		}

		// Token: 0x06008CCB RID: 36043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008CCB")]
		[Address(RVA = "0x1CE3E60", Offset = "0x1CE3E60", VA = "0x7BBC4E3E60")]
		private string FixRichTextToBlack(string str)
		{
			return null;
		}

		// Token: 0x06008CCC RID: 36044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CCC")]
		[Address(RVA = "0x1CE3EC0", Offset = "0x1CE3EC0", VA = "0x7BBC4E3EC0")]
		public UIMailController()
		{
		}

		// Token: 0x06008CCD RID: 36045 RVA: 0x00025890 File Offset: 0x00023A90
		[Token(Token = "0x6008CCD")]
		[Address(RVA = "0x1CE3F68", Offset = "0x1CE3F68", VA = "0x7BBC4E3F68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144440", Offset = "0x1144440")]
		private bool <OnDeleteAllBtnClick>b__15_0(MailInfo a)
		{
			return default(bool);
		}

		// Token: 0x06008CCE RID: 36046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CCE")]
		[Address(RVA = "0x1CE3FA0", Offset = "0x1CE3FA0", VA = "0x7BBC4E3FA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144450", Offset = "0x1144450")]
		private void <OnDeleteAllBtnClick>b__15_1()
		{
		}

		// Token: 0x06008CCF RID: 36047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CCF")]
		[Address(RVA = "0x1CE4000", Offset = "0x1CE4000", VA = "0x7BBC4E4000")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144460", Offset = "0x1144460")]
		private void <OnDeleteAllBtnClick>b__15_2()
		{
		}

		// Token: 0x06008CD0 RID: 36048 RVA: 0x000258A8 File Offset: 0x00023AA8
		[Token(Token = "0x6008CD0")]
		[Address(RVA = "0x1CE4044", Offset = "0x1CE4044", VA = "0x7BBC4E4044")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144470", Offset = "0x1144470")]
		private bool <RefreshBatchOperationBtns>b__27_0(MailInfo a)
		{
			return default(bool);
		}

		// Token: 0x06008CD1 RID: 36049 RVA: 0x000258C0 File Offset: 0x00023AC0
		[Token(Token = "0x6008CD1")]
		[Address(RVA = "0x1CE407C", Offset = "0x1CE407C", VA = "0x7BBC4E407C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144480", Offset = "0x1144480")]
		private bool <RefreshBatchOperationBtns>b__27_1(MailInfo a)
		{
			return default(bool);
		}

		// Token: 0x06008CD2 RID: 36050 RVA: 0x000258D8 File Offset: 0x00023AD8
		[Token(Token = "0x6008CD2")]
		[Address(RVA = "0x1CE40B4", Offset = "0x1CE40B4", VA = "0x7BBC4E40B4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144490", Offset = "0x1144490")]
		private bool <ReadMailRefreshUIData>b__37_0(MailInfo a)
		{
			return default(bool);
		}

		// Token: 0x0400990D RID: 39181
		[Token(Token = "0x400990D")]
		[FieldOffset(Offset = "0xB0")]
		private UIMailView m_View;

		// Token: 0x0400990E RID: 39182
		[Token(Token = "0x400990E")]
		[FieldOffset(Offset = "0xB8")]
		private UIModelMail m_Model;

		// Token: 0x0400990F RID: 39183
		[Token(Token = "0x400990F")]
		[FieldOffset(Offset = "0xC0")]
		private List<MailInfo> m_MailInfoList;

		// Token: 0x04009910 RID: 39184
		[Token(Token = "0x4009910")]
		[FieldOffset(Offset = "0xC8")]
		private int m_CurrentIndex;

		// Token: 0x04009911 RID: 39185
		[Token(Token = "0x4009911")]
		[FieldOffset(Offset = "0xD0")]
		private MailInfo m_CurrentMailInfo;

		// Token: 0x04009912 RID: 39186
		[Token(Token = "0x4009912")]
		[FieldOffset(Offset = "0xD8")]
		private ulong m_CurrentMailId;

		// Token: 0x04009913 RID: 39187
		[Token(Token = "0x4009913")]
		[FieldOffset(Offset = "0xE0")]
		private List<MailInfo> m_ShouldUpdateMail;

		// Token: 0x04009914 RID: 39188
		[Token(Token = "0x4009914")]
		[FieldOffset(Offset = "0xE8")]
		private List<MailInfo> m_ShouldDelayUpdateMail;

		// Token: 0x04009915 RID: 39189
		[Token(Token = "0x4009915")]
		[FieldOffset(Offset = "0xF0")]
		private List<GameObject> m_MailContentBtns;

		// Token: 0x04009916 RID: 39190
		[Token(Token = "0x4009916")]
		private const int MailNoRewardBottom = 20;

		// Token: 0x04009917 RID: 39191
		[Token(Token = "0x4009917")]
		private const int MailRewardBottom = 140;

		// Token: 0x02001A30 RID: 6704
		[Token(Token = "0x2001A30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F7B5C", Offset = "0x10F7B5C")]
		private sealed class <>c__DisplayClass17_0
		{
			// Token: 0x06008CD3 RID: 36051 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008CD3")]
			[Address(RVA = "0x1CDF884", Offset = "0x1CDF884", VA = "0x7BBC4DF884")]
			public <>c__DisplayClass17_0()
			{
			}

			// Token: 0x06008CD4 RID: 36052 RVA: 0x000258F0 File Offset: 0x00023AF0
			[Token(Token = "0x6008CD4")]
			[Address(RVA = "0x1CE40F0", Offset = "0x1CE40F0", VA = "0x7BBC4E40F0")]
			internal bool <SelectMail>b__0(MailInfo mail)
			{
				return default(bool);
			}

			// Token: 0x04009918 RID: 39192
			[Token(Token = "0x4009918")]
			[FieldOffset(Offset = "0x10")]
			public uint type;
		}

		// Token: 0x02001A31 RID: 6705
		[Token(Token = "0x2001A31")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F7B6C", Offset = "0x10F7B6C")]
		private sealed class <>c__DisplayClass21_0
		{
			// Token: 0x06008CD5 RID: 36053 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008CD5")]
			[Address(RVA = "0x1CDFC8C", Offset = "0x1CDFC8C", VA = "0x7BBC4DFC8C")]
			public <>c__DisplayClass21_0()
			{
			}

			// Token: 0x06008CD6 RID: 36054 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008CD6")]
			[Address(RVA = "0x1CE4140", Offset = "0x1CE4140", VA = "0x7BBC4E4140")]
			internal void <ShowGetGiftPanel>b__0()
			{
			}

			// Token: 0x04009919 RID: 39193
			[Token(Token = "0x4009919")]
			[FieldOffset(Offset = "0x10")]
			public UIMailController <>4__this;

			// Token: 0x0400991A RID: 39194
			[Token(Token = "0x400991A")]
			[FieldOffset(Offset = "0x18")]
			public MailInfo mailInfo;
		}

		// Token: 0x02001A32 RID: 6706
		[Token(Token = "0x2001A32")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F7B7C", Offset = "0x10F7B7C")]
		private sealed class <CoResetScrollView>d__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06008CD7 RID: 36055 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008CD7")]
			[Address(RVA = "0x1CE3B80", Offset = "0x1CE3B80", VA = "0x7BBC4E3B80")]
			[DebuggerHidden]
			public <CoResetScrollView>d__35(int <>1__state)
			{
			}

			// Token: 0x06008CD8 RID: 36056 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008CD8")]
			[Address(RVA = "0x1CE430C", Offset = "0x1CE430C", VA = "0x7BBC4E430C", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06008CD9 RID: 36057 RVA: 0x00025908 File Offset: 0x00023B08
			[Token(Token = "0x6008CD9")]
			[Address(RVA = "0x1CE4310", Offset = "0x1CE4310", VA = "0x7BBC4E4310", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170009DD RID: 2525
			// (get) Token: 0x06008CDA RID: 36058 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009DD")]
			private object Current
			{
				[Token(Token = "0x6008CDA")]
				[Address(RVA = "0x1CE43BC", Offset = "0x1CE43BC", VA = "0x7BBC4E43BC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06008CDB RID: 36059 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008CDB")]
			[Address(RVA = "0x1CE43C4", Offset = "0x1CE43C4", VA = "0x7BBC4E43C4", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170009DE RID: 2526
			// (get) Token: 0x06008CDC RID: 36060 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009DE")]
			private object Current
			{
				[Token(Token = "0x6008CDC")]
				[Address(RVA = "0x1CE442C", Offset = "0x1CE442C", VA = "0x7BBC4E442C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400991B RID: 39195
			[Token(Token = "0x400991B")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400991C RID: 39196
			[Token(Token = "0x400991C")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400991D RID: 39197
			[Token(Token = "0x400991D")]
			[FieldOffset(Offset = "0x20")]
			public UIMailController <>4__this;
		}

		// Token: 0x02001A33 RID: 6707
		[Token(Token = "0x2001A33")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F7B8C", Offset = "0x10F7B8C")]
		private sealed class <CoReposRewardScroll>d__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06008CDD RID: 36061 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008CDD")]
			[Address(RVA = "0x1CE3C20", Offset = "0x1CE3C20", VA = "0x7BBC4E3C20")]
			[DebuggerHidden]
			public <CoReposRewardScroll>d__36(int <>1__state)
			{
			}

			// Token: 0x06008CDE RID: 36062 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008CDE")]
			[Address(RVA = "0x1CE41E8", Offset = "0x1CE41E8", VA = "0x7BBC4E41E8", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06008CDF RID: 36063 RVA: 0x00025920 File Offset: 0x00023B20
			[Token(Token = "0x6008CDF")]
			[Address(RVA = "0x1CE41EC", Offset = "0x1CE41EC", VA = "0x7BBC4E41EC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170009DF RID: 2527
			// (get) Token: 0x06008CE0 RID: 36064 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009DF")]
			private object Current
			{
				[Token(Token = "0x6008CE0")]
				[Address(RVA = "0x1CE4294", Offset = "0x1CE4294", VA = "0x7BBC4E4294", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06008CE1 RID: 36065 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008CE1")]
			[Address(RVA = "0x1CE429C", Offset = "0x1CE429C", VA = "0x7BBC4E429C", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170009E0 RID: 2528
			// (get) Token: 0x06008CE2 RID: 36066 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009E0")]
			private object Current
			{
				[Token(Token = "0x6008CE2")]
				[Address(RVA = "0x1CE4304", Offset = "0x1CE4304", VA = "0x7BBC4E4304", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400991E RID: 39198
			[Token(Token = "0x400991E")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400991F RID: 39199
			[Token(Token = "0x400991F")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04009920 RID: 39200
			[Token(Token = "0x4009920")]
			[FieldOffset(Offset = "0x20")]
			public UIMailController <>4__this;
		}

		// Token: 0x02001A34 RID: 6708
		[Token(Token = "0x2001A34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F7B9C", Offset = "0x10F7B9C")]
		private sealed class <>c__DisplayClass44_0
		{
			// Token: 0x06008CE3 RID: 36067 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008CE3")]
			[Address(RVA = "0x1CE3E58", Offset = "0x1CE3E58", VA = "0x7BBC4E3E58")]
			public <>c__DisplayClass44_0()
			{
			}

			// Token: 0x06008CE4 RID: 36068 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008CE4")]
			[Address(RVA = "0x1CE4194", Offset = "0x1CE4194", VA = "0x7BBC4E4194")]
			internal void <ShowGiftMail>b__0()
			{
			}

			// Token: 0x04009921 RID: 39201
			[Token(Token = "0x4009921")]
			[FieldOffset(Offset = "0x10")]
			public MailInfo info;

			// Token: 0x04009922 RID: 39202
			[Token(Token = "0x4009922")]
			[FieldOffset(Offset = "0x18")]
			public UIMailController <>4__this;
		}
	}
}
