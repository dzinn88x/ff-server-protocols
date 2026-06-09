using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000626 RID: 1574
	[Token(Token = "0x2000626")]
	[ProtoContract]
	public class ClanIDSlice
	{
		// Token: 0x06002397 RID: 9111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002397")]
		[Address(RVA = "0x21B8694", Offset = "0x21B8694", VA = "0x7BBC9B8694")]
		public ClanIDSlice()
		{
		}

		// Token: 0x04001F5B RID: 8027
		[Token(Token = "0x4001F5B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107D78", Offset = "0x1107D78")]
		public ulong[] clan_ids;
	}
}
