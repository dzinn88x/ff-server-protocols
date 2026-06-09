using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A72 RID: 2674
	[Token(Token = "0x2000A72")]
	[ProtoContract]
	public class WeaponTableDesc
	{
		// Token: 0x0600277C RID: 10108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600277C")]
		[Address(RVA = "0x24A19AC", Offset = "0x24A19AC", VA = "0x7BBCCA19AC")]
		public WeaponTableDesc()
		{
		}

		// Token: 0x040030FD RID: 12541
		[Token(Token = "0x40030FD")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122164", Offset = "0x1122164")]
		public uint id;

		// Token: 0x040030FE RID: 12542
		[Token(Token = "0x40030FE")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122178", Offset = "0x1122178")]
		public uint type;
	}
}
