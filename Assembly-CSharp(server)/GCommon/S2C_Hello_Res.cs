using System;
using System.IO;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000FB0 RID: 4016
	[Token(Token = "0x2000FB0")]
	internal class S2C_Hello_Res : UDPClientMessageBase
	{
		// Token: 0x06003A83 RID: 14979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A83")]
		[Address(RVA = "0x24904FC", Offset = "0x24904FC", VA = "0x7BBCC904FC", Slot = "7")]
		public override void UnSerialize(BinaryReader reader)
		{
		}

		// Token: 0x06003A84 RID: 14980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A84")]
		[Address(RVA = "0x249056C", Offset = "0x249056C", VA = "0x7BBCC9056C")]
		public S2C_Hello_Res()
		{
		}

		// Token: 0x04004C0B RID: 19467
		[Token(Token = "0x4004C0B")]
		[FieldOffset(Offset = "0x18")]
		public string SessionKey;

		// Token: 0x04004C0C RID: 19468
		[Token(Token = "0x4004C0C")]
		[FieldOffset(Offset = "0x20")]
		public ushort OrderID;

		// Token: 0x04004C0D RID: 19469
		[Token(Token = "0x4004C0D")]
		[FieldOffset(Offset = "0x22")]
		public ushort RequiredID;
	}
}
