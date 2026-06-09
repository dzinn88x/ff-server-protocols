using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A68 RID: 2664
	[Token(Token = "0x2000A68")]
	[ProtoContract]
	public class DispatchSettingDesc
	{
		// Token: 0x06002772 RID: 10098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002772")]
		[Address(RVA = "0x21B974C", Offset = "0x21B974C", VA = "0x7BBC9B974C")]
		public DispatchSettingDesc()
		{
		}

		// Token: 0x040030B3 RID: 12467
		[Token(Token = "0x40030B3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121908", Offset = "0x1121908")]
		public uint activity_id;

		// Token: 0x040030B4 RID: 12468
		[Token(Token = "0x40030B4")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112191C", Offset = "0x112191C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112191C", Offset = "0x112191C")]
		public string start_time;

		// Token: 0x040030B5 RID: 12469
		[Token(Token = "0x40030B5")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112196C", Offset = "0x112196C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112196C", Offset = "0x112196C")]
		public string end_time;

		// Token: 0x040030B6 RID: 12470
		[Token(Token = "0x40030B6")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11219BC", Offset = "0x11219BC")]
		public uint max_quest_line;
	}
}
