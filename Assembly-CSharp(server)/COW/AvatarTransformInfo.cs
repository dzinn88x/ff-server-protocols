using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001294 RID: 4756
	[Token(Token = "0x2001294")]
	public class AvatarTransformInfo
	{
		// Token: 0x060049A5 RID: 18853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049A5")]
		[Address(RVA = "0x21C2D18", Offset = "0x21C2D18", VA = "0x7BBC9C2D18")]
		public AvatarTransformInfo()
		{
		}

		// Token: 0x04007291 RID: 29329
		[Token(Token = "0x4007291")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 avatarPos;

		// Token: 0x04007292 RID: 29330
		[Token(Token = "0x4007292")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 avatarScale;

		// Token: 0x04007293 RID: 29331
		[Token(Token = "0x4007293")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 avatarRotation;
	}
}
