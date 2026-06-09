using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000649 RID: 1609
	[Token(Token = "0x2000649")]
	[ProtoContract]
	public class WeaponTypeKills
	{
		// Token: 0x060023B3 RID: 9139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B3")]
		[Address(RVA = "0x24A19B4", Offset = "0x24A19B4", VA = "0x7BBCCA19B4")]
		public WeaponTypeKills()
		{
		}

		// Token: 0x04001FC9 RID: 8137
		[Token(Token = "0x4001FC9")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11085AC", Offset = "0x11085AC")]
		public uint weapon_type;

		// Token: 0x04001FCA RID: 8138
		[Token(Token = "0x4001FCA")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11085C0", Offset = "0x11085C0")]
		public uint cnt;

		// Token: 0x04001FCB RID: 8139
		[Token(Token = "0x4001FCB")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11085D4", Offset = "0x11085D4")]
		public uint head_cnt;
	}
}
