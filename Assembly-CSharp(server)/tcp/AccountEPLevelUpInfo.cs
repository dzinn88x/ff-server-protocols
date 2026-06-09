using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200047C RID: 1148
	[Token(Token = "0x200047C")]
	[ProtoContract]
	public class AccountEPLevelUpInfo
	{
		// Token: 0x06001CE1 RID: 7393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CE1")]
		[Address(RVA = "0x24A1CB4", Offset = "0x24A1CB4", VA = "0x7BBCCA1CB4")]
		public AccountEPLevelUpInfo()
		{
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06001CE2 RID: 7394 RVA: 0x0000C4F8 File Offset: 0x0000A6F8
		// (set) Token: 0x06001CE3 RID: 7395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000399")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155084", Offset = "0x1155084")]
		public ulong account_id
		{
			[Token(Token = "0x6001CE2")]
			[Address(RVA = "0x24A1CBC", Offset = "0x24A1CBC", VA = "0x7BBCCA1CBC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135704", Offset = "0x1135704")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001CE3")]
			[Address(RVA = "0x24A1CC4", Offset = "0x24A1CC4", VA = "0x7BBCCA1CC4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135714", Offset = "0x1135714")]
			set
			{
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06001CE4 RID: 7396 RVA: 0x0000C510 File Offset: 0x0000A710
		// (set) Token: 0x06001CE5 RID: 7397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700039A")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155098", Offset = "0x1155098")]
		public uint level_before
		{
			[Token(Token = "0x6001CE4")]
			[Address(RVA = "0x24A1CCC", Offset = "0x24A1CCC", VA = "0x7BBCCA1CCC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135724", Offset = "0x1135724")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001CE5")]
			[Address(RVA = "0x24A1CD4", Offset = "0x24A1CD4", VA = "0x7BBCCA1CD4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135734", Offset = "0x1135734")]
			set
			{
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06001CE6 RID: 7398 RVA: 0x0000C528 File Offset: 0x0000A728
		// (set) Token: 0x06001CE7 RID: 7399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700039B")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11550AC", Offset = "0x11550AC")]
		public uint level_after
		{
			[Token(Token = "0x6001CE6")]
			[Address(RVA = "0x24A1CDC", Offset = "0x24A1CDC", VA = "0x7BBCCA1CDC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135744", Offset = "0x1135744")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001CE7")]
			[Address(RVA = "0x24A1CE4", Offset = "0x24A1CE4", VA = "0x7BBCCA1CE4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135754", Offset = "0x1135754")]
			set
			{
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06001CE8 RID: 7400 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001CE9 RID: 7401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700039C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11550C0", Offset = "0x11550C0")]
		public uint[] unlock_ids
		{
			[Token(Token = "0x6001CE8")]
			[Address(RVA = "0x24A1CEC", Offset = "0x24A1CEC", VA = "0x7BBCCA1CEC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135764", Offset = "0x1135764")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001CE9")]
			[Address(RVA = "0x24A1CF4", Offset = "0x24A1CF4", VA = "0x7BBCCA1CF4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135774", Offset = "0x1135774")]
			set
			{
			}
		}

		// Token: 0x0400151B RID: 5403
		[Token(Token = "0x400151B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102144", Offset = "0x1102144")]
		private ulong <account_id>k__BackingField;

		// Token: 0x0400151C RID: 5404
		[Token(Token = "0x400151C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102154", Offset = "0x1102154")]
		private uint <level_before>k__BackingField;

		// Token: 0x0400151D RID: 5405
		[Token(Token = "0x400151D")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102164", Offset = "0x1102164")]
		private uint <level_after>k__BackingField;

		// Token: 0x0400151E RID: 5406
		[Token(Token = "0x400151E")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102174", Offset = "0x1102174")]
		private uint[] <unlock_ids>k__BackingField;
	}
}
