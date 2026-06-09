using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005EE RID: 1518
	[Token(Token = "0x20005EE")]
	[ProtoContract]
	public class MailInfo
	{
		// Token: 0x0600236E RID: 9070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600236E")]
		[Address(RVA = "0x21BC284", Offset = "0x21BC284", VA = "0x7BBC9BC284")]
		public MailInfo()
		{
		}

		// Token: 0x04001E5F RID: 7775
		[Token(Token = "0x4001E5F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106950", Offset = "0x1106950")]
		public ulong mail_id;

		// Token: 0x04001E60 RID: 7776
		[Token(Token = "0x4001E60")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106964", Offset = "0x1106964")]
		public uint type;

		// Token: 0x04001E61 RID: 7777
		[Token(Token = "0x4001E61")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106978", Offset = "0x1106978")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1106978", Offset = "0x1106978")]
		public string title;

		// Token: 0x04001E62 RID: 7778
		[Token(Token = "0x4001E62")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11069C8", Offset = "0x11069C8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11069C8", Offset = "0x11069C8")]
		public string content;

		// Token: 0x04001E63 RID: 7779
		[Token(Token = "0x4001E63")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106A18", Offset = "0x1106A18")]
		public MailSenderInfo sender_info;

		// Token: 0x04001E64 RID: 7780
		[Token(Token = "0x4001E64")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106A2C", Offset = "0x1106A2C")]
		public MailAttachment attachment;

		// Token: 0x04001E65 RID: 7781
		[Token(Token = "0x4001E65")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106A40", Offset = "0x1106A40")]
		public long receive_time;

		// Token: 0x04001E66 RID: 7782
		[Token(Token = "0x4001E66")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106A54", Offset = "0x1106A54")]
		public EMail.Status status;

		// Token: 0x04001E67 RID: 7783
		[Token(Token = "0x4001E67")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106A68", Offset = "0x1106A68")]
		public EMail.Source source;

		// Token: 0x04001E68 RID: 7784
		[Token(Token = "0x4001E68")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106A7C", Offset = "0x1106A7C")]
		public EMail.ActionType action_type;
	}
}
