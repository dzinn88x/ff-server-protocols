using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001751 RID: 5969
	[Token(Token = "0x2001751")]
	public class CommonPopMenuData
	{
		// Token: 0x06007055 RID: 28757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007055")]
		[Address(RVA = "0x15FC444", Offset = "0x15FC444", VA = "0x7BBBDFC444")]
		public CommonPopMenuData(string text = "", [Optional] Action<object> callback, [Optional] object ext, bool enable = true)
		{
		}

		// Token: 0x04008A31 RID: 35377
		[Token(Token = "0x4008A31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Text;

		// Token: 0x04008A32 RID: 35378
		[Token(Token = "0x4008A32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action<object> Callback;

		// Token: 0x04008A33 RID: 35379
		[Token(Token = "0x4008A33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public object Ext;

		// Token: 0x04008A34 RID: 35380
		[Token(Token = "0x4008A34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool Enabled;
	}
}
