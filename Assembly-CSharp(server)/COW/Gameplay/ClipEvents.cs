using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.Gameplay
{
	// Token: 0x0200269C RID: 9884
	[Token(Token = "0x200269C")]
	[Serializable]
	public class ClipEvents
	{
		// Token: 0x0600CCB8 RID: 52408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCB8")]
		[Address(RVA = "0x1B7DBB8", Offset = "0x1B7DBB8", VA = "0x7BBC37DBB8")]
		public ClipEvents()
		{
		}

		// Token: 0x04010089 RID: 65673
		[Token(Token = "0x4010089")]
		[FieldOffset(Offset = "0x10")]
		public AnimationClip m_Clip;

		// Token: 0x0401008A RID: 65674
		[Token(Token = "0x401008A")]
		[FieldOffset(Offset = "0x18")]
		public List<ClipEvent> m_Events;
	}
}
