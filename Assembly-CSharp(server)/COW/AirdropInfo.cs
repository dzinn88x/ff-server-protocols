using System;
using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001FF5 RID: 8181
	[Token(Token = "0x2001FF5")]
	internal class AirdropInfo
	{
		// Token: 0x0600B5FF RID: 46591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5FF")]
		[Address(RVA = "0x154BEF0", Offset = "0x154BEF0", VA = "0x7BBBD4BEF0")]
		public AirdropInfo()
		{
		}

		// Token: 0x0400B832 RID: 47154
		[Token(Token = "0x400B832")]
		[FieldOffset(Offset = "0x10")]
		public int index;

		// Token: 0x0400B833 RID: 47155
		[Token(Token = "0x400B833")]
		[FieldOffset(Offset = "0x18")]
		public List<^yE\u007FRJO> pickups;

		// Token: 0x0400B834 RID: 47156
		[Token(Token = "0x400B834")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 position;
	}
}
