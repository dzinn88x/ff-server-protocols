using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008EE RID: 2286
	[Token(Token = "0x20008EE")]
	[ProtoContract]
	public class CSGetManualMapRewardReq
	{
		// Token: 0x060025FC RID: 9724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025FC")]
		[Address(RVA = "0x21B4ABC", Offset = "0x21B4ABC", VA = "0x7BBC9B4ABC")]
		public CSGetManualMapRewardReq()
		{
		}

		// Token: 0x04002A98 RID: 10904
		[Token(Token = "0x4002A98")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11174BC", Offset = "0x11174BC")]
		public uint map_id;
	}
}
