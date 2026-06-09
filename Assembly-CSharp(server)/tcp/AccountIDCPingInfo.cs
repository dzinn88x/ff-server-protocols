using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200054E RID: 1358
	[Token(Token = "0x200054E")]
	[ProtoContract]
	public class AccountIDCPingInfo
	{
		// Token: 0x060022F5 RID: 8949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022F5")]
		[Address(RVA = "0x24A1D24", Offset = "0x24A1D24", VA = "0x7BBCCA1D24")]
		public AccountIDCPingInfo()
		{
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x060022F6 RID: 8950 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060022F7 RID: 8951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000657")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1159FD0", Offset = "0x1159FD0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1159FD0", Offset = "0x1159FD0")]
		public string idc
		{
			[Token(Token = "0x60022F6")]
			[Address(RVA = "0x24A1D88", Offset = "0x24A1D88", VA = "0x7BBCCA1D88")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113AEC4", Offset = "0x113AEC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60022F7")]
			[Address(RVA = "0x24A1D80", Offset = "0x24A1D80", VA = "0x7BBCCA1D80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113AED4", Offset = "0x113AED4")]
			set
			{
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x060022F8 RID: 8952 RVA: 0x0000F378 File Offset: 0x0000D578
		// (set) Token: 0x060022F9 RID: 8953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000658")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115A020", Offset = "0x115A020")]
		public int ping
		{
			[Token(Token = "0x60022F8")]
			[Address(RVA = "0x24A1D90", Offset = "0x24A1D90", VA = "0x7BBCCA1D90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113AEE4", Offset = "0x113AEE4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60022F9")]
			[Address(RVA = "0x24A1D98", Offset = "0x24A1D98", VA = "0x7BBCCA1D98")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113AEF4", Offset = "0x113AEF4")]
			set
			{
			}
		}

		// Token: 0x040019DC RID: 6620
		[Token(Token = "0x40019DC")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104D24", Offset = "0x1104D24")]
		private string <idc>k__BackingField;

		// Token: 0x040019DD RID: 6621
		[Token(Token = "0x40019DD")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104D34", Offset = "0x1104D34")]
		private int <ping>k__BackingField;
	}
}
