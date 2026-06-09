using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008E1 RID: 2273
	[Token(Token = "0x20008E1")]
	[ProtoContract]
	public class VideoDetail
	{
		// Token: 0x060025EF RID: 9711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025EF")]
		[Address(RVA = "0x24A171C", Offset = "0x24A171C", VA = "0x7BBCCA171C")]
		public VideoDetail()
		{
		}

		// Token: 0x04002A7B RID: 10875
		[Token(Token = "0x4002A7B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11170AC", Offset = "0x11170AC")]
		public uint video_id;

		// Token: 0x04002A7C RID: 10876
		[Token(Token = "0x4002A7C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11170C0", Offset = "0x11170C0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11170C0", Offset = "0x11170C0")]
		public string video_url;

		// Token: 0x04002A7D RID: 10877
		[Token(Token = "0x4002A7D")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117110", Offset = "0x1117110")]
		public uint video_type;

		// Token: 0x04002A7E RID: 10878
		[Token(Token = "0x4002A7E")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1117124", Offset = "0x1117124")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117124", Offset = "0x1117124")]
		public string video_name;

		// Token: 0x04002A7F RID: 10879
		[Token(Token = "0x4002A7F")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117174", Offset = "0x1117174")]
		public uint video_sort_id;

		// Token: 0x04002A80 RID: 10880
		[Token(Token = "0x4002A80")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117188", Offset = "0x1117188")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1117188", Offset = "0x1117188")]
		public string thumbnail_url;

		// Token: 0x04002A81 RID: 10881
		[Token(Token = "0x4002A81")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11171D8", Offset = "0x11171D8")]
		public uint create_at;

		// Token: 0x04002A82 RID: 10882
		[Token(Token = "0x4002A82")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11171EC", Offset = "0x11171EC")]
		public ulong hit_count;

		// Token: 0x04002A83 RID: 10883
		[Token(Token = "0x4002A83")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117200", Offset = "0x1117200")]
		public ulong streamer_account_id;

		// Token: 0x04002A84 RID: 10884
		[Token(Token = "0x4002A84")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117214", Offset = "0x1117214")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1117214", Offset = "0x1117214")]
		public string streamer_nickname;

		// Token: 0x04002A85 RID: 10885
		[Token(Token = "0x4002A85")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117264", Offset = "0x1117264")]
		public EInventory.GenderType streamer_sex;

		// Token: 0x04002A86 RID: 10886
		[Token(Token = "0x4002A86")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117278", Offset = "0x1117278")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1117278", Offset = "0x1117278")]
		public string create_date;
	}
}
