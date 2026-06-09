using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001740 RID: 5952
	[Token(Token = "0x2001740")]
	public class CodeInputPopupData
	{
		// Token: 0x06006FF2 RID: 28658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FF2")]
		[Address(RVA = "0x14FAD14", Offset = "0x14FAD14", VA = "0x7BBBCFAD14")]
		public CodeInputPopupData(string popwindowTitle = "", string title = "", [Optional] Action<object> callback, int codeNumber = 6, [Optional] object ext)
		{
		}

		// Token: 0x040089E7 RID: 35303
		[Token(Token = "0x40089E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PopWindowTitle;

		// Token: 0x040089E8 RID: 35304
		[Token(Token = "0x40089E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Title;

		// Token: 0x040089E9 RID: 35305
		[Token(Token = "0x40089E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<object> Callback;

		// Token: 0x040089EA RID: 35306
		[Token(Token = "0x40089EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int CodeNumber;

		// Token: 0x040089EB RID: 35307
		[Token(Token = "0x40089EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public object Ext;
	}
}
