using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000551 RID: 1361
	[Token(Token = "0x2000551")]
	[ProtoContract]
	public class LinkageInfo
	{
		// Token: 0x06002316 RID: 8982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002316")]
		[Address(RVA = "0x24A476C", Offset = "0x24A476C", VA = "0x7BBCCA476C")]
		public LinkageInfo()
		{
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06002317 RID: 8983 RVA: 0x0000F498 File Offset: 0x0000D698
		// (set) Token: 0x06002318 RID: 8984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000666")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115A19C", Offset = "0x115A19C")]
		public uint activity_id
		{
			[Token(Token = "0x6002317")]
			[Address(RVA = "0x24A4774", Offset = "0x24A4774", VA = "0x7BBCCA4774")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B0A4", Offset = "0x113B0A4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002318")]
			[Address(RVA = "0x24A477C", Offset = "0x24A477C", VA = "0x7BBCCA477C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B0B4", Offset = "0x113B0B4")]
			set
			{
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06002319 RID: 8985 RVA: 0x0000F4B0 File Offset: 0x0000D6B0
		// (set) Token: 0x0600231A RID: 8986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000667")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115A1B0", Offset = "0x115A1B0")]
		public uint activity_type
		{
			[Token(Token = "0x6002319")]
			[Address(RVA = "0x24A4784", Offset = "0x24A4784", VA = "0x7BBCCA4784")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B0C4", Offset = "0x113B0C4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600231A")]
			[Address(RVA = "0x24A478C", Offset = "0x24A478C", VA = "0x7BBCCA478C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B0D4", Offset = "0x113B0D4")]
			set
			{
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x0600231B RID: 8987 RVA: 0x0000F4C8 File Offset: 0x0000D6C8
		// (set) Token: 0x0600231C RID: 8988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000668")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115A1C4", Offset = "0x115A1C4")]
		public uint today_data
		{
			[Token(Token = "0x600231B")]
			[Address(RVA = "0x24A4794", Offset = "0x24A4794", VA = "0x7BBCCA4794")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B0E4", Offset = "0x113B0E4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600231C")]
			[Address(RVA = "0x24A479C", Offset = "0x24A479C", VA = "0x7BBCCA479C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B0F4", Offset = "0x113B0F4")]
			set
			{
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x0600231D RID: 8989 RVA: 0x0000F4E0 File Offset: 0x0000D6E0
		// (set) Token: 0x0600231E RID: 8990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000669")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115A1D8", Offset = "0x115A1D8")]
		public uint day
		{
			[Token(Token = "0x600231D")]
			[Address(RVA = "0x24A47A4", Offset = "0x24A47A4", VA = "0x7BBCCA47A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B104", Offset = "0x113B104")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600231E")]
			[Address(RVA = "0x24A47AC", Offset = "0x24A47AC", VA = "0x7BBCCA47AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B114", Offset = "0x113B114")]
			set
			{
			}
		}

		// Token: 0x040019EB RID: 6635
		[Token(Token = "0x40019EB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104E14", Offset = "0x1104E14")]
		private uint <activity_id>k__BackingField;

		// Token: 0x040019EC RID: 6636
		[Token(Token = "0x40019EC")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104E24", Offset = "0x1104E24")]
		private uint <activity_type>k__BackingField;

		// Token: 0x040019ED RID: 6637
		[Token(Token = "0x40019ED")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104E34", Offset = "0x1104E34")]
		private uint <today_data>k__BackingField;

		// Token: 0x040019EE RID: 6638
		[Token(Token = "0x40019EE")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104E44", Offset = "0x1104E44")]
		private uint <day>k__BackingField;
	}
}
