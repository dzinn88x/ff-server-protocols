using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200060A RID: 1546
	[Token(Token = "0x200060A")]
	[ProtoContract]
	public class LoadoutInfo
	{
		// Token: 0x06002386 RID: 9094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002386")]
		[Address(RVA = "0x21BBE08", Offset = "0x21BBE08", VA = "0x7BBC9BBE08")]
		public LoadoutInfo()
		{
		}

		// Token: 0x04001ED5 RID: 7893
		[Token(Token = "0x4001ED5")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107260", Offset = "0x1107260")]
		public uint loadout_id;

		// Token: 0x04001ED6 RID: 7894
		[Token(Token = "0x4001ED6")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107274", Offset = "0x1107274")]
		public uint loadout_num;

		// Token: 0x04001ED7 RID: 7895
		[Token(Token = "0x4001ED7")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107288", Offset = "0x1107288")]
		public bool is_free_play;
	}
}
