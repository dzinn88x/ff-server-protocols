using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x020026C2 RID: 9922
	[Token(Token = "0x20026C2")]
	[Serializable]
	public class AnimationClipInfo
	{
		// Token: 0x0600CD91 RID: 52625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD91")]
		[Address(RVA = "0x18C63F4", Offset = "0x18C63F4", VA = "0x7BBC0C63F4")]
		public AnimationClipInfo()
		{
		}

		// Token: 0x04010136 RID: 65846
		[Token(Token = "0x4010136")]
		[FieldOffset(Offset = "0x10")]
		public RfO}AtD mAnimType;

		// Token: 0x04010137 RID: 65847
		[Token(Token = "0x4010137")]
		[FieldOffset(Offset = "0x18")]
		public AnimationClip mAnimClip;

		// Token: 0x04010138 RID: 65848
		[Token(Token = "0x4010138")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public string mAnimName;
	}
}
