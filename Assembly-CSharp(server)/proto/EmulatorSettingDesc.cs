using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A10 RID: 2576
	[Token(Token = "0x2000A10")]
	[ProtoContract]
	public class EmulatorSettingDesc
	{
		// Token: 0x0600271A RID: 10010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600271A")]
		[Address(RVA = "0x21B9B84", Offset = "0x21B9B84", VA = "0x7BBC9B9B84")]
		public EmulatorSettingDesc()
		{
		}

		// Token: 0x04002F08 RID: 12040
		[Token(Token = "0x4002F08")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E758", Offset = "0x111E758")]
		public bool is_open;

		// Token: 0x04002F09 RID: 12041
		[Token(Token = "0x4002F09")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E76C", Offset = "0x111E76C")]
		public uint limit_score;

		// Token: 0x04002F0A RID: 12042
		[Token(Token = "0x4002F0A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E780", Offset = "0x111E780")]
		public uint match_mode;
	}
}
