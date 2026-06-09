using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001285 RID: 4741
	[Token(Token = "0x2001285")]
	public class PreviewCommon3dAdjust : MonoBehaviour
	{
		// Token: 0x0600498D RID: 18829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600498D")]
		[Address(RVA = "0x1748018", Offset = "0x1748018", VA = "0x7BBBF48018")]
		public PreviewCommon3dAdjust()
		{
		}

		// Token: 0x0400725F RID: 29279
		[Token(Token = "0x400725F")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 scale;

		// Token: 0x04007260 RID: 29280
		[Token(Token = "0x4007260")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 OffsetScale;

		// Token: 0x04007261 RID: 29281
		[Token(Token = "0x4007261")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 OffsetPos;

		// Token: 0x04007262 RID: 29282
		[Token(Token = "0x4007262")]
		[FieldOffset(Offset = "0x3C")]
		public float HeightY;
	}
}
