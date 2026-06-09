using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000FB8 RID: 4024
	[Token(Token = "0x2000FB8")]
	internal class UDPMsgPacketResendInfo
	{
		// Token: 0x06003A9F RID: 15007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A9F")]
		[Address(RVA = "0x2019824", Offset = "0x2019824", VA = "0x7BBC819824")]
		public UDPMsgPacketResendInfo()
		{
		}

		// Token: 0x04004C3F RID: 19519
		[Token(Token = "0x4004C3F")]
		[FieldOffset(Offset = "0x10")]
		public int ResendCount;

		// Token: 0x04004C40 RID: 19520
		[Token(Token = "0x4004C40")]
		[FieldOffset(Offset = "0x18")]
		public double ResendTimeRatio;

		// Token: 0x04004C41 RID: 19521
		[Token(Token = "0x4004C41")]
		[FieldOffset(Offset = "0x20")]
		public List<ushort> HistorySequenceIDs;
	}
}
