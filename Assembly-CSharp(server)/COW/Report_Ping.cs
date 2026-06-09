using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001E26 RID: 7718
	[Token(Token = "0x2001E26")]
	public class Report_Ping
	{
		// Token: 0x0600A8CC RID: 43212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8CC")]
		[Address(RVA = "0x175C9D8", Offset = "0x175C9D8", VA = "0x7BBBF5C9D8")]
		public Report_Ping()
		{
		}

		// Token: 0x0400AE13 RID: 44563
		[Token(Token = "0x400AE13")]
		[FieldOffset(Offset = "0x10")]
		public byte build_variant_type;

		// Token: 0x0400AE14 RID: 44564
		[Token(Token = "0x400AE14")]
		[FieldOffset(Offset = "0x18")]
		public string region;

		// Token: 0x0400AE15 RID: 44565
		[Token(Token = "0x400AE15")]
		[FieldOffset(Offset = "0x20")]
		public string country;

		// Token: 0x0400AE16 RID: 44566
		[Token(Token = "0x400AE16")]
		[FieldOffset(Offset = "0x28")]
		public string phone_carrier;

		// Token: 0x0400AE17 RID: 44567
		[Token(Token = "0x400AE17")]
		[FieldOffset(Offset = "0x30")]
		public string client_ip;

		// Token: 0x0400AE18 RID: 44568
		[Token(Token = "0x400AE18")]
		[FieldOffset(Offset = "0x38")]
		public List<PingResult> ping_results;

		// Token: 0x0400AE19 RID: 44569
		[Token(Token = "0x400AE19")]
		[FieldOffset(Offset = "0x40")]
		public List<TracerouteResult> trace_results;
	}
}
