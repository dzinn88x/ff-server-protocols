using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000F80 RID: 3968
	[Token(Token = "0x2000F80")]
	public class TeaEncTempBuffer
	{
		// Token: 0x060039D3 RID: 14803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039D3")]
		[Address(RVA = "0x2498F00", Offset = "0x2498F00", VA = "0x7BBCC98F00")]
		public TeaEncTempBuffer()
		{
		}

		// Token: 0x04004B57 RID: 19287
		[Token(Token = "0x4004B57")]
		[FieldOffset(Offset = "0x10")]
		public byte[] enc_src_buf;

		// Token: 0x04004B58 RID: 19288
		[Token(Token = "0x4004B58")]
		[FieldOffset(Offset = "0x18")]
		public byte[] enc_iv_plain;

		// Token: 0x04004B59 RID: 19289
		[Token(Token = "0x4004B59")]
		[FieldOffset(Offset = "0x20")]
		public byte[] enc_iv_crypt;

		// Token: 0x04004B5A RID: 19290
		[Token(Token = "0x4004B5A")]
		[FieldOffset(Offset = "0x28")]
		public uint[] enc_k;
	}
}
