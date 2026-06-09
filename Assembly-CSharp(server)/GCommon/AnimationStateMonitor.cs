using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000EEF RID: 3823
	[Token(Token = "0x2000EEF")]
	public class AnimationStateMonitor : StateMachineBehaviour
	{
		// Token: 0x0600355E RID: 13662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600355E")]
		[Address(RVA = "0x25DA328", Offset = "0x25DA328", VA = "0x7BBCDDA328", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		// Token: 0x0600355F RID: 13663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600355F")]
		[Address(RVA = "0x25DA480", Offset = "0x25DA480", VA = "0x7BBCDDA480", Slot = "5")]
		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		// Token: 0x06003560 RID: 13664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003560")]
		[Address(RVA = "0x25DA564", Offset = "0x25DA564", VA = "0x7BBCDDA564")]
		public AnimationStateMonitor()
		{
		}

		// Token: 0x040048B5 RID: 18613
		[Token(Token = "0x40048B5")]
		[FieldOffset(Offset = "0x18")]
		public string AnimIDString;

		// Token: 0x040048B6 RID: 18614
		[Token(Token = "0x40048B6")]
		[FieldOffset(Offset = "0x20")]
		public float EndCutTime;

		// Token: 0x040048B7 RID: 18615
		[Token(Token = "0x40048B7")]
		[FieldOffset(Offset = "0x24")]
		public bool AutoTransitionToDefaultState;

		// Token: 0x040048B8 RID: 18616
		[Token(Token = "0x40048B8")]
		[FieldOffset(Offset = "0x28")]
		protected AnimationID m_AnimID;

		// Token: 0x040048B9 RID: 18617
		[Token(Token = "0x40048B9")]
		[FieldOffset(Offset = "0x30")]
		protected AnimationSystemComponent m_AnimSystem;

		// Token: 0x040048BA RID: 18618
		[Token(Token = "0x40048BA")]
		[FieldOffset(Offset = "0x38")]
		protected float m_LastTime;
	}
}
