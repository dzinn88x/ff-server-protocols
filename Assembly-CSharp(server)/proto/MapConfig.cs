using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005A0 RID: 1440
	[Token(Token = "0x20005A0")]
	[ProtoContract]
	public class MapConfig
	{
		// Token: 0x0600234A RID: 9034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600234A")]
		[Address(RVA = "0x21BC4F4", Offset = "0x21BC4F4", VA = "0x7BBC9BC4F4")]
		public MapConfig()
		{
		}

		// Token: 0x04001C92 RID: 7314
		[Token(Token = "0x4001C92")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11050A0", Offset = "0x11050A0")]
		public uint id;

		// Token: 0x04001C93 RID: 7315
		[Token(Token = "0x4001C93")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11050B4", Offset = "0x11050B4")]
		public uint weight;
	}
}
