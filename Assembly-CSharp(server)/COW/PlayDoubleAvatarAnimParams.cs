using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200128F RID: 4751
	[Token(Token = "0x200128F")]
	public class PlayDoubleAvatarAnimParams
	{
		// Token: 0x060049A0 RID: 18848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049A0")]
		[Address(RVA = "0x1EFDDF4", Offset = "0x1EFDDF4", VA = "0x7BBC6FDDF4")]
		public PlayDoubleAvatarAnimParams()
		{
		}

		// Token: 0x0400727C RID: 29308
		[Token(Token = "0x400727C")]
		[FieldOffset(Offset = "0x10")]
		public PlayDoubleAvatarAnimParams.AvatarAnimParams avatarAnimParmsA;

		// Token: 0x0400727D RID: 29309
		[Token(Token = "0x400727D")]
		[FieldOffset(Offset = "0x18")]
		public PlayDoubleAvatarAnimParams.AvatarAnimParams avatarAnimParmsB;

		// Token: 0x0400727E RID: 29310
		[Token(Token = "0x400727E")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 cameraRotation;

		// Token: 0x02001290 RID: 4752
		[Token(Token = "0x2001290")]
		public class AvatarAnimParams
		{
			// Token: 0x060049A1 RID: 18849 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60049A1")]
			[Address(RVA = "0x1EFDE74", Offset = "0x1EFDE74", VA = "0x7BBC6FDE74")]
			public AvatarAnimParams()
			{
			}

			// Token: 0x0400727F RID: 29311
			[Token(Token = "0x400727F")]
			[FieldOffset(Offset = "0x10")]
			public List<uint> clothIDList;

			// Token: 0x04007280 RID: 29312
			[Token(Token = "0x4007280")]
			[FieldOffset(Offset = "0x18")]
			public int animID;

			// Token: 0x04007281 RID: 29313
			[Token(Token = "0x4007281")]
			[FieldOffset(Offset = "0x20")]
			public string specialAnim;

			// Token: 0x04007282 RID: 29314
			[Token(Token = "0x4007282")]
			[FieldOffset(Offset = "0x28")]
			public string idleAnim;

			// Token: 0x04007283 RID: 29315
			[Token(Token = "0x4007283")]
			[FieldOffset(Offset = "0x30")]
			public AvatarTransformInfo avatarInfo;
		}
	}
}
