using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020019D2 RID: 6610
	[Token(Token = "0x20019D2")]
	public class FliterData
	{
		// Token: 0x060087F2 RID: 34802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087F2")]
		[Address(RVA = "0x1B9A154", Offset = "0x1B9A154", VA = "0x7BBC39A154")]
		public FliterData()
		{
		}

		// Token: 0x04009673 RID: 38515
		[Token(Token = "0x4009673")]
		[FieldOffset(Offset = "0x10")]
		public string DefaultText;

		// Token: 0x04009674 RID: 38516
		[Token(Token = "0x4009674")]
		[FieldOffset(Offset = "0x18")]
		public List<FliterItemData> FliterList;

		// Token: 0x04009675 RID: 38517
		[Token(Token = "0x4009675")]
		[FieldOffset(Offset = "0x20")]
		public UILeaderBoardNewController.DeepLinkLayer DeepLinkLayer;
	}
}
