using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001291 RID: 4753
	[Token(Token = "0x2001291")]
	public class PlayDoubleWeaponParams
	{
		// Token: 0x060049A2 RID: 18850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049A2")]
		[Address(RVA = "0x1EFDEDC", Offset = "0x1EFDEDC", VA = "0x7BBC6FDEDC")]
		public PlayDoubleWeaponParams(Vector3 _offset, Vector3 _rotate, Vector3 _scale)
		{
		}

		// Token: 0x04007284 RID: 29316
		[Token(Token = "0x4007284")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 offset;

		// Token: 0x04007285 RID: 29317
		[Token(Token = "0x4007285")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 rotate;

		// Token: 0x04007286 RID: 29318
		[Token(Token = "0x4007286")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 scale;
	}
}
