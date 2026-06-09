using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200054D RID: 1357
	[Token(Token = "0x200054D")]
	[ProtoContract]
	public class TeammateCheatingNtf
	{
		// Token: 0x060022F2 RID: 8946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022F2")]
		[Address(RVA = "0x24A718C", Offset = "0x24A718C", VA = "0x7BBCCA718C")]
		public TeammateCheatingNtf()
		{
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x060022F3 RID: 8947 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060022F4 RID: 8948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000656")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1159F80", Offset = "0x1159F80")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1159F80", Offset = "0x1159F80")]
		public string invitee_nickname
		{
			[Token(Token = "0x60022F3")]
			[Address(RVA = "0x24A71F0", Offset = "0x24A71F0", VA = "0x7BBCCA71F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113AEA4", Offset = "0x113AEA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60022F4")]
			[Address(RVA = "0x24A71E8", Offset = "0x24A71E8", VA = "0x7BBCCA71E8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113AEB4", Offset = "0x113AEB4")]
			set
			{
			}
		}

		// Token: 0x040019DB RID: 6619
		[Token(Token = "0x40019DB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104D14", Offset = "0x1104D14")]
		private string <invitee_nickname>k__BackingField;
	}
}
