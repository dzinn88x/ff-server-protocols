using System;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200127B RID: 4731
	[Token(Token = "0x200127B")]
	public class PlayerAliveState : StateMachineBehaviour
	{
		// Token: 0x06004948 RID: 18760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004948")]
		[Address(RVA = "0x1EFDF58", Offset = "0x1EFDF58", VA = "0x7BBC6FDF58", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		// Token: 0x06004949 RID: 18761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004949")]
		[Address(RVA = "0x1EFDFCC", Offset = "0x1EFDFCC", VA = "0x7BBC6FDFCC", Slot = "5")]
		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		// Token: 0x0600494A RID: 18762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600494A")]
		[Address(RVA = "0x1EFE154", Offset = "0x1EFE154", VA = "0x7BBC6FE154", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		// Token: 0x0600494B RID: 18763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600494B")]
		[Address(RVA = "0x1EFE164", Offset = "0x1EFE164", VA = "0x7BBC6FE164")]
		public PlayerAliveState()
		{
		}

		// Token: 0x04007229 RID: 29225
		[Token(Token = "0x4007229")]
		[FieldOffset(Offset = "0x18")]
		public float triggerTime1;

		// Token: 0x0400722A RID: 29226
		[Token(Token = "0x400722A")]
		[FieldOffset(Offset = "0x1C")]
		public float triggerTime2;

		// Token: 0x0400722B RID: 29227
		[Token(Token = "0x400722B")]
		[FieldOffset(Offset = "0x20")]
		private PlayerAudioComponent m_PlayerAudio;

		// Token: 0x0400722C RID: 29228
		[Token(Token = "0x400722C")]
		[FieldOffset(Offset = "0x28")]
		private float m_PrevTime;

		// Token: 0x0400722D RID: 29229
		[Token(Token = "0x400722D")]
		[FieldOffset(Offset = "0x2C")]
		private bool m_exit;
	}
}
