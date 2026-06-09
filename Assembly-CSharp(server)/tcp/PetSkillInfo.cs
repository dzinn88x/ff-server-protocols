using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000545 RID: 1349
	[Token(Token = "0x2000545")]
	[ProtoContract]
	public class PetSkillInfo
	{
		// Token: 0x060021D4 RID: 8660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021D4")]
		[Address(RVA = "0x24A5834", Offset = "0x24A5834", VA = "0x7BBCCA5834")]
		public PetSkillInfo()
		{
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x060021D5 RID: 8661 RVA: 0x0000EB38 File Offset: 0x0000CD38
		// (set) Token: 0x060021D6 RID: 8662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005CB")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11590A8", Offset = "0x11590A8")]
		public uint skill_id
		{
			[Token(Token = "0x60021D5")]
			[Address(RVA = "0x24A583C", Offset = "0x24A583C", VA = "0x7BBCCA583C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139D44", Offset = "0x1139D44")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60021D6")]
			[Address(RVA = "0x24A5844", Offset = "0x24A5844", VA = "0x7BBCCA5844")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139D54", Offset = "0x1139D54")]
			set
			{
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x060021D7 RID: 8663 RVA: 0x0000EB50 File Offset: 0x0000CD50
		// (set) Token: 0x060021D8 RID: 8664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005CC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11590BC", Offset = "0x11590BC")]
		public uint skill_level
		{
			[Token(Token = "0x60021D7")]
			[Address(RVA = "0x24A584C", Offset = "0x24A584C", VA = "0x7BBCCA584C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139D64", Offset = "0x1139D64")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60021D8")]
			[Address(RVA = "0x24A5854", Offset = "0x24A5854", VA = "0x7BBCCA5854")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139D74", Offset = "0x1139D74")]
			set
			{
			}
		}

		// Token: 0x04001950 RID: 6480
		[Token(Token = "0x4001950")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104464", Offset = "0x1104464")]
		private uint <skill_id>k__BackingField;

		// Token: 0x04001951 RID: 6481
		[Token(Token = "0x4001951")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104474", Offset = "0x1104474")]
		private uint <skill_level>k__BackingField;
	}
}
