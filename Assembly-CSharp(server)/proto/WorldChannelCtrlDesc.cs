using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AF5 RID: 2805
	[Token(Token = "0x2000AF5")]
	[ProtoContract]
	public class WorldChannelCtrlDesc
	{
		// Token: 0x060027FD RID: 10237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027FD")]
		[Address(RVA = "0x24A1B5C", Offset = "0x24A1B5C", VA = "0x7BBCCA1B5C")]
		public WorldChannelCtrlDesc()
		{
		}

		// Token: 0x040034D8 RID: 13528
		[Token(Token = "0x40034D8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11295A4", Offset = "0x11295A4")]
		public bool enable;

		// Token: 0x040034D9 RID: 13529
		[Token(Token = "0x40034D9")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11295B8", Offset = "0x11295B8")]
		public uint channel_capacity;

		// Token: 0x040034DA RID: 13530
		[Token(Token = "0x40034DA")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11295CC", Offset = "0x11295CC")]
		public uint clear_channel_cdt_size;

		// Token: 0x040034DB RID: 13531
		[Token(Token = "0x40034DB")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11295E0", Offset = "0x11295E0")]
		public uint clear_channel_cdt_time;

		// Token: 0x040034DC RID: 13532
		[Token(Token = "0x40034DC")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11295F4", Offset = "0x11295F4")]
		public uint merge_scan_interval;

		// Token: 0x040034DD RID: 13533
		[Token(Token = "0x40034DD")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129608", Offset = "0x1129608")]
		public uint daily_msg_limit_default;

		// Token: 0x040034DE RID: 13534
		[Token(Token = "0x40034DE")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112961C", Offset = "0x112961C")]
		public uint daily_msg_limit_fast;

		// Token: 0x040034DF RID: 13535
		[Token(Token = "0x40034DF")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129630", Offset = "0x1129630")]
		public uint sticky_speaker_item_id;

		// Token: 0x040034E0 RID: 13536
		[Token(Token = "0x40034E0")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129644", Offset = "0x1129644")]
		public bool enable_custom_msg;

		// Token: 0x040034E1 RID: 13537
		[Token(Token = "0x40034E1")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129658", Offset = "0x1129658")]
		public List<string> main_lang_array;
	}
}
