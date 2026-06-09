using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000800 RID: 2048
	[Token(Token = "0x2000800")]
	[ProtoContract]
	public class CSGetSkillListRes
	{
		// Token: 0x0600250F RID: 9487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600250F")]
		[Address(RVA = "0x21B5AC0", Offset = "0x21B5AC0", VA = "0x7BBC9B5AC0")]
		public CSGetSkillListRes()
		{
		}

		// Token: 0x040026E5 RID: 9957
		[Token(Token = "0x40026E5")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110914", Offset = "0x1110914")]
		public ulong account_id;

		// Token: 0x040026E6 RID: 9958
		[Token(Token = "0x40026E6")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110928", Offset = "0x1110928")]
		public uint[] skills;
	}
}
