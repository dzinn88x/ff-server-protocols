using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B24 RID: 2852
	[Token(Token = "0x2000B24")]
	[ProtoContract]
	public class BermudaIntroDesc
	{
		// Token: 0x0600282C RID: 10284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600282C")]
		[Address(RVA = "0x21AF74C", Offset = "0x21AF74C", VA = "0x7BBC9AF74C")]
		public BermudaIntroDesc()
		{
		}

		// Token: 0x04003615 RID: 13845
		[Token(Token = "0x4003615")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C0EC", Offset = "0x112C0EC")]
		public uint id;

		// Token: 0x04003616 RID: 13846
		[Token(Token = "0x4003616")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C100", Offset = "0x112C100")]
		public uint position_id;

		// Token: 0x04003617 RID: 13847
		[Token(Token = "0x4003617")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112C114", Offset = "0x112C114")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C114", Offset = "0x112C114")]
		public string cdn_link;

		// Token: 0x04003618 RID: 13848
		[Token(Token = "0x4003618")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112C164", Offset = "0x112C164")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C164", Offset = "0x112C164")]
		public string title;

		// Token: 0x04003619 RID: 13849
		[Token(Token = "0x4003619")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112C1B4", Offset = "0x112C1B4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C1B4", Offset = "0x112C1B4")]
		public string desc;

		// Token: 0x0400361A RID: 13850
		[Token(Token = "0x400361A")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C204", Offset = "0x112C204")]
		public bool if_show;
	}
}
