using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020025FF RID: 9727
	[Token(Token = "0x20025FF")]
	public class UIExtendAnimation : MonoBehaviour
	{
		// Token: 0x0600C8CD RID: 51405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8CD")]
		[Address(RVA = "0x2274014", Offset = "0x2274014", VA = "0x7BBCA74014")]
		public void OnEnable()
		{
		}

		// Token: 0x0600C8CE RID: 51406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8CE")]
		[Address(RVA = "0x2274098", Offset = "0x2274098", VA = "0x7BBCA74098")]
		public UIExtendAnimation()
		{
		}

		// Token: 0x0400FB2A RID: 64298
		[Token(Token = "0x400FB2A")]
		[FieldOffset(Offset = "0x18")]
		public Animation m_animation;

		// Token: 0x0400FB2B RID: 64299
		[Token(Token = "0x400FB2B")]
		[FieldOffset(Offset = "0x20")]
		public bool ResetAnimOnEnable;
	}
}
