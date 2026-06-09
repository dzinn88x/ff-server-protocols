using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000485 RID: 1157
	[Token(Token = "0x2000485")]
	[ProtoContract]
	public class FriendReq
	{
		// Token: 0x06001CF6 RID: 7414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CF6")]
		[Address(RVA = "0x24A2EEC", Offset = "0x24A2EEC", VA = "0x7BBCCA2EEC")]
		public FriendReq()
		{
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06001CF7 RID: 7415 RVA: 0x0000C588 File Offset: 0x0000A788
		// (set) Token: 0x06001CF8 RID: 7416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003A1")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115514C", Offset = "0x115514C")]
		public ulong adder
		{
			[Token(Token = "0x6001CF7")]
			[Address(RVA = "0x24A2F58", Offset = "0x24A2F58", VA = "0x7BBCCA2F58")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135804", Offset = "0x1135804")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001CF8")]
			[Address(RVA = "0x24A2F60", Offset = "0x24A2F60", VA = "0x7BBCCA2F60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135814", Offset = "0x1135814")]
			set
			{
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06001CF9 RID: 7417 RVA: 0x0000C5A0 File Offset: 0x0000A7A0
		// (set) Token: 0x06001CFA RID: 7418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003A2")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155160", Offset = "0x1155160")]
		public ulong addee
		{
			[Token(Token = "0x6001CF9")]
			[Address(RVA = "0x24A2F68", Offset = "0x24A2F68", VA = "0x7BBCCA2F68")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135824", Offset = "0x1135824")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001CFA")]
			[Address(RVA = "0x24A2F70", Offset = "0x24A2F70", VA = "0x7BBCCA2F70")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135834", Offset = "0x1135834")]
			set
			{
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06001CFB RID: 7419 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001CFC RID: 7420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003A3")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1155174", Offset = "0x1155174")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155174", Offset = "0x1155174")]
		public string lock_region
		{
			[Token(Token = "0x6001CFB")]
			[Address(RVA = "0x24A2F78", Offset = "0x24A2F78", VA = "0x7BBCCA2F78")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135844", Offset = "0x1135844")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001CFC")]
			[Address(RVA = "0x24A2F48", Offset = "0x24A2F48", VA = "0x7BBCCA2F48")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135854", Offset = "0x1135854")]
			set
			{
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06001CFD RID: 7421 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001CFE RID: 7422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003A4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11551C4", Offset = "0x11551C4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11551C4", Offset = "0x11551C4")]
		public string noti_region
		{
			[Token(Token = "0x6001CFD")]
			[Address(RVA = "0x24A2F80", Offset = "0x24A2F80", VA = "0x7BBCCA2F80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135864", Offset = "0x1135864")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001CFE")]
			[Address(RVA = "0x24A2F50", Offset = "0x24A2F50", VA = "0x7BBCCA2F50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135874", Offset = "0x1135874")]
			set
			{
			}
		}

		// Token: 0x04001535 RID: 5429
		[Token(Token = "0x4001535")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11021C4", Offset = "0x11021C4")]
		private ulong <adder>k__BackingField;

		// Token: 0x04001536 RID: 5430
		[Token(Token = "0x4001536")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11021D4", Offset = "0x11021D4")]
		private ulong <addee>k__BackingField;

		// Token: 0x04001537 RID: 5431
		[Token(Token = "0x4001537")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11021E4", Offset = "0x11021E4")]
		private string <lock_region>k__BackingField;

		// Token: 0x04001538 RID: 5432
		[Token(Token = "0x4001538")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11021F4", Offset = "0x11021F4")]
		private string <noti_region>k__BackingField;
	}
}
