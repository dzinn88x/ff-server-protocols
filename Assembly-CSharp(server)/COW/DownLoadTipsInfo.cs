using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001A1C RID: 6684
	[Token(Token = "0x2001A1C")]
	public class DownLoadTipsInfo
	{
		// Token: 0x06008BE7 RID: 35815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008BE7")]
		[Address(RVA = "0x1609310", Offset = "0x1609310", VA = "0x7BBBE09310")]
		public DownLoadTipsInfo(string info, bool need_btn_group, [Optional] Action comfirm_call_back)
		{
		}

		// Token: 0x040098AB RID: 39083
		[Token(Token = "0x40098AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Info;

		// Token: 0x040098AC RID: 39084
		[Token(Token = "0x40098AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool Need_btn_group;

		// Token: 0x040098AD RID: 39085
		[Token(Token = "0x40098AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action Comfirm_call_back;
	}
}
