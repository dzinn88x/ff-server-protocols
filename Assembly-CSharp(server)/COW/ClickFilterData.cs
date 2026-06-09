using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C1A RID: 7194
	[Token(Token = "0x2001C1A")]
	[Serializable]
	public class ClickFilterData
	{
		// Token: 0x06009C9A RID: 40090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C9A")]
		[Address(RVA = "0x14F9B48", Offset = "0x14F9B48", VA = "0x7BBBCF9B48")]
		public ClickFilterData(string key, GameObject go)
		{
		}

		// Token: 0x0400A296 RID: 41622
		[Token(Token = "0x400A296")]
		[FieldOffset(Offset = "0x10")]
		public string FilterKey;

		// Token: 0x0400A297 RID: 41623
		[Token(Token = "0x400A297")]
		[FieldOffset(Offset = "0x18")]
		public GameObject FilterGo;
	}
}
