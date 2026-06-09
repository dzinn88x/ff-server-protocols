using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001675 RID: 5749
	[Token(Token = "0x2001675")]
	public class StandardTabItemViewData
	{
		// Token: 0x06006843 RID: 26691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006843")]
		[Address(RVA = "0x1B3F8AC", Offset = "0x1B3F8AC", VA = "0x7BBC33F8AC")]
		public StandardTabItemViewData(string tabName, ETipsType tipType = ETipsType.None, EEventTag eventTag = EEventTag.NONE, string tabSpriteName = "", [Optional] Action onClick, [Optional] object extraPara)
		{
		}

		// Token: 0x04008524 RID: 34084
		[Token(Token = "0x4008524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string tabName;

		// Token: 0x04008525 RID: 34085
		[Token(Token = "0x4008525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string tabBgName;

		// Token: 0x04008526 RID: 34086
		[Token(Token = "0x4008526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ETipsType tipType;

		// Token: 0x04008527 RID: 34087
		[Token(Token = "0x4008527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public EEventTag eventTag;

		// Token: 0x04008528 RID: 34088
		[Token(Token = "0x4008528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action onClick;

		// Token: 0x04008529 RID: 34089
		[Token(Token = "0x4008529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool hasRedPoint;

		// Token: 0x0400852A RID: 34090
		[Token(Token = "0x400852A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public object extraPara;
	}
}
