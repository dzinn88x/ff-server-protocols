using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A3D RID: 2621
	[Token(Token = "0x2000A3D")]
	[ProtoContract]
	public class ClanLevelDesc
	{
		// Token: 0x06002747 RID: 10055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002747")]
		[Address(RVA = "0x21B87E4", Offset = "0x21B87E4", VA = "0x7BBC9B87E4")]
		public ClanLevelDesc()
		{
		}

		// Token: 0x04002FCA RID: 12234
		[Token(Token = "0x4002FCA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11200E4", Offset = "0x11200E4")]
		public uint level;

		// Token: 0x04002FCB RID: 12235
		[Token(Token = "0x4002FCB")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11200F8", Offset = "0x11200F8")]
		public uint min_honor;

		// Token: 0x04002FCC RID: 12236
		[Token(Token = "0x4002FCC")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112010C", Offset = "0x112010C")]
		public uint exp_buff_factor;

		// Token: 0x04002FCD RID: 12237
		[Token(Token = "0x4002FCD")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120120", Offset = "0x1120120")]
		public uint gold_buff_factor;

		// Token: 0x04002FCE RID: 12238
		[Token(Token = "0x4002FCE")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120134", Offset = "0x1120134")]
		public uint size_improved;

		// Token: 0x04002FCF RID: 12239
		[Token(Token = "0x4002FCF")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120148", Offset = "0x1120148")]
		public uint gold_limit_improved;

		// Token: 0x04002FD0 RID: 12240
		[Token(Token = "0x4002FD0")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112015C", Offset = "0x112015C")]
		public List<AwardDesc> awards;
	}
}
