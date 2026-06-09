using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001631 RID: 5681
	[Token(Token = "0x2001631")]
	internal class UIPVEMapSelectionController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06006641 RID: 26177 RVA: 0x0001D310 File Offset: 0x0001B510
		[Token(Token = "0x6006641")]
		[Address(RVA = "0x16E4F64", Offset = "0x16E4F64", VA = "0x7BBBEE4F64")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006642 RID: 26178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006642")]
		[Address(RVA = "0x16E4FB4", Offset = "0x16E4FB4", VA = "0x7BBBEE4FB4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006643 RID: 26179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006643")]
		[Address(RVA = "0x16E5790", Offset = "0x16E5790", VA = "0x7BBBEE5790", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006644 RID: 26180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006644")]
		[Address(RVA = "0x16E5450", Offset = "0x16E5450", VA = "0x7BBBEE5450")]
		private void RefreshMapSprite()
		{
		}

		// Token: 0x06006645 RID: 26181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006645")]
		[Address(RVA = "0x16E587C", Offset = "0x16E587C", VA = "0x7BBBEE587C")]
		private void OnDifficultyBtnClick()
		{
		}

		// Token: 0x06006646 RID: 26182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006646")]
		[Address(RVA = "0x16E557C", Offset = "0x16E557C", VA = "0x7BBBEE557C")]
		private void ChangeMapDifficutly(EMapDifficulty difficulty)
		{
		}

		// Token: 0x06006647 RID: 26183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006647")]
		[Address(RVA = "0x16E5F2C", Offset = "0x16E5F2C", VA = "0x7BBBEE5F2C")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1140768", Offset = "0x1140768")]
		private IEnumerator CloseDifficultyPanel(float seconds)
		{
			return null;
		}

		// Token: 0x06006648 RID: 26184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006648")]
		[Address(RVA = "0x16E5FF0", Offset = "0x16E5FF0", VA = "0x7BBBEE5FF0")]
		private void RefreshDifficultyBtnStatus()
		{
		}

		// Token: 0x06006649 RID: 26185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006649")]
		[Address(RVA = "0x16E6140", Offset = "0x16E6140", VA = "0x7BBBEE6140")]
		public void SetMapData()
		{
		}

		// Token: 0x0600664A RID: 26186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600664A")]
		[Address(RVA = "0x16E5DCC", Offset = "0x16E5DCC", VA = "0x7BBBEE5DCC")]
		private void SetArrRotation()
		{
		}

		// Token: 0x0600664B RID: 26187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600664B")]
		[Address(RVA = "0x16E6164", Offset = "0x16E6164", VA = "0x7BBBEE6164")]
		private void OnBtn1Click()
		{
		}

		// Token: 0x0600664C RID: 26188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600664C")]
		[Address(RVA = "0x16E61D4", Offset = "0x16E61D4", VA = "0x7BBBEE61D4")]
		private void OnBtn2Click()
		{
		}

		// Token: 0x0600664D RID: 26189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600664D")]
		[Address(RVA = "0x16E6244", Offset = "0x16E6244", VA = "0x7BBBEE6244")]
		private void CloseMapSelectionPanel(params object[] data)
		{
		}

		// Token: 0x0600664E RID: 26190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600664E")]
		[Address(RVA = "0x16E63D0", Offset = "0x16E63D0", VA = "0x7BBBEE63D0", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600664F RID: 26191 RVA: 0x0001D328 File Offset: 0x0001B528
		[Token(Token = "0x600664F")]
		[Address(RVA = "0x16E6450", Offset = "0x16E6450", VA = "0x7BBBEE6450", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06006650 RID: 26192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006650")]
		[Address(RVA = "0x16E64B4", Offset = "0x16E64B4", VA = "0x7BBBEE64B4")]
		public UIPVEMapSelectionController()
		{
		}

		// Token: 0x04008415 RID: 33813
		[Token(Token = "0x4008415")]
		[FieldOffset(Offset = "0x58")]
		private UIPVEMapSelectionView m_View;

		// Token: 0x04008416 RID: 33814
		[Token(Token = "0x4008416")]
		[FieldOffset(Offset = "0x60")]
		private UIModelGroup m_ModelGroup;

		// Token: 0x04008417 RID: 33815
		[Token(Token = "0x4008417")]
		[FieldOffset(Offset = "0x68")]
		private UIModelMapOpeningInfo m_ModelMap;

		// Token: 0x04008418 RID: 33816
		[Token(Token = "0x4008418")]
		[FieldOffset(Offset = "0x70")]
		private EMapDifficulty m_SelectedDifficulty;

		// Token: 0x04008419 RID: 33817
		[Token(Token = "0x4008419")]
		[FieldOffset(Offset = "0x78")]
		private MapConfigData m_MapConfigData;

		// Token: 0x0400841A RID: 33818
		[Token(Token = "0x400841A")]
		[FieldOffset(Offset = "0x80")]
		private List<EMapDifficulty> m_DifficultyOptions;

		// Token: 0x02001632 RID: 5682
		[Token(Token = "0x2001632")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EFDB4", Offset = "0x10EFDB4")]
		private sealed class <CloseDifficultyPanel>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006651 RID: 26193 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006651")]
			[Address(RVA = "0x16E5FC4", Offset = "0x16E5FC4", VA = "0x7BBBEE5FC4")]
			[DebuggerHidden]
			public <CloseDifficultyPanel>d__12(int <>1__state)
			{
			}

			// Token: 0x06006652 RID: 26194 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006652")]
			[Address(RVA = "0x16E6524", Offset = "0x16E6524", VA = "0x7BBBEE6524", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006653 RID: 26195 RVA: 0x0001D340 File Offset: 0x0001B540
			[Token(Token = "0x6006653")]
			[Address(RVA = "0x16E6528", Offset = "0x16E6528", VA = "0x7BBBEE6528", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000904 RID: 2308
			// (get) Token: 0x06006654 RID: 26196 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000904")]
			private object Current
			{
				[Token(Token = "0x6006654")]
				[Address(RVA = "0x16E6608", Offset = "0x16E6608", VA = "0x7BBBEE6608", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006655 RID: 26197 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006655")]
			[Address(RVA = "0x16E6610", Offset = "0x16E6610", VA = "0x7BBBEE6610", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000905 RID: 2309
			// (get) Token: 0x06006656 RID: 26198 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000905")]
			private object Current
			{
				[Token(Token = "0x6006656")]
				[Address(RVA = "0x16E6678", Offset = "0x16E6678", VA = "0x7BBBEE6678", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400841B RID: 33819
			[Token(Token = "0x400841B")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400841C RID: 33820
			[Token(Token = "0x400841C")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400841D RID: 33821
			[Token(Token = "0x400841D")]
			[FieldOffset(Offset = "0x20")]
			public float seconds;

			// Token: 0x0400841E RID: 33822
			[Token(Token = "0x400841E")]
			[FieldOffset(Offset = "0x28")]
			public UIPVEMapSelectionController <>4__this;
		}
	}
}
