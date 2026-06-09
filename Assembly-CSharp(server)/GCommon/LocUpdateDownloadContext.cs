using System;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace GCommon
{
	// Token: 0x02000FE4 RID: 4068
	[Token(Token = "0x2000FE4")]
	public class LocUpdateDownloadContext : ResUpdateDownloadContext
	{
		// Token: 0x06003C36 RID: 15414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C36")]
		[Address(RVA = "0x212717C", Offset = "0x212717C", VA = "0x7BBC92717C")]
		public LocUpdateDownloadContext(ResUpdateDownloadEngine owned_engine, ResDownloadType type, int maxLoaderCountSimultaneously)
		{
		}

		// Token: 0x06003C37 RID: 15415 RVA: 0x00012CD8 File Offset: 0x00010ED8
		[Token(Token = "0x6003C37")]
		[Address(RVA = "0x2127184", Offset = "0x2127184", VA = "0x7BBC927184")]
		public bool CheckCurLocFile(LocLang target_lang, string config_path, bool use_assets)
		{
			return default(bool);
		}

		// Token: 0x06003C38 RID: 15416 RVA: 0x00012CF0 File Offset: 0x00010EF0
		[Token(Token = "0x6003C38")]
		[Address(RVA = "0x2127674", Offset = "0x2127674", VA = "0x7BBC927674", Slot = "13")]
		public override float GetFileDownloadProcess()
		{
			return 0f;
		}

		// Token: 0x06003C39 RID: 15417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C39")]
		[Address(RVA = "0x21276B4", Offset = "0x21276B4", VA = "0x7BBC9276B4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BE98", Offset = "0x113BE98")]
		private void <CheckCurLocFile>b__1_0(UnityWebRequest www, ResWithTempFileLoader loader)
		{
		}

		// Token: 0x06003C3A RID: 15418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C3A")]
		[Address(RVA = "0x2127CA4", Offset = "0x2127CA4", VA = "0x7BBC927CA4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BEA8", Offset = "0x113BEA8")]
		private void <CheckCurLocFile>b__1_1(string hashCode, ResUnzipFileLoader unzip_loader)
		{
		}
	}
}
