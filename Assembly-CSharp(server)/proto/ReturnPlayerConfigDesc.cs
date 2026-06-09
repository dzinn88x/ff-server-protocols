using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AD4 RID: 2772
	[Token(Token = "0x2000AD4")]
	[ProtoContract]
	public class ReturnPlayerConfigDesc
	{
		// Token: 0x060027DC RID: 10204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027DC")]
		[Address(RVA = "0x24A0188", Offset = "0x24A0188", VA = "0x7BBCCA0188")]
		public ReturnPlayerConfigDesc()
		{
		}

		// Token: 0x04003411 RID: 13329
		[Token(Token = "0x4003411")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127AD8", Offset = "0x1127AD8")]
		public long return_player_time_secs;

		// Token: 0x04003412 RID: 13330
		[Token(Token = "0x4003412")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127AEC", Offset = "0x1127AEC")]
		public long return_playerKeep_time_secs;
	}
}
