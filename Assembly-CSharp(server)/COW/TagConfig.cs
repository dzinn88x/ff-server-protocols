using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001D3D RID: 7485
	[Token(Token = "0x2001D3D")]
	public class TagConfig
	{
		// Token: 0x0600A2BA RID: 41658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2BA")]
		[Address(RVA = "0x1B42E70", Offset = "0x1B42E70", VA = "0x7BBC342E70")]
		public TagConfig(Color color, string text)
		{
		}

		// Token: 0x0400A957 RID: 43351
		[Token(Token = "0x400A957")]
		[FieldOffset(Offset = "0x10")]
		public Color color;

		// Token: 0x0400A958 RID: 43352
		[Token(Token = "0x400A958")]
		[FieldOffset(Offset = "0x20")]
		public string text;
	}
}
