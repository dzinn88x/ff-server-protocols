using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001678 RID: 5752
	[Token(Token = "0x2001678")]
	public class StandardTopTabItemViewData
	{
		// Token: 0x06006867 RID: 26727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006867")]
		[Address(RVA = "0x1B3F910", Offset = "0x1B3F910", VA = "0x7BBC33F910")]
		public StandardTopTabItemViewData(string tabName, string tabIconName, ETipsType tipType = ETipsType.None)
		{
		}

		// Token: 0x04008536 RID: 34102
		[Token(Token = "0x4008536")]
		[FieldOffset(Offset = "0x10")]
		public string tabName;

		// Token: 0x04008537 RID: 34103
		[Token(Token = "0x4008537")]
		[FieldOffset(Offset = "0x18")]
		public string tabIconName;

		// Token: 0x04008538 RID: 34104
		[Token(Token = "0x4008538")]
		[FieldOffset(Offset = "0x20")]
		public string selectIconName;

		// Token: 0x04008539 RID: 34105
		[Token(Token = "0x4008539")]
		[FieldOffset(Offset = "0x28")]
		public string tabNameColor;

		// Token: 0x0400853A RID: 34106
		[Token(Token = "0x400853A")]
		[FieldOffset(Offset = "0x30")]
		public ETipsType tipType;

		// Token: 0x0400853B RID: 34107
		[Token(Token = "0x400853B")]
		[FieldOffset(Offset = "0x38")]
		public Action onClick;

		// Token: 0x0400853C RID: 34108
		[Token(Token = "0x400853C")]
		[FieldOffset(Offset = "0x40")]
		public object extraPara;
	}
}
