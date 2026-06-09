using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000FCB RID: 4043
	[Token(Token = "0x2000FCB")]
	public class ResWWWFileLoader : ResWithTimeoutFileLoader
	{
		// Token: 0x06003B24 RID: 15140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B24")]
		[Address(RVA = "0x2481558", Offset = "0x2481558", VA = "0x7BBCC81558", Slot = "7")]
		protected override void OnStart(float time)
		{
		}

		// Token: 0x06003B25 RID: 15141 RVA: 0x00012678 File Offset: 0x00010878
		[Token(Token = "0x6003B25")]
		[Address(RVA = "0x2481668", Offset = "0x2481668", VA = "0x7BBCC81668", Slot = "10")]
		public override bool HasStarted()
		{
			return default(bool);
		}

		// Token: 0x06003B26 RID: 15142 RVA: 0x00012690 File Offset: 0x00010890
		[Token(Token = "0x6003B26")]
		[Address(RVA = "0x2481678", Offset = "0x2481678", VA = "0x7BBCC81678", Slot = "6")]
		public override bool IsFinished()
		{
			return default(bool);
		}

		// Token: 0x06003B27 RID: 15143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B27")]
		[Address(RVA = "0x248168C", Offset = "0x248168C", VA = "0x7BBCC8168C", Slot = "11")]
		protected override void OnUpdate(float time)
		{
		}

		// Token: 0x06003B28 RID: 15144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B28")]
		[Address(RVA = "0x2481770", Offset = "0x2481770", VA = "0x7BBCC81770", Slot = "8")]
		protected override void OnDispose()
		{
		}

		// Token: 0x06003B29 RID: 15145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B29")]
		[Address(RVA = "0x24817A0", Offset = "0x24817A0", VA = "0x7BBCC817A0", Slot = "9")]
		protected override void OnNotify()
		{
		}

		// Token: 0x06003B2A RID: 15146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B2A")]
		[Address(RVA = "0x2481910", Offset = "0x2481910", VA = "0x7BBCC81910")]
		public ResWWWFileLoader()
		{
		}

		// Token: 0x04004CA7 RID: 19623
		[Token(Token = "0x4004CA7")]
		[FieldOffset(Offset = "0x50")]
		public WWW HttpWWW;

		// Token: 0x04004CA8 RID: 19624
		[Token(Token = "0x4004CA8")]
		[FieldOffset(Offset = "0x58")]
		public Action<WWW, ResWWWFileLoader> OnLoaded;

		// Token: 0x04004CA9 RID: 19625
		[Token(Token = "0x4004CA9")]
		[FieldOffset(Offset = "0x60")]
		public ResDownloadType DownloadType;
	}
}
