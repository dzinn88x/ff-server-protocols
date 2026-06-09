using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200125B RID: 4699
	[Token(Token = "0x200125B")]
	public class PropAnimComponent : MonoBehaviour
	{
		// Token: 0x060048C4 RID: 18628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048C4")]
		[Address(RVA = "0x174F650", Offset = "0x174F650", VA = "0x7BBBF4F650")]
		private void Awake()
		{
		}

		// Token: 0x060048C5 RID: 18629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048C5")]
		[Address(RVA = "0x174F7CC", Offset = "0x174F7CC", VA = "0x7BBBF4F7CC")]
		public void PlayAnim(int index, bool need_queue = false)
		{
		}

		// Token: 0x060048C6 RID: 18630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048C6")]
		[Address(RVA = "0x174F90C", Offset = "0x174F90C", VA = "0x7BBBF4F90C")]
		public void StopAnim()
		{
		}

		// Token: 0x060048C7 RID: 18631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048C7")]
		[Address(RVA = "0x174F9EC", Offset = "0x174F9EC", VA = "0x7BBBF4F9EC")]
		public PropAnimComponent()
		{
		}

		// Token: 0x040071B8 RID: 29112
		[Token(Token = "0x40071B8")]
		[FieldOffset(Offset = "0x18")]
		public Animation OwnedAnimation;

		// Token: 0x040071B9 RID: 29113
		[Token(Token = "0x40071B9")]
		[FieldOffset(Offset = "0x20")]
		public List<AnimationClip> AnimationClips;
	}
}
