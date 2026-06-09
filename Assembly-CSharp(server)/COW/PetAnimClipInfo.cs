using System;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW
{
	// Token: 0x0200115C RID: 4444
	[Token(Token = "0x200115C")]
	[Serializable]
	public class PetAnimClipInfo
	{
		// Token: 0x06004546 RID: 17734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004546")]
		[Address(RVA = "0x204E5D4", Offset = "0x204E5D4", VA = "0x7BBC84E5D4")]
		public PetAnimClipInfo()
		{
		}

		// Token: 0x0400561A RID: 22042
		[Token(Token = "0x400561A")]
		[FieldOffset(Offset = "0x10")]
		public \u0081FcWjpy AnimType;

		// Token: 0x0400561B RID: 22043
		[Token(Token = "0x400561B")]
		[FieldOffset(Offset = "0x18")]
		public AnimationClip AnimClip;
	}
}
