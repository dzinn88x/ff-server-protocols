using System;
using System.IO;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020012B6 RID: 4790
	[Token(Token = "0x20012B6")]
	internal class ReplayData
	{
		// Token: 0x06004B0E RID: 19214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B0E")]
		[Address(RVA = "0x17596C0", Offset = "0x17596C0", VA = "0x7BBBF596C0")]
		public void Serialize(BinaryWriter writer)
		{
		}

		// Token: 0x06004B0F RID: 19215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B0F")]
		[Address(RVA = "0x17597C4", Offset = "0x17597C4", VA = "0x7BBBF597C4")]
		public void Deserialize(BinaryReader reader)
		{
		}

		// Token: 0x06004B10 RID: 19216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B10")]
		[Address(RVA = "0x17598F0", Offset = "0x17598F0", VA = "0x7BBBF598F0")]
		public ReplayData Clone()
		{
			return null;
		}

		// Token: 0x06004B11 RID: 19217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B11")]
		[Address(RVA = "0x1759A58", Offset = "0x1759A58", VA = "0x7BBBF59A58")]
		public static implicit operator ReplayData(UDPMsgPacket packet)
		{
			return null;
		}

		// Token: 0x06004B12 RID: 19218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B12")]
		[Address(RVA = "0x1759BA8", Offset = "0x1759BA8", VA = "0x7BBBF59BA8")]
		public static implicit operator UDPMsgPacket(ReplayData replay)
		{
			return null;
		}

		// Token: 0x06004B13 RID: 19219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B13")]
		[Address(RVA = "0x1759A50", Offset = "0x1759A50", VA = "0x7BBBF59A50")]
		public ReplayData()
		{
		}

		// Token: 0x04007343 RID: 29507
		[Token(Token = "0x4007343")]
		[FieldOffset(Offset = "0x10")]
		public float Time;

		// Token: 0x04007344 RID: 29508
		[Token(Token = "0x4007344")]
		[FieldOffset(Offset = "0x14")]
		public byte SendOption;

		// Token: 0x04007345 RID: 29509
		[Token(Token = "0x4007345")]
		[FieldOffset(Offset = "0x16")]
		public ushort Cmd;

		// Token: 0x04007346 RID: 29510
		[Token(Token = "0x4007346")]
		[FieldOffset(Offset = "0x18")]
		public ushort Length;

		// Token: 0x04007347 RID: 29511
		[Token(Token = "0x4007347")]
		[FieldOffset(Offset = "0x20")]
		public byte[] Data;
	}
}
