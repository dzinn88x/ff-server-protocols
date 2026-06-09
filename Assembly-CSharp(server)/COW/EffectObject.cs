using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200143F RID: 5183
	[Token(Token = "0x200143F")]
	public struct EffectObject
	{
		// Token: 0x04007AD4 RID: 31444
		[Token(Token = "0x4007AD4")]
		[FieldOffset(Offset = "0x0")]
		public EEffectType effectType;

		// Token: 0x04007AD5 RID: 31445
		[Token(Token = "0x4007AD5")]
		[FieldOffset(Offset = "0x4")]
		public bool isLoop;

		// Token: 0x04007AD6 RID: 31446
		[Token(Token = "0x4007AD6")]
		[FieldOffset(Offset = "0x8")]
		public GameObject gameObject;
	}
}
