using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001ABB RID: 6843
	[Token(Token = "0x2001ABB")]
	public class UIPaymentSpecialStoreItemData
	{
		// Token: 0x0600906D RID: 36973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600906D")]
		[Address(RVA = "0x1F2DF8C", Offset = "0x1F2DF8C", VA = "0x7BBC72DF8C")]
		public UIPaymentSpecialStoreItemData(SpecialStoreDesc special, bool redPoint = false, [Optional] Action<EStore.PbwActivityType> onClick)
		{
		}

		// Token: 0x04009C17 RID: 39959
		[Token(Token = "0x4009C17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpecialStoreDesc specialStoreDesc;

		// Token: 0x04009C18 RID: 39960
		[Token(Token = "0x4009C18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action<EStore.PbwActivityType> onClick;

		// Token: 0x04009C19 RID: 39961
		[Token(Token = "0x4009C19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool hasRedPoint;
	}
}
