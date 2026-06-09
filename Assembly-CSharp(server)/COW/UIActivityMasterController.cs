using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020013F4 RID: 5108
	[Token(Token = "0x20013F4")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EC330", Offset = "0x10EC330")]
	internal class UIActivityMasterController : UIActivityPopWindowBase, IUIModelDataChangeObserver
	{
		// Token: 0x06005404 RID: 21508 RVA: 0x00019158 File Offset: 0x00017358
		[Token(Token = "0x6005404")]
		[Address(RVA = "0x1954540", Offset = "0x1954540", VA = "0x7BBC154540")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005405 RID: 21509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005405")]
		[Address(RVA = "0x19545A8", Offset = "0x19545A8", VA = "0x7BBC1545A8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005406 RID: 21510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005406")]
		[Address(RVA = "0x1954930", Offset = "0x1954930", VA = "0x7BBC154930")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113E644", Offset = "0x113E644")]
		private IEnumerator WaitInitHttpRequest(HttpRequest request)
		{
			return null;
		}

		// Token: 0x06005407 RID: 21511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005407")]
		[Address(RVA = "0x19549F4", Offset = "0x19549F4", VA = "0x7BBC1549F4", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06005408 RID: 21512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005408")]
		[Address(RVA = "0x1954BA8", Offset = "0x1954BA8", VA = "0x7BBC154BA8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005409 RID: 21513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005409")]
		[Address(RVA = "0x1954CD0", Offset = "0x1954CD0", VA = "0x7BBC154CD0", Slot = "42")]
		protected override void OnMainTabSelect(UIActivityPopWindowBase.CategoryTabData data)
		{
		}

		// Token: 0x0600540A RID: 21514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600540A")]
		[Address(RVA = "0x1955044", Offset = "0x1955044", VA = "0x7BBC155044", Slot = "41")]
		public override void PrepareTopTabData()
		{
		}

		// Token: 0x0600540B RID: 21515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600540B")]
		[Address(RVA = "0x1955768", Offset = "0x1955768", VA = "0x7BBC155768")]
		private UIActivityPopWindowBase.CategoryTabData PrepareActivityFestival(EventTabType festivalType)
		{
			return null;
		}

		// Token: 0x0600540C RID: 21516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600540C")]
		[Address(RVA = "0x19559A0", Offset = "0x19559A0", VA = "0x7BBC1559A0", Slot = "44")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600540D RID: 21517 RVA: 0x00019170 File Offset: 0x00017370
		[Token(Token = "0x600540D")]
		[Address(RVA = "0x1955B18", Offset = "0x1955B18", VA = "0x7BBC155B18", Slot = "45")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600540E RID: 21518 RVA: 0x00019188 File Offset: 0x00017388
		[Token(Token = "0x600540E")]
		[Address(RVA = "0x1955B5C", Offset = "0x1955B5C", VA = "0x7BBC155B5C", Slot = "43")]
		protected override int GetTabPriority(UIActivityPopWindowBase.CategoryTabData tabData)
		{
			return 0;
		}

		// Token: 0x0600540F RID: 21519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600540F")]
		[Address(RVA = "0x1955E2C", Offset = "0x1955E2C", VA = "0x7BBC155E2C")]
		public UIActivityMasterController()
		{
		}

		// Token: 0x06005410 RID: 21520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005410")]
		[Address(RVA = "0x1955F90", Offset = "0x1955F90", VA = "0x7BBC155F90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113E6A8", Offset = "0x113E6A8")]
		private UIActivityBaseController <PrepareTopTabData>b__10_0()
		{
			return null;
		}

		// Token: 0x06005411 RID: 21521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005411")]
		[Address(RVA = "0x1956068", Offset = "0x1956068", VA = "0x7BBC156068")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113E6B8", Offset = "0x113E6B8")]
		private UIActivityBaseController <PrepareTopTabData>b__10_1()
		{
			return null;
		}

		// Token: 0x06005412 RID: 21522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005412")]
		[Address(RVA = "0x1956100", Offset = "0x1956100", VA = "0x7BBC156100")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113E6C8", Offset = "0x113E6C8")]
		private UIActivityBaseController <PrepareActivityFestival>b__11_0()
		{
			return null;
		}

		// Token: 0x04007985 RID: 31109
		[Token(Token = "0x4007985")]
		[FieldOffset(Offset = "0x108")]
		private UIModelActivity m_ModelActivity;

		// Token: 0x04007986 RID: 31110
		[Token(Token = "0x4007986")]
		[FieldOffset(Offset = "0x110")]
		private UIModelAnnouncement m_ModelAnnouncement;

		// Token: 0x04007987 RID: 31111
		[Token(Token = "0x4007987")]
		[FieldOffset(Offset = "0x118")]
		private IEnumerator m_WaitInitHttpRequest;

		// Token: 0x020013F5 RID: 5109
		[Token(Token = "0x20013F5")]
		public enum ActivityCategory
		{
			// Token: 0x04007989 RID: 31113
			[Token(Token = "0x4007989")]
			None,
			// Token: 0x0400798A RID: 31114
			[Token(Token = "0x400798A")]
			Activity,
			// Token: 0x0400798B RID: 31115
			[Token(Token = "0x400798B")]
			Announcement,
			// Token: 0x0400798C RID: 31116
			[Token(Token = "0x400798C")]
			SignIn,
			// Token: 0x0400798D RID: 31117
			[Token(Token = "0x400798D")]
			EPChallenge,
			// Token: 0x0400798E RID: 31118
			[Token(Token = "0x400798E")]
			FestivalActivity1,
			// Token: 0x0400798F RID: 31119
			[Token(Token = "0x400798F")]
			FestivalActivity2,
			// Token: 0x04007990 RID: 31120
			[Token(Token = "0x4007990")]
			MegaFestival
		}

		// Token: 0x020013F6 RID: 5110
		[Token(Token = "0x20013F6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EC368", Offset = "0x10EC368")]
		private sealed class <WaitInitHttpRequest>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06005413 RID: 21523 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005413")]
			[Address(RVA = "0x19549C8", Offset = "0x19549C8", VA = "0x7BBC1549C8")]
			[DebuggerHidden]
			public <WaitInitHttpRequest>d__6(int <>1__state)
			{
			}

			// Token: 0x06005414 RID: 21524 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005414")]
			[Address(RVA = "0x195640C", Offset = "0x195640C", VA = "0x7BBC15640C", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06005415 RID: 21525 RVA: 0x000191A0 File Offset: 0x000173A0
			[Token(Token = "0x6005415")]
			[Address(RVA = "0x1956410", Offset = "0x1956410", VA = "0x7BBC156410", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000876 RID: 2166
			// (get) Token: 0x06005416 RID: 21526 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000876")]
			private object Current
			{
				[Token(Token = "0x6005416")]
				[Address(RVA = "0x19564A8", Offset = "0x19564A8", VA = "0x7BBC1564A8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06005417 RID: 21527 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005417")]
			[Address(RVA = "0x19564B0", Offset = "0x19564B0", VA = "0x7BBC1564B0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000877 RID: 2167
			// (get) Token: 0x06005418 RID: 21528 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000877")]
			private object Current
			{
				[Token(Token = "0x6005418")]
				[Address(RVA = "0x1956518", Offset = "0x1956518", VA = "0x7BBC156518", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04007991 RID: 31121
			[Token(Token = "0x4007991")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04007992 RID: 31122
			[Token(Token = "0x4007992")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04007993 RID: 31123
			[Token(Token = "0x4007993")]
			[FieldOffset(Offset = "0x20")]
			public HttpRequest request;

			// Token: 0x04007994 RID: 31124
			[Token(Token = "0x4007994")]
			[FieldOffset(Offset = "0x28")]
			public UIActivityMasterController <>4__this;
		}

		// Token: 0x020013F7 RID: 5111
		[Token(Token = "0x20013F7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EC378", Offset = "0x10EC378")]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x06005419 RID: 21529 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005419")]
			[Address(RVA = "0x1954E68", Offset = "0x1954E68", VA = "0x7BBC154E68")]
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x0600541A RID: 21530 RVA: 0x000191B8 File Offset: 0x000173B8
			[Token(Token = "0x600541A")]
			[Address(RVA = "0x1956238", Offset = "0x1956238", VA = "0x7BBC156238")]
			internal bool <OnMainTabSelect>b__0(AdvertDesc e)
			{
				return default(bool);
			}

			// Token: 0x04007995 RID: 31125
			[Token(Token = "0x4007995")]
			[FieldOffset(Offset = "0x10")]
			public UIActivityMasterController <>4__this;

			// Token: 0x04007996 RID: 31126
			[Token(Token = "0x4007996")]
			[FieldOffset(Offset = "0x18")]
			public UIActivityPopWindowBase.CategoryTabData data;
		}

		// Token: 0x020013F8 RID: 5112
		[Token(Token = "0x20013F8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EC388", Offset = "0x10EC388")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600541C RID: 21532 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600541C")]
			[Address(RVA = "0x19561FC", Offset = "0x19561FC", VA = "0x7BBC1561FC")]
			public <>c()
			{
			}

			// Token: 0x0600541D RID: 21533 RVA: 0x000191D0 File Offset: 0x000173D0
			[Token(Token = "0x600541D")]
			[Address(RVA = "0x1956204", Offset = "0x1956204", VA = "0x7BBC156204")]
			internal bool <GetTabPriority>b__14_0(ActivityGroupDesc e)
			{
				return default(bool);
			}

			// Token: 0x04007997 RID: 31127
			[Token(Token = "0x4007997")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIActivityMasterController.<>c <>9;

			// Token: 0x04007998 RID: 31128
			[Token(Token = "0x4007998")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<ActivityGroupDesc> <>9__14_0;
		}
	}
}
