using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000F7F RID: 3967
	[Token(Token = "0x2000F7F")]
	public class TeaDecTempBuffer
	{
		// Token: 0x060039D2 RID: 14802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039D2")]
		[Address(RVA = "0x2498E58", Offset = "0x2498E58", VA = "0x7BBCC98E58")]
		public TeaDecTempBuffer()
		{
		}

		// Token: 0x04004B52 RID: 19282
		[Token(Token = "0x4004B52")]
		[FieldOffset(Offset = "0x10")]
		public byte[] dec_dest_buff;

		// Token: 0x04004B53 RID: 19283
		[Token(Token = "0x4004B53")]
		[FieldOffset(Offset = "0x18")]
		public byte[] dec_zero_buff;

		// Token: 0x04004B54 RID: 19284
		[Token(Token = "0x4004B54")]
		[FieldOffset(Offset = "0x20")]
		public byte[] dec_iv_pre;

		// Token: 0x04004B55 RID: 19285
		[Token(Token = "0x4004B55")]
		[FieldOffset(Offset = "0x28")]
		public byte[] dec_iv_cur;

		// Token: 0x04004B56 RID: 19286
		[Token(Token = "0x4004B56")]
		[FieldOffset(Offset = "0x30")]
		public uint[] dec_k;
	}
}
