using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200066B RID: 1643
	[Token(Token = "0x200066B")]
	[ProtoContract]
	public class ELive
	{
		// Token: 0x060023BC RID: 9148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023BC")]
		[Address(RVA = "0x21B9850", Offset = "0x21B9850", VA = "0x7BBC9B9850")]
		public ELive()
		{
		}

		// Token: 0x0200066C RID: 1644
		[Token(Token = "0x200066C")]
		[ProtoContract]
		public enum FollowerType
		{
			// Token: 0x04002064 RID: 8292
			[Token(Token = "0x4002064")]
			FollowerType_NONE,
			// Token: 0x04002065 RID: 8293
			[Token(Token = "0x4002065")]
			FollowerType_YES,
			// Token: 0x04002066 RID: 8294
			[Token(Token = "0x4002066")]
			FollowerType_NO
		}

		// Token: 0x0200066D RID: 1645
		[Token(Token = "0x200066D")]
		[ProtoContract]
		public enum VideoType
		{
			// Token: 0x04002068 RID: 8296
			[Token(Token = "0x4002068")]
			VideoType_NONE,
			// Token: 0x04002069 RID: 8297
			[Token(Token = "0x4002069")]
			VideoType_HOTEST,
			// Token: 0x0400206A RID: 8298
			[Token(Token = "0x400206A")]
			VideoType_LIVE_NOW,
			// Token: 0x0400206B RID: 8299
			[Token(Token = "0x400206B")]
			VideoType_EXPLORE,
			// Token: 0x0400206C RID: 8300
			[Token(Token = "0x400206C")]
			VideoType_TUTORIAL,
			// Token: 0x0400206D RID: 8301
			[Token(Token = "0x400206D")]
			VideoType_ALL = 100,
			// Token: 0x0400206E RID: 8302
			[Token(Token = "0x400206E")]
			VideoType_NEWEST,
			// Token: 0x0400206F RID: 8303
			[Token(Token = "0x400206F")]
			VideoType_POPULAR,
			// Token: 0x04002070 RID: 8304
			[Token(Token = "0x4002070")]
			VideoType_OTHER
		}
	}
}
