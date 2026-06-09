using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004B8 RID: 1208
	[Token(Token = "0x20004B8")]
	[ProtoContract]
	public class GroupStartNtf
	{
		// Token: 0x06001E94 RID: 7828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E94")]
		[Address(RVA = "0x24A40CC", Offset = "0x24A40CC", VA = "0x7BBCCA40CC")]
		public GroupStartNtf()
		{
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06001E95 RID: 7829 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001E96 RID: 7830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700045C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156984", Offset = "0x1156984")]
		public GroupInfo group_info
		{
			[Token(Token = "0x6001E95")]
			[Address(RVA = "0x24A40D4", Offset = "0x24A40D4", VA = "0x7BBCCA40D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136F64", Offset = "0x1136F64")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E96")]
			[Address(RVA = "0x24A40DC", Offset = "0x24A40DC", VA = "0x7BBCCA40DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136F74", Offset = "0x1136F74")]
			set
			{
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06001E97 RID: 7831 RVA: 0x0000D128 File Offset: 0x0000B328
		// (set) Token: 0x06001E98 RID: 7832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700045D")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156998", Offset = "0x1156998")]
		public uint avg_wait_time_sec
		{
			[Token(Token = "0x6001E97")]
			[Address(RVA = "0x24A40E4", Offset = "0x24A40E4", VA = "0x7BBCCA40E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136F84", Offset = "0x1136F84")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001E98")]
			[Address(RVA = "0x24A40EC", Offset = "0x24A40EC", VA = "0x7BBCCA40EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136F94", Offset = "0x1136F94")]
			set
			{
			}
		}

		// Token: 0x04001681 RID: 5761
		[Token(Token = "0x4001681")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102D74", Offset = "0x1102D74")]
		private GroupInfo <group_info>k__BackingField;

		// Token: 0x04001682 RID: 5762
		[Token(Token = "0x4001682")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102D84", Offset = "0x1102D84")]
		private uint <avg_wait_time_sec>k__BackingField;
	}
}
