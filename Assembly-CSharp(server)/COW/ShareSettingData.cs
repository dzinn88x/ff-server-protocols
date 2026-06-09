using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001D14 RID: 7444
	[Token(Token = "0x2001D14")]
	public class ShareSettingData : CSVBaseData
	{
		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x0600A20E RID: 41486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AA0")]
		public string SystemTextKey
		{
			[Token(Token = "0x600A20E")]
			[Address(RVA = "0x1B37408", Offset = "0x1B37408", VA = "0x7BBC337408")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A20F RID: 41487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A20F")]
		[Address(RVA = "0x1B37410", Offset = "0x1B37410", VA = "0x7BBC337410", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600A210 RID: 41488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A210")]
		[Address(RVA = "0x1B3741C", Offset = "0x1B3741C", VA = "0x7BBC33741C", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600A211 RID: 41489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A211")]
		[Address(RVA = "0x1B37644", Offset = "0x1B37644", VA = "0x7BBC337644")]
		public ShareSettingData()
		{
		}

		// Token: 0x0400A87B RID: 43131
		[Token(Token = "0x400A87B")]
		[FieldOffset(Offset = "0x10")]
		public uint ShareID;

		// Token: 0x0400A87C RID: 43132
		[Token(Token = "0x400A87C")]
		[FieldOffset(Offset = "0x18")]
		public string ShareLinkFB;

		// Token: 0x0400A87D RID: 43133
		[Token(Token = "0x400A87D")]
		[FieldOffset(Offset = "0x20")]
		public string ShareLinkVK;

		// Token: 0x0400A87E RID: 43134
		[Token(Token = "0x400A87E")]
		[FieldOffset(Offset = "0x28")]
		public string ShareLinkOthers;

		// Token: 0x0400A87F RID: 43135
		[Token(Token = "0x400A87F")]
		[FieldOffset(Offset = "0x30")]
		public string ShareTitleKey;

		// Token: 0x0400A880 RID: 43136
		[Token(Token = "0x400A880")]
		[FieldOffset(Offset = "0x38")]
		public string ShareContentKey;

		// Token: 0x0400A881 RID: 43137
		[Token(Token = "0x400A881")]
		[FieldOffset(Offset = "0x40")]
		public string ShareCaptionKey;

		// Token: 0x0400A882 RID: 43138
		[Token(Token = "0x400A882")]
		[FieldOffset(Offset = "0x48")]
		public string SharePictureUrl;

		// Token: 0x0400A883 RID: 43139
		[Token(Token = "0x400A883")]
		[FieldOffset(Offset = "0x50")]
		private string SystemTextKey_iOS;

		// Token: 0x0400A884 RID: 43140
		[Token(Token = "0x400A884")]
		[FieldOffset(Offset = "0x58")]
		private string SystemTextKey_Android;
	}
}
