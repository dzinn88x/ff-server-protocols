using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000F7D RID: 3965
	[Token(Token = "0x2000F7D")]
	public class NetworkByteStream
	{
		// Token: 0x060039C4 RID: 14788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039C4")]
		[Address(RVA = "0x245DC80", Offset = "0x245DC80", VA = "0x7BBCC5DC80")]
		public NetworkByteStream(int cap)
		{
		}

		// Token: 0x060039C5 RID: 14789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039C5")]
		[Address(RVA = "0x245DCF0", Offset = "0x245DCF0", VA = "0x7BBCC5DCF0")]
		public void SetValidCount(int n)
		{
		}

		// Token: 0x060039C6 RID: 14790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039C6")]
		[Address(RVA = "0x245DD4C", Offset = "0x245DD4C", VA = "0x7BBCC5DD4C")]
		public byte[] GetBytes()
		{
			return null;
		}

		// Token: 0x060039C7 RID: 14791 RVA: 0x00011E80 File Offset: 0x00010080
		[Token(Token = "0x60039C7")]
		[Address(RVA = "0x245DD54", Offset = "0x245DD54", VA = "0x7BBCC5DD54")]
		public int GetAvailableLength()
		{
			return 0;
		}

		// Token: 0x060039C8 RID: 14792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039C8")]
		[Address(RVA = "0x245DD5C", Offset = "0x245DD5C", VA = "0x7BBCC5DD5C")]
		public byte[] CopyBytes()
		{
			return null;
		}

		// Token: 0x060039C9 RID: 14793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039C9")]
		[Address(RVA = "0x245DDD8", Offset = "0x245DDD8", VA = "0x7BBCC5DDD8")]
		public byte[] CopyBytes(byte[] b)
		{
			return null;
		}

		// Token: 0x04004B4E RID: 19278
		[Token(Token = "0x4004B4E")]
		[FieldOffset(Offset = "0x10")]
		private byte[] m_RawBytes;

		// Token: 0x04004B4F RID: 19279
		[Token(Token = "0x4004B4F")]
		[FieldOffset(Offset = "0x18")]
		private int m_Length;
	}
}
