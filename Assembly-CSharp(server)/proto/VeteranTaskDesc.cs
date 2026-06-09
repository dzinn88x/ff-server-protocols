using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A2B RID: 2603
	[Token(Token = "0x2000A2B")]
	[ProtoContract]
	public class VeteranTaskDesc
	{
		// Token: 0x06002735 RID: 10037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002735")]
		[Address(RVA = "0x24A1604", Offset = "0x24A1604", VA = "0x7BBCCA1604")]
		public VeteranTaskDesc()
		{
		}

		// Token: 0x04002F6E RID: 12142
		[Token(Token = "0x4002F6E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F57C", Offset = "0x111F57C")]
		public uint task_id;

		// Token: 0x04002F6F RID: 12143
		[Token(Token = "0x4002F6F")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F590", Offset = "0x111F590")]
		public uint task_class;

		// Token: 0x04002F70 RID: 12144
		[Token(Token = "0x4002F70")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F5A4", Offset = "0x111F5A4")]
		public EActivity.PreConditionType pre_cdt_type1;

		// Token: 0x04002F71 RID: 12145
		[Token(Token = "0x4002F71")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F5B8", Offset = "0x111F5B8")]
		public uint pre_cdt_value1;

		// Token: 0x04002F72 RID: 12146
		[Token(Token = "0x4002F72")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F5CC", Offset = "0x111F5CC")]
		public EActivity.PreConditionType pre_cdt_type2;

		// Token: 0x04002F73 RID: 12147
		[Token(Token = "0x4002F73")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F5E0", Offset = "0x111F5E0")]
		public uint pre_cdt_value2;

		// Token: 0x04002F74 RID: 12148
		[Token(Token = "0x4002F74")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F5F4", Offset = "0x111F5F4")]
		public EActivity.PreConditionType pre_cdt_type3;

		// Token: 0x04002F75 RID: 12149
		[Token(Token = "0x4002F75")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F608", Offset = "0x111F608")]
		public uint pre_cdt_value3;

		// Token: 0x04002F76 RID: 12150
		[Token(Token = "0x4002F76")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F61C", Offset = "0x111F61C")]
		public EActivity.PreConditionType pre_cdt_type4;

		// Token: 0x04002F77 RID: 12151
		[Token(Token = "0x4002F77")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F630", Offset = "0x111F630")]
		public uint pre_cdt_value4;

		// Token: 0x04002F78 RID: 12152
		[Token(Token = "0x4002F78")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F644", Offset = "0x111F644")]
		public EActivity.PreConditionType pre_cdt_type5;

		// Token: 0x04002F79 RID: 12153
		[Token(Token = "0x4002F79")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F658", Offset = "0x111F658")]
		public uint pre_cdt_value5;

		// Token: 0x04002F7A RID: 12154
		[Token(Token = "0x4002F7A")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F66C", Offset = "0x111F66C")]
		public EActivity.ConditionType cdt_type;

		// Token: 0x04002F7B RID: 12155
		[Token(Token = "0x4002F7B")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F680", Offset = "0x111F680")]
		public uint cdt_value;

		// Token: 0x04002F7C RID: 12156
		[Token(Token = "0x4002F7C")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F694", Offset = "0x111F694")]
		public List<AwardDesc> awards;

		// Token: 0x04002F7D RID: 12157
		[Token(Token = "0x4002F7D")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F6A8", Offset = "0x111F6A8")]
		public List<Item> exchange_items;

		// Token: 0x04002F7E RID: 12158
		[Token(Token = "0x4002F7E")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111F6BC", Offset = "0x111F6BC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F6BC", Offset = "0x111F6BC")]
		public string task_text;

		// Token: 0x04002F7F RID: 12159
		[Token(Token = "0x4002F7F")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F70C", Offset = "0x111F70C")]
		public bool task_switch;

		// Token: 0x04002F80 RID: 12160
		[Token(Token = "0x4002F80")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F720", Offset = "0x111F720")]
		public uint pre_cdt_switch;
	}
}
