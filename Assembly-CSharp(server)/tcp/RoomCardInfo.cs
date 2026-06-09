using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200053D RID: 1341
	[Token(Token = "0x200053D")]
	[ProtoContract]
	public class RoomCardInfo
	{
		// Token: 0x060021A0 RID: 8608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021A0")]
		[Address(RVA = "0x24A5E90", Offset = "0x24A5E90", VA = "0x7BBCCA5E90")]
		public RoomCardInfo()
		{
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x060021A1 RID: 8609 RVA: 0x0000E928 File Offset: 0x0000CB28
		// (set) Token: 0x060021A2 RID: 8610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B5")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158EF0", Offset = "0x1158EF0")]
		public uint id
		{
			[Token(Token = "0x60021A1")]
			[Address(RVA = "0x24A5E98", Offset = "0x24A5E98", VA = "0x7BBCCA5E98")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139A84", Offset = "0x1139A84")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60021A2")]
			[Address(RVA = "0x24A5EA0", Offset = "0x24A5EA0", VA = "0x7BBCCA5EA0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139A94", Offset = "0x1139A94")]
			set
			{
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x060021A3 RID: 8611 RVA: 0x0000E940 File Offset: 0x0000CB40
		// (set) Token: 0x060021A4 RID: 8612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B6")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158F04", Offset = "0x1158F04")]
		public uint cnt
		{
			[Token(Token = "0x60021A3")]
			[Address(RVA = "0x24A5EA8", Offset = "0x24A5EA8", VA = "0x7BBCCA5EA8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139AA4", Offset = "0x1139AA4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60021A4")]
			[Address(RVA = "0x24A5EB0", Offset = "0x24A5EB0", VA = "0x7BBCCA5EB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139AB4", Offset = "0x1139AB4")]
			set
			{
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x060021A5 RID: 8613 RVA: 0x0000E958 File Offset: 0x0000CB58
		// (set) Token: 0x060021A6 RID: 8614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B7")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158F18", Offset = "0x1158F18")]
		public uint expire_time
		{
			[Token(Token = "0x60021A5")]
			[Address(RVA = "0x24A5EB8", Offset = "0x24A5EB8", VA = "0x7BBCCA5EB8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139AC4", Offset = "0x1139AC4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60021A6")]
			[Address(RVA = "0x24A5EC0", Offset = "0x24A5EC0", VA = "0x7BBCCA5EC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139AD4", Offset = "0x1139AD4")]
			set
			{
			}
		}

		// Token: 0x0400193A RID: 6458
		[Token(Token = "0x400193A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104304", Offset = "0x1104304")]
		private uint <id>k__BackingField;

		// Token: 0x0400193B RID: 6459
		[Token(Token = "0x400193B")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104314", Offset = "0x1104314")]
		private uint <cnt>k__BackingField;

		// Token: 0x0400193C RID: 6460
		[Token(Token = "0x400193C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104324", Offset = "0x1104324")]
		private uint <expire_time>k__BackingField;
	}
}
