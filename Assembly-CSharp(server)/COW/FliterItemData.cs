using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020019D1 RID: 6609
	[Token(Token = "0x20019D1")]
	public class FliterItemData
	{
		// Token: 0x060087F1 RID: 34801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087F1")]
		[Address(RVA = "0x1B9A15C", Offset = "0x1B9A15C", VA = "0x7BBC39A15C")]
		public FliterItemData()
		{
		}

		// Token: 0x0400966F RID: 38511
		[Token(Token = "0x400966F")]
		[FieldOffset(Offset = "0x10")]
		public string Text;

		// Token: 0x04009670 RID: 38512
		[Token(Token = "0x4009670")]
		[FieldOffset(Offset = "0x18")]
		public string Deep_Link;

		// Token: 0x04009671 RID: 38513
		[Token(Token = "0x4009671")]
		[FieldOffset(Offset = "0x20")]
		public UILeaderBoardNewController.DeepLinkLayer DeepLinkLayer;

		// Token: 0x04009672 RID: 38514
		[Token(Token = "0x4009672")]
		[FieldOffset(Offset = "0x28")]
		public Action<object> CallBack;
	}
}
