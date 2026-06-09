using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001292 RID: 4754
	[Token(Token = "0x2001292")]
	public class PreviewAvatarParams
	{
		// Token: 0x060049A3 RID: 18851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049A3")]
		[Address(RVA = "0x17473DC", Offset = "0x17473DC", VA = "0x7BBBF473DC")]
		public PreviewAvatarParams()
		{
		}

		// Token: 0x04007287 RID: 29319
		[Token(Token = "0x4007287")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 scale;

		// Token: 0x04007288 RID: 29320
		[Token(Token = "0x4007288")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 pos;

		// Token: 0x04007289 RID: 29321
		[Token(Token = "0x4007289")]
		[FieldOffset(Offset = "0x28")]
		public PreViewManager.AvatarType avatartype;

		// Token: 0x0400728A RID: 29322
		[Token(Token = "0x400728A")]
		[FieldOffset(Offset = "0x2C")]
		public Vector4 boostavatar;

		// Token: 0x0400728B RID: 29323
		[Token(Token = "0x400728B")]
		[FieldOffset(Offset = "0x3C")]
		public bool PlayPose;

		// Token: 0x0400728C RID: 29324
		[Token(Token = "0x400728C")]
		[FieldOffset(Offset = "0x3D")]
		public bool NeedStopEffect;
	}
}
