using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004DE RID: 1246
	[Token(Token = "0x20004DE")]
	[ProtoContract]
	public class GroupMemberAccounts
	{
		// Token: 0x06001F28 RID: 7976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F28")]
		[Address(RVA = "0x24A3D28", Offset = "0x24A3D28", VA = "0x7BBCCA3D28")]
		public GroupMemberAccounts()
		{
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06001F29 RID: 7977 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F2A RID: 7978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700049A")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115703C", Offset = "0x115703C")]
		public ulong[] ids
		{
			[Token(Token = "0x6001F29")]
			[Address(RVA = "0x24A3D30", Offset = "0x24A3D30", VA = "0x7BBCCA3D30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137724", Offset = "0x1137724")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F2A")]
			[Address(RVA = "0x24A3D38", Offset = "0x24A3D38", VA = "0x7BBCCA3D38")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137734", Offset = "0x1137734")]
			set
			{
			}
		}

		// Token: 0x04001719 RID: 5913
		[Token(Token = "0x4001719")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103154", Offset = "0x1103154")]
		private ulong[] <ids>k__BackingField;
	}
}
