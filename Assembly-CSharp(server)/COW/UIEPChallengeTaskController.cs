using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020014EC RID: 5356
	[Token(Token = "0x20014EC")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EDC7C", Offset = "0x10EDC7C")]
	public class UIEPChallengeTaskController : UIBaseController, IEasyList
	{
		// Token: 0x06005BA5 RID: 23461 RVA: 0x0001AC10 File Offset: 0x00018E10
		[Token(Token = "0x6005BA5")]
		[Address(RVA = "0x220C328", Offset = "0x220C328", VA = "0x7BBCA0C328")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005BA6 RID: 23462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BA6")]
		[Address(RVA = "0x220C378", Offset = "0x220C378", VA = "0x7BBCA0C378", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005BA7 RID: 23463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BA7")]
		[Address(RVA = "0x220C49C", Offset = "0x220C49C", VA = "0x7BBCA0C49C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005BA8 RID: 23464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BA8")]
		[Address(RVA = "0x220C568", Offset = "0x220C568", VA = "0x7BBCA0C568")]
		private void OnQuestUpdate(params object[] data)
		{
		}

		// Token: 0x06005BA9 RID: 23465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BA9")]
		[Address(RVA = "0x220C498", Offset = "0x220C498", VA = "0x7BBCA0C498")]
		private void InitData()
		{
		}

		// Token: 0x06005BAA RID: 23466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BAA")]
		[Address(RVA = "0x220C608", Offset = "0x220C608", VA = "0x7BBCA0C608")]
		private void RefreshEasyList()
		{
		}

		// Token: 0x06005BAB RID: 23467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BAB")]
		[Address(RVA = "0x220C7D0", Offset = "0x220C7D0", VA = "0x7BBCA0C7D0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113F648", Offset = "0x113F648")]
		private IEnumerator CoResetScrollView()
		{
			return null;
		}

		// Token: 0x06005BAC RID: 23468 RVA: 0x0001AC28 File Offset: 0x00018E28
		[Token(Token = "0x6005BAC")]
		[Address(RVA = "0x220C870", Offset = "0x220C870", VA = "0x7BBCA0C870")]
		private int SortTaskList(EPMonthlyQuestInfo x, EPMonthlyQuestInfo y)
		{
			return 0;
		}

		// Token: 0x06005BAD RID: 23469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BAD")]
		[Address(RVA = "0x220C960", Offset = "0x220C960", VA = "0x7BBCA0C960", Slot = "28")]
		private UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06005BAE RID: 23470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BAE")]
		[Address(RVA = "0x220C9F4", Offset = "0x220C9F4", VA = "0x7BBCA0C9F4", Slot = "29")]
		private void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06005BAF RID: 23471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BAF")]
		[Address(RVA = "0x220CA24", Offset = "0x220CA24", VA = "0x7BBCA0CA24")]
		public UIEPChallengeTaskController()
		{
		}

		// Token: 0x04007E1C RID: 32284
		[Token(Token = "0x4007E1C")]
		[FieldOffset(Offset = "0x58")]
		private UIEPChallengeTaskView m_View;

		// Token: 0x020014ED RID: 5357
		[Token(Token = "0x20014ED")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EDCB4", Offset = "0x10EDCB4")]
		private sealed class <CoResetScrollView>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06005BB0 RID: 23472 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005BB0")]
			[Address(RVA = "0x220C844", Offset = "0x220C844", VA = "0x7BBCA0C844")]
			[DebuggerHidden]
			public <CoResetScrollView>d__7(int <>1__state)
			{
			}

			// Token: 0x06005BB1 RID: 23473 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005BB1")]
			[Address(RVA = "0x220CA2C", Offset = "0x220CA2C", VA = "0x7BBCA0CA2C", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06005BB2 RID: 23474 RVA: 0x0001AC40 File Offset: 0x00018E40
			[Token(Token = "0x6005BB2")]
			[Address(RVA = "0x220CA30", Offset = "0x220CA30", VA = "0x7BBCA0CA30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170008A7 RID: 2215
			// (get) Token: 0x06005BB3 RID: 23475 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008A7")]
			private object Current
			{
				[Token(Token = "0x6005BB3")]
				[Address(RVA = "0x220CADC", Offset = "0x220CADC", VA = "0x7BBCA0CADC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06005BB4 RID: 23476 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005BB4")]
			[Address(RVA = "0x220CAE4", Offset = "0x220CAE4", VA = "0x7BBCA0CAE4", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170008A8 RID: 2216
			// (get) Token: 0x06005BB5 RID: 23477 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008A8")]
			private object Current
			{
				[Token(Token = "0x6005BB5")]
				[Address(RVA = "0x220CB4C", Offset = "0x220CB4C", VA = "0x7BBCA0CB4C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04007E1D RID: 32285
			[Token(Token = "0x4007E1D")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04007E1E RID: 32286
			[Token(Token = "0x4007E1E")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04007E1F RID: 32287
			[Token(Token = "0x4007E1F")]
			[FieldOffset(Offset = "0x20")]
			public UIEPChallengeTaskController <>4__this;
		}
	}
}
