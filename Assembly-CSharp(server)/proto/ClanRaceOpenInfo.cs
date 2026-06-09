using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200062B RID: 1579
	[Token(Token = "0x200062B")]
	[ProtoContract]
	public class ClanRaceOpenInfo
	{
		// Token: 0x0600239C RID: 9116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600239C")]
		[Address(RVA = "0x21B89B8", Offset = "0x21B89B8", VA = "0x7BBC9B89B8")]
		public ClanRaceOpenInfo()
		{
		}

		// Token: 0x04001F6C RID: 8044
		[Token(Token = "0x4001F6C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107FA8", Offset = "0x1107FA8")]
		public long start_time;

		// Token: 0x04001F6D RID: 8045
		[Token(Token = "0x4001F6D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107FBC", Offset = "0x1107FBC")]
		public long end_time;
	}
}
