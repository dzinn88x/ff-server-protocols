using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001E28 RID: 7720
	[Token(Token = "0x2001E28")]
	public class Report_CDNDownload
	{
		// Token: 0x0600A8CE RID: 43214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8CE")]
		[Address(RVA = "0x175C9D0", Offset = "0x175C9D0", VA = "0x7BBBF5C9D0")]
		public Report_CDNDownload()
		{
		}

		// Token: 0x0400AE21 RID: 44577
		[Token(Token = "0x400AE21")]
		[FieldOffset(Offset = "0x10")]
		public string region;

		// Token: 0x0400AE22 RID: 44578
		[Token(Token = "0x400AE22")]
		[FieldOffset(Offset = "0x18")]
		public string target_url;

		// Token: 0x0400AE23 RID: 44579
		[Token(Token = "0x400AE23")]
		[FieldOffset(Offset = "0x20")]
		public string country;

		// Token: 0x0400AE24 RID: 44580
		[Token(Token = "0x400AE24")]
		[FieldOffset(Offset = "0x28")]
		public string client_ip;

		// Token: 0x0400AE25 RID: 44581
		[Token(Token = "0x400AE25")]
		[FieldOffset(Offset = "0x30")]
		public string network_type;

		// Token: 0x0400AE26 RID: 44582
		[Token(Token = "0x400AE26")]
		[FieldOffset(Offset = "0x38")]
		public string platform;

		// Token: 0x0400AE27 RID: 44583
		[Token(Token = "0x400AE27")]
		[FieldOffset(Offset = "0x40")]
		public long response_code;

		// Token: 0x0400AE28 RID: 44584
		[Token(Token = "0x400AE28")]
		[FieldOffset(Offset = "0x48")]
		public float req_time;

		// Token: 0x0400AE29 RID: 44585
		[Token(Token = "0x400AE29")]
		[FieldOffset(Offset = "0x50")]
		public string host_ip;
	}
}
