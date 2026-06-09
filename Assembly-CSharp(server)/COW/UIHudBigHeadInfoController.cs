using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200187B RID: 6267
	[Token(Token = "0x200187B")]
	public class UIHudBigHeadInfoController : UIBaseController
	{
		// Token: 0x06007BDE RID: 31710 RVA: 0x000220B0 File Offset: 0x000202B0
		[Token(Token = "0x6007BDE")]
		[Address(RVA = "0x1894188", Offset = "0x1894188", VA = "0x7BBC094188")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007BDF RID: 31711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BDF")]
		[Address(RVA = "0x18941D8", Offset = "0x18941D8", VA = "0x7BBC0941D8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007BE0 RID: 31712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BE0")]
		[Address(RVA = "0x18947AC", Offset = "0x18947AC", VA = "0x7BBC0947AC", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06007BE1 RID: 31713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BE1")]
		[Address(RVA = "0x18947D8", Offset = "0x18947D8", VA = "0x7BBC0947D8")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1142868", Offset = "0x1142868")]
		private IEnumerator WaitAndShowTutorial()
		{
			return null;
		}

		// Token: 0x06007BE2 RID: 31714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BE2")]
		[Address(RVA = "0x1894878", Offset = "0x1894878", VA = "0x7BBC094878", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007BE3 RID: 31715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BE3")]
		[Address(RVA = "0x1894998", Offset = "0x1894998", VA = "0x7BBC094998")]
		private void OnScoreChange(object[] data)
		{
		}

		// Token: 0x06007BE4 RID: 31716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BE4")]
		[Address(RVA = "0x1894B60", Offset = "0x1894B60", VA = "0x7BBC094B60")]
		private void OnLeadingScoreChange(object[] data)
		{
		}

		// Token: 0x06007BE5 RID: 31717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BE5")]
		[Address(RVA = "0x1894C30", Offset = "0x1894C30", VA = "0x7BBC094C30")]
		private void Update()
		{
		}

		// Token: 0x06007BE6 RID: 31718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BE6")]
		[Address(RVA = "0x18943A8", Offset = "0x18943A8", VA = "0x7BBC0943A8")]
		private void UpdateTime()
		{
		}

		// Token: 0x06007BE7 RID: 31719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BE7")]
		[Address(RVA = "0x18946B0", Offset = "0x18946B0", VA = "0x7BBC0946B0")]
		private void UpdateScore(int score)
		{
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06007BE8 RID: 31720 RVA: 0x000220C8 File Offset: 0x000202C8
		[Token(Token = "0x17000986")]
		private int CurrentScore
		{
			[Token(Token = "0x6007BE8")]
			[Address(RVA = "0x18945EC", Offset = "0x18945EC", VA = "0x7BBC0945EC")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06007BE9 RID: 31721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BE9")]
		[Address(RVA = "0x1894CE8", Offset = "0x1894CE8", VA = "0x7BBC094CE8")]
		public UIHudBigHeadInfoController()
		{
		}

		// Token: 0x04009026 RID: 36902
		[Token(Token = "0x4009026")]
		[FieldOffset(Offset = "0x58")]
		private UIHudBigHeadInfoView m_View;

		// Token: 0x04009027 RID: 36903
		[Token(Token = "0x4009027")]
		[FieldOffset(Offset = "0x60")]
		private StringBuilder m_TimeString;

		// Token: 0x04009028 RID: 36904
		[Token(Token = "0x4009028")]
		[FieldOffset(Offset = "0x68")]
		private StringBuilder m_ScoreString;

		// Token: 0x04009029 RID: 36905
		[Token(Token = "0x4009029")]
		[FieldOffset(Offset = "0x70")]
		private int m_TotalScore;

		// Token: 0x0400902A RID: 36906
		[Token(Token = "0x400902A")]
		[FieldOffset(Offset = "0x74")]
		private int m_TotalTime;

		// Token: 0x0400902B RID: 36907
		[Token(Token = "0x400902B")]
		[FieldOffset(Offset = "0x78")]
		private int m_Secs;

		// Token: 0x0200187C RID: 6268
		[Token(Token = "0x200187C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F430C", Offset = "0x10F430C")]
		private sealed class <WaitAndShowTutorial>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06007BEA RID: 31722 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BEA")]
			[Address(RVA = "0x189484C", Offset = "0x189484C", VA = "0x7BBC09484C")]
			[DebuggerHidden]
			public <WaitAndShowTutorial>d__9(int <>1__state)
			{
			}

			// Token: 0x06007BEB RID: 31723 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BEB")]
			[Address(RVA = "0x1894CF0", Offset = "0x1894CF0", VA = "0x7BBC094CF0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06007BEC RID: 31724 RVA: 0x000220E0 File Offset: 0x000202E0
			[Token(Token = "0x6007BEC")]
			[Address(RVA = "0x1894CF4", Offset = "0x1894CF4", VA = "0x7BBC094CF4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000987 RID: 2439
			// (get) Token: 0x06007BED RID: 31725 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000987")]
			private object Current
			{
				[Token(Token = "0x6007BED")]
				[Address(RVA = "0x1894DFC", Offset = "0x1894DFC", VA = "0x7BBC094DFC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06007BEE RID: 31726 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BEE")]
			[Address(RVA = "0x1894E04", Offset = "0x1894E04", VA = "0x7BBC094E04", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000988 RID: 2440
			// (get) Token: 0x06007BEF RID: 31727 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000988")]
			private object Current
			{
				[Token(Token = "0x6007BEF")]
				[Address(RVA = "0x1894E6C", Offset = "0x1894E6C", VA = "0x7BBC094E6C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400902C RID: 36908
			[Token(Token = "0x400902C")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400902D RID: 36909
			[Token(Token = "0x400902D")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400902E RID: 36910
			[Token(Token = "0x400902E")]
			[FieldOffset(Offset = "0x20")]
			public UIHudBigHeadInfoController <>4__this;
		}
	}
}
