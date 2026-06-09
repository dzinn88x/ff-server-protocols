using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008A1 RID: 2209
	[Token(Token = "0x20008A1")]
	[ProtoContract]
	public class MajorLoginRes
	{
		// Token: 0x060025AF RID: 9647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025AF")]
		[Address(RVA = "0x21BC350", Offset = "0x21BC350", VA = "0x7BBC9BC350")]
		public MajorLoginRes()
		{
		}

		// Token: 0x0400297F RID: 10623
		[Token(Token = "0x400297F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111561C", Offset = "0x111561C")]
		public ulong account_id;

		// Token: 0x04002980 RID: 10624
		[Token(Token = "0x4002980")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115630", Offset = "0x1115630")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1115630", Offset = "0x1115630")]
		public string lock_region;

		// Token: 0x04002981 RID: 10625
		[Token(Token = "0x4002981")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115680", Offset = "0x1115680")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1115680", Offset = "0x1115680")]
		public string noti_region;

		// Token: 0x04002982 RID: 10626
		[Token(Token = "0x4002982")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11156D0", Offset = "0x11156D0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11156D0", Offset = "0x11156D0")]
		public string ip_region;

		// Token: 0x04002983 RID: 10627
		[Token(Token = "0x4002983")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115720", Offset = "0x1115720")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1115720", Offset = "0x1115720")]
		public string agora_environment;

		// Token: 0x04002984 RID: 10628
		[Token(Token = "0x4002984")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115770", Offset = "0x1115770")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1115770", Offset = "0x1115770")]
		public string new_active_region;

		// Token: 0x04002985 RID: 10629
		[Token(Token = "0x4002985")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11157C0", Offset = "0x11157C0")]
		public List<string> recommend_regions;

		// Token: 0x04002986 RID: 10630
		[Token(Token = "0x4002986")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11157D4", Offset = "0x11157D4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11157D4", Offset = "0x11157D4")]
		public string token;

		// Token: 0x04002987 RID: 10631
		[Token(Token = "0x4002987")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115824", Offset = "0x1115824")]
		public uint ttl;

		// Token: 0x04002988 RID: 10632
		[Token(Token = "0x4002988")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115838", Offset = "0x1115838")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1115838", Offset = "0x1115838")]
		public string server_url;

		// Token: 0x04002989 RID: 10633
		[Token(Token = "0x4002989")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115888", Offset = "0x1115888")]
		public bool need_register;

		// Token: 0x0400298A RID: 10634
		[Token(Token = "0x400298A")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111589C", Offset = "0x111589C")]
		public uint emulator_score;

		// Token: 0x0400298B RID: 10635
		[Token(Token = "0x400298B")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11158B0", Offset = "0x11158B0")]
		public BlacklistInfoRes blacklist;

		// Token: 0x0400298C RID: 10636
		[Token(Token = "0x400298C")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11158C4", Offset = "0x11158C4")]
		public bool is_first_game_squad;

		// Token: 0x0400298D RID: 10637
		[Token(Token = "0x400298D")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11158D8", Offset = "0x11158D8")]
		public LoginQueueInfo queue_info;
	}
}
