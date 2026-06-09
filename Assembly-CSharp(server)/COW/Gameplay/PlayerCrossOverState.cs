using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x02002AA3 RID: 10915
	[Token(Token = "0x2002AA3")]
	public class PlayerCrossOverState : StateMachineBehaviour
	{
		// Token: 0x0600EF3D RID: 61245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF3D")]
		[Address(RVA = "0x17136A4", Offset = "0x17136A4", VA = "0x7BBBF136A4", Slot = "4")]
		public override void OnStateEnter(Animator zk}jnsY, AnimatorStateInfo O}QxP\u0081x, int b^kTa\u0081L)
		{
		}

		// Token: 0x0600EF3E RID: 61246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF3E")]
		[Address(RVA = "0x17137C4", Offset = "0x17137C4", VA = "0x7BBBF137C4", Slot = "6")]
		public override void OnStateExit(Animator zk}jnsY, AnimatorStateInfo O}QxP\u0081x, int b^kTa\u0081L)
		{
		}

		// Token: 0x0600EF3F RID: 61247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF3F")]
		[Address(RVA = "0x1713810", Offset = "0x1713810", VA = "0x7BBBF13810")]
		public PlayerCrossOverState()
		{
		}

		// Token: 0x0401169A RID: 71322
		[Token(Token = "0x401169A")]
		[FieldOffset(Offset = "0x18")]
		public float CrossJumpTimeTotal;

		// Token: 0x0401169B RID: 71323
		[Token(Token = "0x401169B")]
		[FieldOffset(Offset = "0x1C")]
		public float CrossFallTimeTotal;

		// Token: 0x0401169C RID: 71324
		[Token(Token = "0x401169C")]
		[FieldOffset(Offset = "0x20")]
		private Player m_OwnerPlayer;
	}
}
