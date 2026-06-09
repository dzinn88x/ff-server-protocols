using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000FA6 RID: 4006
	[Token(Token = "0x2000FA6")]
	public static class TCPParameters
	{
		// Token: 0x04004BD9 RID: 19417
		[Token(Token = "0x4004BD9")]
		[FieldOffset(Offset = "0x0")]
		public static double DEFAULT_DEACTIVE_TIME;

		// Token: 0x04004BDA RID: 19418
		[Token(Token = "0x4004BDA")]
		[FieldOffset(Offset = "0x8")]
		public static double BACKGROUND_DEACTIVE_TIME;

		// Token: 0x04004BDB RID: 19419
		[Token(Token = "0x4004BDB")]
		[FieldOffset(Offset = "0x10")]
		public static double KEEP_ALIVE_INTERVAL_TIME;

		// Token: 0x04004BDC RID: 19420
		[Token(Token = "0x4004BDC")]
		[FieldOffset(Offset = "0x18")]
		public static byte DEFAULT_REGION;

		// Token: 0x04004BDD RID: 19421
		[Token(Token = "0x4004BDD")]
		[FieldOffset(Offset = "0x1C")]
		public static int JOIN_TIMEOUT;

		// Token: 0x04004BDE RID: 19422
		[Token(Token = "0x4004BDE")]
		[FieldOffset(Offset = "0x20")]
		public static byte KICK_BY_SERVER_MSG_CMD;

		// Token: 0x04004BDF RID: 19423
		[Token(Token = "0x4004BDF")]
		[FieldOffset(Offset = "0x28")]
		public static TCPParameters.KickByServerMsgDeserializer KICK_BY_SERVER_MSG_DESERIALIZER;

		// Token: 0x04004BE0 RID: 19424
		[Token(Token = "0x4004BE0")]
		[FieldOffset(Offset = "0x30")]
		public static EProtoDataType PROTO_DATA_TYPE;

		// Token: 0x04004BE1 RID: 19425
		[Token(Token = "0x4004BE1")]
		[FieldOffset(Offset = "0x34")]
		public static int TCP_MTU;

		// Token: 0x02000FA7 RID: 4007
		// (Invoke) Token: 0x06003A4A RID: 14922
		[Token(Token = "0x2000FA7")]
		public delegate DisconnectedReason KickByServerMsgDeserializer(TCPMsgPacket packet);
	}
}
