using System;
using System.IO;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000FB3 RID: 4019
	[Token(Token = "0x2000FB3")]
	internal class S2C_UDP_Ping_Res : UDPClientMessageBase
	{
		// Token: 0x06003A8C RID: 14988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A8C")]
		[Address(RVA = "0x24905D4", Offset = "0x24905D4", VA = "0x7BBCC905D4", Slot = "7")]
		public override void UnSerialize(BinaryReader reader)
		{
		}

		// Token: 0x06003A8D RID: 14989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A8D")]
		[Address(RVA = "0x2490618", Offset = "0x2490618", VA = "0x7BBCC90618", Slot = "6")]
		public override void Serialize(BinaryWriter writer)
		{
		}

		// Token: 0x06003A8E RID: 14990 RVA: 0x00012258 File Offset: 0x00010458
		[Token(Token = "0x6003A8E")]
		[Address(RVA = "0x2490658", Offset = "0x2490658", VA = "0x7BBCC90658", Slot = "8")]
		public override bool CanCache()
		{
			return default(bool);
		}

		// Token: 0x06003A8F RID: 14991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A8F")]
		[Address(RVA = "0x2490660", Offset = "0x2490660", VA = "0x7BBCC90660")]
		public S2C_UDP_Ping_Res()
		{
		}

		// Token: 0x04004C11 RID: 19473
		[Token(Token = "0x4004C11")]
		[FieldOffset(Offset = "0x14")]
		public int SendTickCount;
	}
}
