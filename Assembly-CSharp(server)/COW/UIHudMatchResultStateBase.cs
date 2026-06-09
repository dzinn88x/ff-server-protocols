using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020015DA RID: 5594
	[Token(Token = "0x20015DA")]
	public class UIHudMatchResultStateBase
	{
		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x0600631F RID: 25375 RVA: 0x0001C950 File Offset: 0x0001AB50
		[Token(Token = "0x170008C6")]
		public EUIHudMatchResultState State
		{
			[Token(Token = "0x600631F")]
			[Address(RVA = "0x17AEE38", Offset = "0x17AEE38", VA = "0x7BBBFAEE38")]
			get
			{
				return EUIHudMatchResultState.None;
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06006320 RID: 25376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008C7")]
		public UIHudMatchResultStateMachine StateMachine
		{
			[Token(Token = "0x6006320")]
			[Address(RVA = "0x17A5BCC", Offset = "0x17A5BCC", VA = "0x7BBBFA5BCC")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006321 RID: 25377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006321")]
		[Address(RVA = "0x17A59B8", Offset = "0x17A59B8", VA = "0x7BBBFA59B8")]
		public UIHudMatchResultStateBase(UIHudMatchResultStateMachine machine, EUIHudMatchResultState state)
		{
		}

		// Token: 0x06006322 RID: 25378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006322")]
		[Address(RVA = "0x17AE9B0", Offset = "0x17AE9B0", VA = "0x7BBBFAE9B0")]
		public void Enter()
		{
		}

		// Token: 0x06006323 RID: 25379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006323")]
		[Address(RVA = "0x17AEE4C", Offset = "0x17AEE4C", VA = "0x7BBBFAEE4C")]
		public void Exit()
		{
		}

		// Token: 0x06006324 RID: 25380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006324")]
		[Address(RVA = "0x17AEE40", Offset = "0x17AEE40", VA = "0x7BBBFAEE40")]
		public void Finish()
		{
		}

		// Token: 0x06006325 RID: 25381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006325")]
		[Address(RVA = "0x17AE3E4", Offset = "0x17AE3E4", VA = "0x7BBBFAE3E4", Slot = "4")]
		protected virtual void OnInit()
		{
		}

		// Token: 0x06006326 RID: 25382 RVA: 0x0001C968 File Offset: 0x0001AB68
		[Token(Token = "0x6006326")]
		[Address(RVA = "0x17AEE58", Offset = "0x17AEE58", VA = "0x7BBBFAEE58", Slot = "5")]
		protected virtual bool OnCheck()
		{
			return default(bool);
		}

		// Token: 0x06006327 RID: 25383 RVA: 0x0001C980 File Offset: 0x0001AB80
		[Token(Token = "0x6006327")]
		[Address(RVA = "0x17AEE60", Offset = "0x17AEE60", VA = "0x7BBBFAEE60", Slot = "6")]
		protected virtual bool OnEnter()
		{
			return default(bool);
		}

		// Token: 0x06006328 RID: 25384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006328")]
		[Address(RVA = "0x17AEE68", Offset = "0x17AEE68", VA = "0x7BBBFAEE68", Slot = "7")]
		protected virtual void OnFinish()
		{
		}

		// Token: 0x06006329 RID: 25385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006329")]
		[Address(RVA = "0x17ABCD0", Offset = "0x17ABCD0", VA = "0x7BBBFABCD0", Slot = "8")]
		protected virtual void OnExit()
		{
		}

		// Token: 0x040081E1 RID: 33249
		[Token(Token = "0x40081E1")]
		[FieldOffset(Offset = "0x10")]
		private EUIHudMatchResultState m_State;

		// Token: 0x040081E2 RID: 33250
		[Token(Token = "0x40081E2")]
		[FieldOffset(Offset = "0x18")]
		private UIHudMatchResultStateMachine m_StateMachine;
	}
}
