using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000FB7 RID: 4023
	[Token(Token = "0x2000FB7")]
	internal class UDPMsgPacketTrackingData
	{
		// Token: 0x06003A9E RID: 15006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A9E")]
		[Address(RVA = "0x201982C", Offset = "0x201982C", VA = "0x7BBC81982C")]
		public UDPMsgPacketTrackingData()
		{
		}

		// Token: 0x04004C3B RID: 19515
		[Token(Token = "0x4004C3B")]
		[FieldOffset(Offset = "0x10")]
		public ushort SequenceID;

		// Token: 0x04004C3C RID: 19516
		[Token(Token = "0x4004C3C")]
		[FieldOffset(Offset = "0x18")]
		public double Time;

		// Token: 0x04004C3D RID: 19517
		[Token(Token = "0x4004C3D")]
		[FieldOffset(Offset = "0x20")]
		public double Timeout;

		// Token: 0x04004C3E RID: 19518
		[Token(Token = "0x4004C3E")]
		[FieldOffset(Offset = "0x28")]
		public UDPMsgPacket PendingMsg;
	}
}
