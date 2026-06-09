using System;
using System.IO;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000FB2 RID: 4018
	[Token(Token = "0x2000FB2")]
	internal class C2S_UDP_Ping_Req : UDPClientMessageBase
	{
		// Token: 0x06003A89 RID: 14985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A89")]
		[Address(RVA = "0x25E6D3C", Offset = "0x25E6D3C", VA = "0x7BBCDE6D3C", Slot = "6")]
		public override void Serialize(BinaryWriter writer)
		{
		}

		// Token: 0x06003A8A RID: 14986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A8A")]
		[Address(RVA = "0x25E6D7C", Offset = "0x25E6D7C", VA = "0x7BBCDE6D7C", Slot = "7")]
		public override void UnSerialize(BinaryReader reader)
		{
		}

		// Token: 0x06003A8B RID: 14987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A8B")]
		[Address(RVA = "0x25E6DC0", Offset = "0x25E6DC0", VA = "0x7BBCDE6DC0")]
		public C2S_UDP_Ping_Req()
		{
		}

		// Token: 0x04004C10 RID: 19472
		[Token(Token = "0x4004C10")]
		[FieldOffset(Offset = "0x14")]
		public int SendTickCount;
	}
}
