using System;
using System.IO;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000FB1 RID: 4017
	[Token(Token = "0x2000FB1")]
	internal class UDP_Ack_Res : UDPClientMessageBase
	{
		// Token: 0x06003A85 RID: 14981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A85")]
		[Address(RVA = "0x2021878", Offset = "0x2021878", VA = "0x7BBC821878", Slot = "6")]
		public override void Serialize(BinaryWriter writer)
		{
		}

		// Token: 0x06003A86 RID: 14982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A86")]
		[Address(RVA = "0x20218EC", Offset = "0x20218EC", VA = "0x7BBC8218EC", Slot = "7")]
		public override void UnSerialize(BinaryReader reader)
		{
		}

		// Token: 0x06003A87 RID: 14983 RVA: 0x00012240 File Offset: 0x00010440
		[Token(Token = "0x6003A87")]
		[Address(RVA = "0x2021954", Offset = "0x2021954", VA = "0x7BBC821954", Slot = "8")]
		public override bool CanCache()
		{
			return default(bool);
		}

		// Token: 0x06003A88 RID: 14984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A88")]
		[Address(RVA = "0x201EEE8", Offset = "0x201EEE8", VA = "0x7BBC81EEE8")]
		public UDP_Ack_Res()
		{
		}

		// Token: 0x04004C0E RID: 19470
		[Token(Token = "0x4004C0E")]
		[FieldOffset(Offset = "0x12")]
		public ushort Ack;

		// Token: 0x04004C0F RID: 19471
		[Token(Token = "0x4004C0F")]
		[FieldOffset(Offset = "0x14")]
		public uint AckBits;
	}
}
