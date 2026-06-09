using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x02002A97 RID: 10903
	[Token(Token = "0x2002A97")]
	public class PlayerAnimEventStateLobby : StateMachineBehaviour
	{
		// Token: 0x0600EED2 RID: 61138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EED2")]
		[Address(RVA = "0x170E3D0", Offset = "0x170E3D0", VA = "0x7BBBF0E3D0", Slot = "4")]
		public override void OnStateEnter(Animator zk}jnsY, AnimatorStateInfo O}QxP\u0081x, int b^kTa\u0081L)
		{
		}

		// Token: 0x0600EED3 RID: 61139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EED3")]
		[Address(RVA = "0x170E4FC", Offset = "0x170E4FC", VA = "0x7BBBF0E4FC", Slot = "5")]
		public override void OnStateUpdate(Animator zk}jnsY, AnimatorStateInfo O}QxP\u0081x, int b^kTa\u0081L)
		{
		}

		// Token: 0x0600EED4 RID: 61140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EED4")]
		[Address(RVA = "0x170E620", Offset = "0x170E620", VA = "0x7BBBF0E620", Slot = "6")]
		public override void OnStateExit(Animator zk}jnsY, AnimatorStateInfo O}QxP\u0081x, int b^kTa\u0081L)
		{
		}

		// Token: 0x0600EED5 RID: 61141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EED5")]
		[Address(RVA = "0x170E740", Offset = "0x170E740", VA = "0x7BBBF0E740")]
		public PlayerAnimEventStateLobby()
		{
		}

		// Token: 0x04011637 RID: 71223
		[Token(Token = "0x4011637")]
		[FieldOffset(Offset = "0x18")]
		public float triggerTime;

		// Token: 0x04011638 RID: 71224
		[Token(Token = "0x4011638")]
		[FieldOffset(Offset = "0x1C")]
		public rp|ntBG animEvent;

		// Token: 0x04011639 RID: 71225
		[Token(Token = "0x4011639")]
		[FieldOffset(Offset = "0x20")]
		private UIMaleAvatar m_OwnerPlayer;

		// Token: 0x0401163A RID: 71226
		[Token(Token = "0x401163A")]
		[FieldOffset(Offset = "0x28")]
		private float m_PrevTime;
	}
}
