using System;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200127C RID: 4732
	[Token(Token = "0x200127C")]
	public class PlayerSwimState : StateMachineBehaviour
	{
		// Token: 0x0600494C RID: 18764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600494C")]
		[Address(RVA = "0x1EFFD50", Offset = "0x1EFFD50", VA = "0x7BBC6FFD50", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		// Token: 0x0600494D RID: 18765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600494D")]
		[Address(RVA = "0x1EFFDC0", Offset = "0x1EFFDC0", VA = "0x7BBC6FFDC0", Slot = "5")]
		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		// Token: 0x0600494E RID: 18766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600494E")]
		[Address(RVA = "0x1EFFEEC", Offset = "0x1EFFEEC", VA = "0x7BBC6FFEEC", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		// Token: 0x0600494F RID: 18767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600494F")]
		[Address(RVA = "0x1EFFEF4", Offset = "0x1EFFEF4", VA = "0x7BBC6FFEF4")]
		public PlayerSwimState()
		{
		}

		// Token: 0x0400722E RID: 29230
		[Token(Token = "0x400722E")]
		[FieldOffset(Offset = "0x18")]
		public float triggerTime1;

		// Token: 0x0400722F RID: 29231
		[Token(Token = "0x400722F")]
		[FieldOffset(Offset = "0x1C")]
		public float triggerTime2;

		// Token: 0x04007230 RID: 29232
		[Token(Token = "0x4007230")]
		[FieldOffset(Offset = "0x20")]
		private PlayerAudioComponent m_PlayerAudio;

		// Token: 0x04007231 RID: 29233
		[Token(Token = "0x4007231")]
		[FieldOffset(Offset = "0x28")]
		private float m_PrevTime;
	}
}
