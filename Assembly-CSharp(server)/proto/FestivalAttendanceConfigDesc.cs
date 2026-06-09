using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A2D RID: 2605
	[Token(Token = "0x2000A2D")]
	[ProtoContract]
	public class FestivalAttendanceConfigDesc
	{
		// Token: 0x06002737 RID: 10039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002737")]
		[Address(RVA = "0x21BA2DC", Offset = "0x21BA2DC", VA = "0x7BBC9BA2DC")]
		public FestivalAttendanceConfigDesc()
		{
		}

		// Token: 0x04002F88 RID: 12168
		[Token(Token = "0x4002F88")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F874", Offset = "0x111F874")]
		public uint id;

		// Token: 0x04002F89 RID: 12169
		[Token(Token = "0x4002F89")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F888", Offset = "0x111F888")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111F888", Offset = "0x111F888")]
		public string start_time;

		// Token: 0x04002F8A RID: 12170
		[Token(Token = "0x4002F8A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F8D8", Offset = "0x111F8D8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111F8D8", Offset = "0x111F8D8")]
		public string end_time;

		// Token: 0x04002F8B RID: 12171
		[Token(Token = "0x4002F8B")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F928", Offset = "0x111F928")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111F928", Offset = "0x111F928")]
		public string act_text1;

		// Token: 0x04002F8C RID: 12172
		[Token(Token = "0x4002F8C")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F978", Offset = "0x111F978")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111F978", Offset = "0x111F978")]
		public string act_text2;

		// Token: 0x04002F8D RID: 12173
		[Token(Token = "0x4002F8D")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111F9C8", Offset = "0x111F9C8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F9C8", Offset = "0x111F9C8")]
		public string act_text3;

		// Token: 0x04002F8E RID: 12174
		[Token(Token = "0x4002F8E")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FA18", Offset = "0x111FA18")]
		public uint festival_item_id1;

		// Token: 0x04002F8F RID: 12175
		[Token(Token = "0x4002F8F")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FA2C", Offset = "0x111FA2C")]
		public uint festival_item_id2;
	}
}
