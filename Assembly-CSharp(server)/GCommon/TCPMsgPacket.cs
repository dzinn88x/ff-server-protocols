using System;
using System.IO;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000FA8 RID: 4008
	[Token(Token = "0x2000FA8")]
	public class TCPMsgPacket
	{
		// Token: 0x06003A4D RID: 14925 RVA: 0x00012078 File Offset: 0x00010278
		[Token(Token = "0x6003A4D")]
		[Address(RVA = "0x24951EC", Offset = "0x24951EC", VA = "0x7BBCC951EC")]
		public uint Unserialize(BinaryReader reader)
		{
			return 0U;
		}

		// Token: 0x06003A4E RID: 14926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A4E")]
		[Address(RVA = "0x24952DC", Offset = "0x24952DC", VA = "0x7BBCC952DC")]
		public void Serialize(BinaryWriter writer)
		{
		}

		// Token: 0x06003A4F RID: 14927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A4F")]
		[Address(RVA = "0x24953E0", Offset = "0x24953E0", VA = "0x7BBCC953E0")]
		public TCPMsgPacket()
		{
		}

		// Token: 0x04004BE2 RID: 19426
		[Token(Token = "0x4004BE2")]
		public const uint TCPMESSAGE_CMD_HEADER_SIZE = 1U;

		// Token: 0x04004BE3 RID: 19427
		[Token(Token = "0x4004BE3")]
		public const uint TCPMESSAGE_LENGTH_HEADER_SIZE = 4U;

		// Token: 0x04004BE4 RID: 19428
		[Token(Token = "0x4004BE4")]
		public const uint TCPMESSAGE_HEADER_SIZE = 5U;

		// Token: 0x04004BE5 RID: 19429
		[Token(Token = "0x4004BE5")]
		[FieldOffset(Offset = "0x10")]
		public byte Cmd;

		// Token: 0x04004BE6 RID: 19430
		[Token(Token = "0x4004BE6")]
		[FieldOffset(Offset = "0x11")]
		public byte Region;

		// Token: 0x04004BE7 RID: 19431
		[Token(Token = "0x4004BE7")]
		[FieldOffset(Offset = "0x14")]
		public int Length;

		// Token: 0x04004BE8 RID: 19432
		[Token(Token = "0x4004BE8")]
		[FieldOffset(Offset = "0x18")]
		public byte[] Data;
	}
}
