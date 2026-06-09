using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020011B3 RID: 4531
	[Token(Token = "0x20011B3")]
	internal class ContainerInfo
	{
		// Token: 0x06004683 RID: 18051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004683")]
		[Address(RVA = "0x1600714", Offset = "0x1600714", VA = "0x7BBBE00714")]
		public ContainerInfo()
		{
		}

		// Token: 0x040057DD RID: 22493
		[Token(Token = "0x40057DD")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 position;

		// Token: 0x040057DE RID: 22494
		[Token(Token = "0x40057DE")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 rotation;

		// Token: 0x040057DF RID: 22495
		[Token(Token = "0x40057DF")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 scale;

		// Token: 0x040057E0 RID: 22496
		[Token(Token = "0x40057E0")]
		[FieldOffset(Offset = "0x34")]
		public int type;

		// Token: 0x040057E1 RID: 22497
		[Token(Token = "0x40057E1")]
		[FieldOffset(Offset = "0x38")]
		public float minc;

		// Token: 0x040057E2 RID: 22498
		[Token(Token = "0x40057E2")]
		[FieldOffset(Offset = "0x3C")]
		public float maxc;
	}
}
