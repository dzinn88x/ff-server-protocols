using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020011B0 RID: 4528
	[Token(Token = "0x20011B0")]
	[Serializable]
	public class AnimRef : ScriptableObject
	{
		// Token: 0x0600467A RID: 18042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600467A")]
		[Address(RVA = "0x154C96C", Offset = "0x154C96C", VA = "0x7BBBD4C96C")]
		public AnimationClip GetClip0()
		{
			return null;
		}

		// Token: 0x0600467B RID: 18043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600467B")]
		[Address(RVA = "0x154C9B4", Offset = "0x154C9B4", VA = "0x7BBBD4C9B4")]
		public AnimRef()
		{
		}

		// Token: 0x040057C0 RID: 22464
		[Token(Token = "0x40057C0")]
		[FieldOffset(Offset = "0x18")]
		public AnimationClip[] Clips;
	}
}
