using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009FF RID: 2559
	[Token(Token = "0x20009FF")]
	[ProtoContract]
	public class EventMissionDesc
	{
		// Token: 0x06002709 RID: 9993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002709")]
		[Address(RVA = "0x21B9C28", Offset = "0x21B9C28", VA = "0x7BBC9B9C28")]
		public EventMissionDesc()
		{
		}

		// Token: 0x04002E85 RID: 11909
		[Token(Token = "0x4002E85")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111D754", Offset = "0x111D754")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D754", Offset = "0x111D754")]
		public string mission_name;

		// Token: 0x04002E86 RID: 11910
		[Token(Token = "0x4002E86")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D7A4", Offset = "0x111D7A4")]
		public EActivity.EventMissionType mission_type;

		// Token: 0x04002E87 RID: 11911
		[Token(Token = "0x4002E87")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D7B8", Offset = "0x111D7B8")]
		public uint mission_id;
	}
}
