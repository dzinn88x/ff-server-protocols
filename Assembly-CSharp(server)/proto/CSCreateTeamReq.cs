using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008FC RID: 2300
	[Token(Token = "0x20008FC")]
	[ProtoContract]
	public class CSCreateTeamReq
	{
		// Token: 0x0600260A RID: 9738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600260A")]
		[Address(RVA = "0x21B0D64", Offset = "0x21B0D64", VA = "0x7BBC9B0D64")]
		public CSCreateTeamReq()
		{
		}

		// Token: 0x04002AC1 RID: 10945
		[Token(Token = "0x4002AC1")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1117944", Offset = "0x1117944")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117944", Offset = "0x1117944")]
		public string team_name;

		// Token: 0x04002AC2 RID: 10946
		[Token(Token = "0x4002AC2")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117994", Offset = "0x1117994")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1117994", Offset = "0x1117994")]
		public string contact_info;

		// Token: 0x04002AC3 RID: 10947
		[Token(Token = "0x4002AC3")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11179E4", Offset = "0x11179E4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11179E4", Offset = "0x11179E4")]
		public string country_or_area;

		// Token: 0x04002AC4 RID: 10948
		[Token(Token = "0x4002AC4")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117A34", Offset = "0x1117A34")]
		public uint head_pic;

		// Token: 0x04002AC5 RID: 10949
		[Token(Token = "0x4002AC5")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117A48", Offset = "0x1117A48")]
		public uint banner_id;

		// Token: 0x04002AC6 RID: 10950
		[Token(Token = "0x4002AC6")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117A5C", Offset = "0x1117A5C")]
		public uint scale_type;
	}
}
