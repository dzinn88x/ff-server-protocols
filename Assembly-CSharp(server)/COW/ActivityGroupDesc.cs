using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001D3A RID: 7482
	[Token(Token = "0x2001D3A")]
	public class ActivityGroupDesc
	{
		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x0600A2B4 RID: 41652 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A2B3 RID: 41651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AB5")]
		public Dictionary<uint, List<ClientActivityDesc>> ThirdTabDict
		{
			[Token(Token = "0x600A2B4")]
			[Address(RVA = "0x1F9E148", Offset = "0x1F9E148", VA = "0x7BBC79E148")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114585C", Offset = "0x114585C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600A2B3")]
			[Address(RVA = "0x1F9E140", Offset = "0x1F9E140", VA = "0x7BBC79E140")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114584C", Offset = "0x114584C")]
			private set
			{
			}
		}

		// Token: 0x0600A2B5 RID: 41653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2B5")]
		[Address(RVA = "0x1F9E150", Offset = "0x1F9E150", VA = "0x7BBC79E150")]
		public ActivityGroupDesc(List<ClientActivityDesc> actList)
		{
		}

		// Token: 0x0400A936 RID: 43318
		[Token(Token = "0x400A936")]
		[FieldOffset(Offset = "0x10")]
		public uint group_id;

		// Token: 0x0400A937 RID: 43319
		[Token(Token = "0x400A937")]
		[FieldOffset(Offset = "0x18")]
		public string act_title;

		// Token: 0x0400A938 RID: 43320
		[Token(Token = "0x400A938")]
		[FieldOffset(Offset = "0x20")]
		public string act_text;

		// Token: 0x0400A939 RID: 43321
		[Token(Token = "0x400A939")]
		[FieldOffset(Offset = "0x28")]
		public string image_url;

		// Token: 0x0400A93A RID: 43322
		[Token(Token = "0x400A93A")]
		[FieldOffset(Offset = "0x30")]
		public string image_url_for_lobby;

		// Token: 0x0400A93B RID: 43323
		[Token(Token = "0x400A93B")]
		[FieldOffset(Offset = "0x38")]
		public string image_url_for_top_up;

		// Token: 0x0400A93C RID: 43324
		[Token(Token = "0x400A93C")]
		[FieldOffset(Offset = "0x40")]
		public uint activity_type;

		// Token: 0x0400A93D RID: 43325
		[Token(Token = "0x400A93D")]
		[FieldOffset(Offset = "0x44")]
		public uint activity_id;

		// Token: 0x0400A93E RID: 43326
		[Token(Token = "0x400A93E")]
		[FieldOffset(Offset = "0x48")]
		public uint sort_id;

		// Token: 0x0400A93F RID: 43327
		[Token(Token = "0x400A93F")]
		[FieldOffset(Offset = "0x4C")]
		public uint is_process_show;

		// Token: 0x0400A940 RID: 43328
		[Token(Token = "0x400A940")]
		[FieldOffset(Offset = "0x50")]
		public uint act_tag;

		// Token: 0x0400A941 RID: 43329
		[Token(Token = "0x400A941")]
		[FieldOffset(Offset = "0x54")]
		public uint go_pos;

		// Token: 0x0400A942 RID: 43330
		[Token(Token = "0x400A942")]
		[FieldOffset(Offset = "0x58")]
		public ulong show_time;

		// Token: 0x0400A943 RID: 43331
		[Token(Token = "0x400A943")]
		[FieldOffset(Offset = "0x60")]
		public ulong start_time;

		// Token: 0x0400A944 RID: 43332
		[Token(Token = "0x400A944")]
		[FieldOffset(Offset = "0x68")]
		public ulong end_time;

		// Token: 0x0400A945 RID: 43333
		[Token(Token = "0x400A945")]
		[FieldOffset(Offset = "0x70")]
		public string cfg_starttime;

		// Token: 0x0400A946 RID: 43334
		[Token(Token = "0x400A946")]
		[FieldOffset(Offset = "0x78")]
		public string cfg_endtime;

		// Token: 0x0400A947 RID: 43335
		[Token(Token = "0x400A947")]
		[FieldOffset(Offset = "0x80")]
		public uint table_type;

		// Token: 0x0400A948 RID: 43336
		[Token(Token = "0x400A948")]
		[FieldOffset(Offset = "0x88")]
		public ulong[] hint_reset_times;

		// Token: 0x0400A949 RID: 43337
		[Token(Token = "0x400A949")]
		[FieldOffset(Offset = "0x90")]
		public List<ClientActivityDesc> activityList;

		// Token: 0x0400A94A RID: 43338
		[Token(Token = "0x400A94A")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FDAC", Offset = "0x112FDAC")]
		private Dictionary<uint, List<ClientActivityDesc>> <ThirdTabDict>k__BackingField;

		// Token: 0x0400A94B RID: 43339
		[Token(Token = "0x400A94B")]
		[FieldOffset(Offset = "0xA0")]
		public bool awarded;

		// Token: 0x02001D3B RID: 7483
		[Token(Token = "0x2001D3B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBBA4", Offset = "0x10FBBA4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600A2B7 RID: 41655 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A2B7")]
			[Address(RVA = "0x1F9E7EC", Offset = "0x1F9E7EC", VA = "0x7BBC79E7EC")]
			public <>c()
			{
			}

			// Token: 0x0600A2B8 RID: 41656 RVA: 0x0002AAC8 File Offset: 0x00028CC8
			[Token(Token = "0x600A2B8")]
			[Address(RVA = "0x1F9E7F4", Offset = "0x1F9E7F4", VA = "0x7BBC79E7F4")]
			internal int <.ctor>b__25_0(ClientActivityDesc a, ClientActivityDesc b)
			{
				return 0;
			}

			// Token: 0x0400A94C RID: 43340
			[Token(Token = "0x400A94C")]
			[FieldOffset(Offset = "0x0")]
			public static readonly ActivityGroupDesc.<>c <>9;

			// Token: 0x0400A94D RID: 43341
			[Token(Token = "0x400A94D")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<ClientActivityDesc> <>9__25_0;
		}
	}
}
