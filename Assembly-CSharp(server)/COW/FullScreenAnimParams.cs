using System;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001293 RID: 4755
	[Token(Token = "0x2001293")]
	public class FullScreenAnimParams
	{
		// Token: 0x060049A4 RID: 18852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049A4")]
		[Address(RVA = "0x1867CF8", Offset = "0x1867CF8", VA = "0x7BBC067CF8")]
		public FullScreenAnimParams()
		{
		}

		// Token: 0x0400728D RID: 29325
		[Token(Token = "0x400728D")]
		[FieldOffset(Offset = "0x10")]
		public FullscreenCgDesc animData;

		// Token: 0x0400728E RID: 29326
		[Token(Token = "0x400728E")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 cameraRotation;

		// Token: 0x0400728F RID: 29327
		[Token(Token = "0x400728F")]
		[FieldOffset(Offset = "0x28")]
		public AvatarTransformInfo avatarInfoA;

		// Token: 0x04007290 RID: 29328
		[Token(Token = "0x4007290")]
		[FieldOffset(Offset = "0x30")]
		public AvatarTransformInfo avatarInfoB;
	}
}
