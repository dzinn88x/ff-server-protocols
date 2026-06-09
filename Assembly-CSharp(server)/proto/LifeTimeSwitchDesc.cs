using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B02 RID: 2818
	[Token(Token = "0x2000B02")]
	[ProtoContract]
	public class LifeTimeSwitchDesc
	{
		// Token: 0x0600280A RID: 10250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600280A")]
		[Address(RVA = "0x21BB9D0", Offset = "0x21BB9D0", VA = "0x7BBC9BB9D0")]
		public LifeTimeSwitchDesc()
		{
		}

		// Token: 0x04003525 RID: 13605
		[Token(Token = "0x4003525")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A01C", Offset = "0x112A01C")]
		public uint game_mode_id;

		// Token: 0x04003526 RID: 13606
		[Token(Token = "0x4003526")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A030", Offset = "0x112A030")]
		public bool is_count;
	}
}
