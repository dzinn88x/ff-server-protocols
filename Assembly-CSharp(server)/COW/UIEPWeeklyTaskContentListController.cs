using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001509 RID: 5385
	[Token(Token = "0x2001509")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EDFAC", Offset = "0x10EDFAC")]
	public class UIEPWeeklyTaskContentListController : UIPopupWindowController
	{
		// Token: 0x06005C66 RID: 23654 RVA: 0x0001AE98 File Offset: 0x00019098
		[Token(Token = "0x6005C66")]
		[Address(RVA = "0x1AD2B1C", Offset = "0x1AD2B1C", VA = "0x7BBC2D2B1C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005C67 RID: 23655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C67")]
		[Address(RVA = "0x1AD2B6C", Offset = "0x1AD2B6C", VA = "0x7BBC2D2B6C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005C68 RID: 23656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C68")]
		[Address(RVA = "0x1AD2D54", Offset = "0x1AD2D54", VA = "0x7BBC2D2D54", Slot = "20")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06005C69 RID: 23657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C69")]
		[Address(RVA = "0x1AD2D5C", Offset = "0x1AD2D5C", VA = "0x7BBC2D2D5C")]
		private void OnPreClick()
		{
		}

		// Token: 0x06005C6A RID: 23658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C6A")]
		[Address(RVA = "0x1AD2EAC", Offset = "0x1AD2EAC", VA = "0x7BBC2D2EAC")]
		private void OnNextClick()
		{
		}

		// Token: 0x06005C6B RID: 23659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C6B")]
		[Address(RVA = "0x1AD2DE8", Offset = "0x1AD2DE8", VA = "0x7BBC2D2DE8")]
		private void DoCenter()
		{
		}

		// Token: 0x06005C6C RID: 23660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C6C")]
		[Address(RVA = "0x1AD2F6C", Offset = "0x1AD2F6C", VA = "0x7BBC2D2F6C")]
		private void SetButtonState()
		{
		}

		// Token: 0x06005C6D RID: 23661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C6D")]
		[Address(RVA = "0x1AD30B4", Offset = "0x1AD30B4", VA = "0x7BBC2D30B4")]
		private void OnCenterChildFinished()
		{
		}

		// Token: 0x06005C6E RID: 23662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C6E")]
		[Address(RVA = "0x1AD15C8", Offset = "0x1AD15C8", VA = "0x7BBC2D15C8")]
		public void SetIdx(int idx)
		{
		}

		// Token: 0x06005C6F RID: 23663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C6F")]
		[Address(RVA = "0x1AD3120", Offset = "0x1AD3120", VA = "0x7BBC2D3120")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113F810", Offset = "0x113F810")]
		private IEnumerator CoShow()
		{
			return null;
		}

		// Token: 0x06005C70 RID: 23664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C70")]
		[Address(RVA = "0x1AD31C0", Offset = "0x1AD31C0", VA = "0x7BBC2D31C0")]
		private void DoShow()
		{
		}

		// Token: 0x06005C71 RID: 23665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C71")]
		[Address(RVA = "0x1AD378C", Offset = "0x1AD378C", VA = "0x7BBC2D378C")]
		public UIEPWeeklyTaskContentListController()
		{
		}

		// Token: 0x04007EA1 RID: 32417
		[Token(Token = "0x4007EA1")]
		[FieldOffset(Offset = "0x98")]
		private UIEPWeeklyTaskContentListView m_View;

		// Token: 0x04007EA2 RID: 32418
		[Token(Token = "0x4007EA2")]
		[FieldOffset(Offset = "0xA0")]
		private List<UIEPWeeklyTaskDetailListController> m_ChildCtrl;

		// Token: 0x04007EA3 RID: 32419
		[Token(Token = "0x4007EA3")]
		[FieldOffset(Offset = "0xA8")]
		private int m_CurChildIndex;

		// Token: 0x0200150A RID: 5386
		[Token(Token = "0x200150A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EDFE4", Offset = "0x10EDFE4")]
		private sealed class <CoShow>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06005C72 RID: 23666 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005C72")]
			[Address(RVA = "0x1AD3194", Offset = "0x1AD3194", VA = "0x7BBC2D3194")]
			[DebuggerHidden]
			public <CoShow>d__12(int <>1__state)
			{
			}

			// Token: 0x06005C73 RID: 23667 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005C73")]
			[Address(RVA = "0x1AD37FC", Offset = "0x1AD37FC", VA = "0x7BBC2D37FC", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06005C74 RID: 23668 RVA: 0x0001AEB0 File Offset: 0x000190B0
			[Token(Token = "0x6005C74")]
			[Address(RVA = "0x1AD3800", Offset = "0x1AD3800", VA = "0x7BBC2D3800", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170008AB RID: 2219
			// (get) Token: 0x06005C75 RID: 23669 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008AB")]
			private object Current
			{
				[Token(Token = "0x6005C75")]
				[Address(RVA = "0x1AD3868", Offset = "0x1AD3868", VA = "0x7BBC2D3868", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06005C76 RID: 23670 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005C76")]
			[Address(RVA = "0x1AD3870", Offset = "0x1AD3870", VA = "0x7BBC2D3870", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170008AC RID: 2220
			// (get) Token: 0x06005C77 RID: 23671 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008AC")]
			private object Current
			{
				[Token(Token = "0x6005C77")]
				[Address(RVA = "0x1AD38D8", Offset = "0x1AD38D8", VA = "0x7BBC2D38D8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04007EA4 RID: 32420
			[Token(Token = "0x4007EA4")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04007EA5 RID: 32421
			[Token(Token = "0x4007EA5")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04007EA6 RID: 32422
			[Token(Token = "0x4007EA6")]
			[FieldOffset(Offset = "0x20")]
			public UIEPWeeklyTaskContentListController <>4__this;
		}
	}
}
