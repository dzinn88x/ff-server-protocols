using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02001031 RID: 4145
	[Token(Token = "0x2001031")]
	public class UIMenuItemData
	{
		// Token: 0x06003ED1 RID: 16081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ED1")]
		[Address(RVA = "0x20301B8", Offset = "0x20301B8", VA = "0x7BBC8301B8")]
		public UIMenuItemData()
		{
		}

		// Token: 0x04004F12 RID: 20242
		[Token(Token = "0x4004F12")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04004F13 RID: 20243
		[Token(Token = "0x4004F13")]
		[FieldOffset(Offset = "0x18")]
		public string title;

		// Token: 0x04004F14 RID: 20244
		[Token(Token = "0x4004F14")]
		[FieldOffset(Offset = "0x20")]
		public Action selectedCallback;

		// Token: 0x04004F15 RID: 20245
		[Token(Token = "0x4004F15")]
		[FieldOffset(Offset = "0x28")]
		public Action unSelectedCallback;

		// Token: 0x04004F16 RID: 20246
		[Token(Token = "0x4004F16")]
		[FieldOffset(Offset = "0x30")]
		public Action<GameObject[]> externInitCallback;
	}
}
