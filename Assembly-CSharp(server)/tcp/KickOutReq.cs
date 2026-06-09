using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200049C RID: 1180
	[Token(Token = "0x200049C")]
	[ProtoContract]
	public class KickOutReq
	{
		// Token: 0x06001DA6 RID: 7590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DA6")]
		[Address(RVA = "0x24A4658", Offset = "0x24A4658", VA = "0x7BBCCA4658")]
		public KickOutReq()
		{
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06001DA7 RID: 7591 RVA: 0x0000CA68 File Offset: 0x0000AC68
		// (set) Token: 0x06001DA8 RID: 7592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003F3")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155C28", Offset = "0x1155C28")]
		public ulong kickout_id
		{
			[Token(Token = "0x6001DA7")]
			[Address(RVA = "0x24A4660", Offset = "0x24A4660", VA = "0x7BBCCA4660")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136244", Offset = "0x1136244")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001DA8")]
			[Address(RVA = "0x24A4668", Offset = "0x24A4668", VA = "0x7BBCCA4668")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136254", Offset = "0x1136254")]
			set
			{
			}
		}

		// Token: 0x04001618 RID: 5656
		[Token(Token = "0x4001618")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11026E4", Offset = "0x11026E4")]
		private ulong <kickout_id>k__BackingField;
	}
}
