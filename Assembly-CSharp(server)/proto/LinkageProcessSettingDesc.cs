using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AF9 RID: 2809
	[Token(Token = "0x2000AF9")]
	[ProtoContract]
	public class LinkageProcessSettingDesc
	{
		// Token: 0x06002801 RID: 10241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002801")]
		[Address(RVA = "0x21BBC48", Offset = "0x21BBC48", VA = "0x7BBC9BBC48")]
		public LinkageProcessSettingDesc()
		{
		}

		// Token: 0x040034F5 RID: 13557
		[Token(Token = "0x40034F5")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112993C", Offset = "0x112993C")]
		public uint process_id;

		// Token: 0x040034F6 RID: 13558
		[Token(Token = "0x40034F6")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129950", Offset = "0x1129950")]
		public ulong start_value;

		// Token: 0x040034F7 RID: 13559
		[Token(Token = "0x40034F7")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129964", Offset = "0x1129964")]
		public ulong end_value;

		// Token: 0x040034F8 RID: 13560
		[Token(Token = "0x40034F8")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129978", Offset = "0x1129978")]
		public uint time_span;
	}
}
