using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x02002A95 RID: 10901
	[Token(Token = "0x2002A95")]
	public class PlayerAnimEventState : StateMachineBehaviour
	{
		// Token: 0x0600EECE RID: 61134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EECE")]
		[Address(RVA = "0x170DB98", Offset = "0x170DB98", VA = "0x7BBBF0DB98", Slot = "4")]
		public override void OnStateEnter(Animator zk}jnsY, AnimatorStateInfo O}QxP\u0081x, int b^kTa\u0081L)
		{
		}

		// Token: 0x0600EECF RID: 61135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EECF")]
		[Address(RVA = "0x170DCE0", Offset = "0x170DCE0", VA = "0x7BBBF0DCE0", Slot = "5")]
		public override void OnStateUpdate(Animator zk}jnsY, AnimatorStateInfo O}QxP\u0081x, int b^kTa\u0081L)
		{
		}

		// Token: 0x0600EED0 RID: 61136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EED0")]
		[Address(RVA = "0x170E184", Offset = "0x170E184", VA = "0x7BBBF0E184", Slot = "6")]
		public override void OnStateExit(Animator zk}jnsY, AnimatorStateInfo O}QxP\u0081x, int b^kTa\u0081L)
		{
		}

		// Token: 0x0600EED1 RID: 61137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EED1")]
		[Address(RVA = "0x170E3C8", Offset = "0x170E3C8", VA = "0x7BBBF0E3C8")]
		public PlayerAnimEventState()
		{
		}

		// Token: 0x0401162B RID: 71211
		[Token(Token = "0x401162B")]
		[FieldOffset(Offset = "0x18")]
		public float triggerTime;

		// Token: 0x0401162C RID: 71212
		[Token(Token = "0x401162C")]
		[FieldOffset(Offset = "0x1C")]
		public \u0081X animEvent;

		// Token: 0x0401162D RID: 71213
		[Token(Token = "0x401162D")]
		[FieldOffset(Offset = "0x20")]
		public bool localPlayerOnly;

		// Token: 0x0401162E RID: 71214
		[Token(Token = "0x401162E")]
		[FieldOffset(Offset = "0x28")]
		private Player m_OwnerPlayer;

		// Token: 0x0401162F RID: 71215
		[Token(Token = "0x401162F")]
		[FieldOffset(Offset = "0x30")]
		private float m_PrevTime;

		// Token: 0x04011630 RID: 71216
		[Token(Token = "0x4011630")]
		[FieldOffset(Offset = "0x34")]
		private int m_Currentloop;
	}
}
