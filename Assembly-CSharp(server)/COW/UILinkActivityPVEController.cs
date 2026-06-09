using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200154E RID: 5454
	[Token(Token = "0x200154E")]
	public class UILinkActivityPVEController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06005E4D RID: 24141 RVA: 0x0001B540 File Offset: 0x00019740
		[Token(Token = "0x6005E4D")]
		[Address(RVA = "0x1CBEF60", Offset = "0x1CBEF60", VA = "0x7BBC4BEF60")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005E4E RID: 24142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E4E")]
		[Address(RVA = "0x1CBEFB0", Offset = "0x1CBEFB0", VA = "0x7BBC4BEFB0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005E4F RID: 24143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E4F")]
		[Address(RVA = "0x1CBF40C", Offset = "0x1CBF40C", VA = "0x7BBC4BF40C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005E50 RID: 24144 RVA: 0x0001B558 File Offset: 0x00019758
		[Token(Token = "0x6005E50")]
		[Address(RVA = "0x1CBF474", Offset = "0x1CBF474", VA = "0x7BBC4BF474", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06005E51 RID: 24145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E51")]
		[Address(RVA = "0x1CBF4D8", Offset = "0x1CBF4D8", VA = "0x7BBC4BF4D8", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005E52 RID: 24146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E52")]
		[Address(RVA = "0x1CBF1F8", Offset = "0x1CBF1F8", VA = "0x7BBC4BF1F8")]
		protected void InitActivityInfo()
		{
		}

		// Token: 0x06005E53 RID: 24147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E53")]
		[Address(RVA = "0x1CBFA70", Offset = "0x1CBFA70", VA = "0x7BBC4BFA70")]
		private void InitCollectionInfos()
		{
		}

		// Token: 0x06005E54 RID: 24148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E54")]
		[Address(RVA = "0x1CBFE08", Offset = "0x1CBFE08", VA = "0x7BBC4BFE08")]
		private void SetCollectionDatas()
		{
		}

		// Token: 0x06005E55 RID: 24149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E55")]
		[Address(RVA = "0x1CC01F4", Offset = "0x1CC01F4", VA = "0x7BBC4C01F4")]
		private void SetCollectionUIItems(int itemNum)
		{
		}

		// Token: 0x06005E56 RID: 24150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E56")]
		[Address(RVA = "0x1CC04E8", Offset = "0x1CC04E8", VA = "0x7BBC4C04E8")]
		private void UpdateCollectionItem(int index, UILinkActivityPVEController.CollectionInfo info)
		{
		}

		// Token: 0x06005E57 RID: 24151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E57")]
		[Address(RVA = "0x1CC0308", Offset = "0x1CC0308", VA = "0x7BBC4C0308")]
		private void CreateCollectionItem(int index)
		{
		}

		// Token: 0x06005E58 RID: 24152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E58")]
		[Address(RVA = "0x1CBFC40", Offset = "0x1CBFC40", VA = "0x7BBC4BFC40")]
		private void UpdateProgressLayer()
		{
		}

		// Token: 0x06005E59 RID: 24153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E59")]
		[Address(RVA = "0x1CBFAE4", Offset = "0x1CBFAE4", VA = "0x7BBC4BFAE4")]
		private void UpdateEPCount()
		{
		}

		// Token: 0x06005E5A RID: 24154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E5A")]
		[Address(RVA = "0x1CBF5EC", Offset = "0x1CBF5EC", VA = "0x7BBC4BF5EC")]
		private void UpdataRankUIS()
		{
		}

		// Token: 0x06005E5B RID: 24155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E5B")]
		[Address(RVA = "0x1CC0764", Offset = "0x1CC0764", VA = "0x7BBC4C0764")]
		private void OnCollectionClick(uint processID)
		{
		}

		// Token: 0x06005E5C RID: 24156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E5C")]
		[Address(RVA = "0x1CC09EC", Offset = "0x1CC09EC", VA = "0x7BBC4C09EC")]
		private void ShowConfirmWindow()
		{
		}

		// Token: 0x06005E5D RID: 24157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E5D")]
		[Address(RVA = "0x1CC0AE8", Offset = "0x1CC0AE8", VA = "0x7BBC4C0AE8")]
		private void OnConfirmBatchClaim()
		{
		}

		// Token: 0x06005E5E RID: 24158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E5E")]
		[Address(RVA = "0x1CBF5C0", Offset = "0x1CBF5C0", VA = "0x7BBC4BF5C0")]
		private void BeginSwitchToStartGamePage()
		{
		}

		// Token: 0x06005E5F RID: 24159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E5F")]
		[Address(RVA = "0x1CC0B20", Offset = "0x1CC0B20", VA = "0x7BBC4C0B20")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113FB2C", Offset = "0x113FB2C")]
		private IEnumerator StartAnim()
		{
			return null;
		}

		// Token: 0x06005E60 RID: 24160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E60")]
		[Address(RVA = "0x1CC0BC0", Offset = "0x1CC0BC0", VA = "0x7BBC4C0BC0")]
		public UILinkActivityPVEController()
		{
		}

		// Token: 0x04007FA8 RID: 32680
		[Token(Token = "0x4007FA8")]
		[FieldOffset(Offset = "0x0")]
		public static readonly uint Const_OpenGameProcessID;

		// Token: 0x04007FA9 RID: 32681
		[Token(Token = "0x4007FA9")]
		[FieldOffset(Offset = "0x4")]
		public static readonly uint Const_MAXEPCount;

		// Token: 0x04007FAA RID: 32682
		[Token(Token = "0x4007FAA")]
		private const uint GloabEPLeaderBoard = 4112U;

		// Token: 0x04007FAB RID: 32683
		[Token(Token = "0x4007FAB")]
		[FieldOffset(Offset = "0x58")]
		private UILinkActivityPVEView m_View;

		// Token: 0x04007FAC RID: 32684
		[Token(Token = "0x4007FAC")]
		[FieldOffset(Offset = "0x60")]
		protected UIModelLinkActivity m_Model;

		// Token: 0x04007FAD RID: 32685
		[Token(Token = "0x4007FAD")]
		[FieldOffset(Offset = "0x68")]
		private UIModelLeaderBoard m_LeaderBoardModel;

		// Token: 0x04007FAE RID: 32686
		[Token(Token = "0x4007FAE")]
		[FieldOffset(Offset = "0x70")]
		private LinkActivityData m_ActivityData;

		// Token: 0x04007FAF RID: 32687
		[Token(Token = "0x4007FAF")]
		[FieldOffset(Offset = "0x78")]
		private List<UILinkActivityPVECollectionItem> m_CollectionUIItems;

		// Token: 0x04007FB0 RID: 32688
		[Token(Token = "0x4007FB0")]
		[FieldOffset(Offset = "0x80")]
		private List<UILinkActivityPVEController.CollectionInfo> m_CollectionDatas;

		// Token: 0x04007FB1 RID: 32689
		[Token(Token = "0x4007FB1")]
		[FieldOffset(Offset = "0x88")]
		private ulong m_CurrentEPCount;

		// Token: 0x04007FB2 RID: 32690
		[Token(Token = "0x4007FB2")]
		[FieldOffset(Offset = "0x90")]
		public Action m_SwitchToGameStartCallBack;

		// Token: 0x04007FB3 RID: 32691
		[Token(Token = "0x4007FB3")]
		[FieldOffset(Offset = "0x98")]
		private List<uint> m_AllPendingClamIProcessID;

		// Token: 0x04007FB4 RID: 32692
		[Token(Token = "0x4007FB4")]
		[FieldOffset(Offset = "0xA0")]
		private float m_CurProgressValue;

		// Token: 0x0200154F RID: 5455
		[Token(Token = "0x200154F")]
		private class CollectionInfo
		{
			// Token: 0x06005E62 RID: 24162 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E62")]
			[Address(RVA = "0x1CC0300", Offset = "0x1CC0300", VA = "0x7BBC4C0300")]
			public CollectionInfo()
			{
			}

			// Token: 0x04007FB5 RID: 32693
			[Token(Token = "0x4007FB5")]
			[FieldOffset(Offset = "0x10")]
			public ulong targetCount;

			// Token: 0x04007FB6 RID: 32694
			[Token(Token = "0x4007FB6")]
			[FieldOffset(Offset = "0x18")]
			public uint processID;

			// Token: 0x04007FB7 RID: 32695
			[Token(Token = "0x4007FB7")]
			[FieldOffset(Offset = "0x1C")]
			public ENUM_CollectionState state;
		}

		// Token: 0x02001550 RID: 5456
		[Token(Token = "0x2001550")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EE58C", Offset = "0x10EE58C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005E64 RID: 24164 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E64")]
			[Address(RVA = "0x1CC0CFC", Offset = "0x1CC0CFC", VA = "0x7BBC4C0CFC")]
			public <>c()
			{
			}

			// Token: 0x06005E65 RID: 24165 RVA: 0x0001B570 File Offset: 0x00019770
			[Token(Token = "0x6005E65")]
			[Address(RVA = "0x1CC0D04", Offset = "0x1CC0D04", VA = "0x7BBC4C0D04")]
			internal ulong <SetCollectionDatas>b__21_0(UILinkActivityPVEController.CollectionInfo u)
			{
				return 0UL;
			}

			// Token: 0x04007FB8 RID: 32696
			[Token(Token = "0x4007FB8")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UILinkActivityPVEController.<>c <>9;

			// Token: 0x04007FB9 RID: 32697
			[Token(Token = "0x4007FB9")]
			[FieldOffset(Offset = "0x8")]
			public static Func<UILinkActivityPVEController.CollectionInfo, ulong> <>9__21_0;
		}

		// Token: 0x02001551 RID: 5457
		[Token(Token = "0x2001551")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EE59C", Offset = "0x10EE59C")]
		private sealed class <StartAnim>d__32 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06005E66 RID: 24166 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E66")]
			[Address(RVA = "0x1CC0B94", Offset = "0x1CC0B94", VA = "0x7BBC4C0B94")]
			[DebuggerHidden]
			public <StartAnim>d__32(int <>1__state)
			{
			}

			// Token: 0x06005E67 RID: 24167 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E67")]
			[Address(RVA = "0x1CC0D30", Offset = "0x1CC0D30", VA = "0x7BBC4C0D30", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06005E68 RID: 24168 RVA: 0x0001B588 File Offset: 0x00019788
			[Token(Token = "0x6005E68")]
			[Address(RVA = "0x1CC0D34", Offset = "0x1CC0D34", VA = "0x7BBC4C0D34", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170008B3 RID: 2227
			// (get) Token: 0x06005E69 RID: 24169 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008B3")]
			private object Current
			{
				[Token(Token = "0x6005E69")]
				[Address(RVA = "0x1CC0E94", Offset = "0x1CC0E94", VA = "0x7BBC4C0E94", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06005E6A RID: 24170 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E6A")]
			[Address(RVA = "0x1CC0E9C", Offset = "0x1CC0E9C", VA = "0x7BBC4C0E9C", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170008B4 RID: 2228
			// (get) Token: 0x06005E6B RID: 24171 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008B4")]
			private object Current
			{
				[Token(Token = "0x6005E6B")]
				[Address(RVA = "0x1CC0F04", Offset = "0x1CC0F04", VA = "0x7BBC4C0F04", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04007FBA RID: 32698
			[Token(Token = "0x4007FBA")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04007FBB RID: 32699
			[Token(Token = "0x4007FBB")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04007FBC RID: 32700
			[Token(Token = "0x4007FBC")]
			[FieldOffset(Offset = "0x20")]
			public UILinkActivityPVEController <>4__this;
		}
	}
}
