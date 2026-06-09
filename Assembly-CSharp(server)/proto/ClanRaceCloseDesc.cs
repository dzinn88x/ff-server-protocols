using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A44 RID: 2628
	[Token(Token = "0x2000A44")]
	[ProtoContract]
	public class ClanRaceCloseDesc
	{
		// Token: 0x0600274E RID: 10062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600274E")]
		[Address(RVA = "0x21B8958", Offset = "0x21B8958", VA = "0x7BBC9B8958")]
		public ClanRaceCloseDesc()
		{
		}

		// Token: 0x04002FEB RID: 12267
		[Token(Token = "0x4002FEB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120468", Offset = "0x1120468")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1120468", Offset = "0x1120468")]
		public string region;

		// Token: 0x04002FEC RID: 12268
		[Token(Token = "0x4002FEC")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11204B8", Offset = "0x11204B8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11204B8", Offset = "0x11204B8")]
		public string start_time;

		// Token: 0x04002FED RID: 12269
		[Token(Token = "0x4002FED")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1120508", Offset = "0x1120508")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120508", Offset = "0x1120508")]
		public string end_time;
	}
}
