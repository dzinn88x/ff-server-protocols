using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000FE3 RID: 4067
	[Token(Token = "0x2000FE3")]
	public class VoiceUpdateDownloadContext : ResUpdateDownloadContext
	{
		// Token: 0x06003C30 RID: 15408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C30")]
		[Address(RVA = "0x22496C4", Offset = "0x22496C4", VA = "0x7BBCA496C4")]
		public VoiceUpdateDownloadContext(ResUpdateDownloadEngine owned_engine, ResDownloadType type, int maxLoaderCountSimultaneously)
		{
		}

		// Token: 0x06003C31 RID: 15409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C31")]
		[Address(RVA = "0x22496CC", Offset = "0x22496CC", VA = "0x7BBCA496CC", Slot = "9")]
		public override void StartGetLocalVersion([Optional] Action<ResDownloadType> on_version_check_finished)
		{
		}

		// Token: 0x06003C32 RID: 15410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C32")]
		[Address(RVA = "0x2249824", Offset = "0x2249824", VA = "0x7BBCA49824", Slot = "8")]
		public override void DeleteAllFile()
		{
		}

		// Token: 0x06003C33 RID: 15411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C33")]
		[Address(RVA = "0x2249908", Offset = "0x2249908", VA = "0x7BBCA49908", Slot = "10")]
		public override void StartVersionCheck()
		{
		}

		// Token: 0x06003C34 RID: 15412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C34")]
		[Address(RVA = "0x2249C1C", Offset = "0x2249C1C", VA = "0x7BBCA49C1C", Slot = "11")]
		protected override void onRemoteVersionInfoLoaded(bool result)
		{
		}

		// Token: 0x06003C35 RID: 15413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C35")]
		[Address(RVA = "0x2249D80", Offset = "0x2249D80", VA = "0x7BBCA49D80", Slot = "12")]
		protected override void onRemoteFileInfoLoaded(bool result)
		{
		}
	}
}
